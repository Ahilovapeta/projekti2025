using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VideoMaster
{
    public partial class formDodajFilm : Form
    {
        private byte[] slikaBytes;

        public formDodajFilm()
        {
            InitializeComponent();
            UcitajDobnaOgranicenja();

            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formDodajFilm.html");

            if (!File.Exists(documentationPath))
            {
                MessageBox.Show("Datoteka s dokumentacijom ne postoji: " + documentationPath);
            }
            else
            {
                helpProvider1.HelpNamespace = documentationPath;
                helpProvider1.SetHelpNavigator(this, HelpNavigator.TableOfContents);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                // Otvori dokumentaciju pomoću HelpProvider kontrole
                Help.ShowHelp(this, helpProvider1.HelpNamespace);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UcitajDobnaOgranicenja()
        {
            using (var context = new PI2324_02_DBEntities())
            {
                var dob = context.RoditeljskaZastita
                                 .Select(d => d.Oznaka)
                                 .Distinct()
                                 .ToList();

                cmbDobnoOgranicenje.DataSource = dob.Select(o => new { Dobno_ogranicenje = o }).ToList();
                cmbDobnoOgranicenje.DisplayMember = "Dobno_ogranicenje";
                cmbDobnoOgranicenje.ValueMember = "Dobno_ogranicenje";
            }
        }

        private void btnUploadThumbnail_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Slike (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string putanja = ofd.FileName;
                pbThumbnail.Image = Image.FromFile(putanja);
                slikaBytes = File.ReadAllBytes(putanja);
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                using (var context = new PI2324_02_DBEntities())
                {
                    Film noviFilm = new Film
                    {
                        Naziv = txtNaziv.Text,
                        ID_Zanr = int.Parse(txtZanr.Text),
                        ID_Redatelj = int.Parse(txtRedatelj.Text),
                        Trajanje = int.Parse(txtTrajanje.Text),
                        Datum_izdavanja = dtpGodina.Value,
                        Thumbnail = slikaBytes,
                        ID_Dobno_ogranicenje = GetSelectedRatingID(cmbDobnoOgranicenje.Text),
                        Adresa_url = txtAdresa_url.Text,
                    };

                    context.Film.Add(noviFilm);
                    context.SaveChanges();
                    MessageBox.Show("Film je uspješno dodan!");
                    this.Close();
                    formUpravljanjeFilmovima formUpravljanjeFilmovima = new formUpravljanjeFilmovima();
                    formUpravljanjeFilmovima.Show();
                }
            }
        }

        private bool ValidirajUnos()
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Dodajte naziv.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRedatelj.Text))
            {
                MessageBox.Show("Dodajte redatelja.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTrajanje.Text))
            {
                MessageBox.Show("Dodajte trajanje u minutama.");
                return false;
            }

            if (cmbDobnoOgranicenje.SelectedIndex == -1)
            {
                MessageBox.Show("Dodajte dobro ograničenje.");
                return false;
            }

            if (slikaBytes == null)
            {
                MessageBox.Show("Dodajte sliku filma.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAdresa_url.Text))
            {
                MessageBox.Show("Dodajte url adresu");
                return false;
            }

            return true;
        }

        private int GetSelectedRatingID(string ratingName)
        {
            using (var context = new PI2324_02_DBEntities())
            {
                var rating = context.DobnoOgranicenje.FirstOrDefault(r => r.Naziv == ratingName);
                return rating?.ID_Dobno_ogranicenje ?? 0;
            }
        }
    }
}
