using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VideoMaster
{
    public partial class formIzmjeniFilm : Form
    {
        private int selectedID_Film;
        private byte[] slikaBytes;

        public formIzmjeniFilm(int ID_Film)
        {
            InitializeComponent();
            selectedID_Film = ID_Film;
            UcitajInfo();


            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formIzmjeniFilm.html");

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


        private void UcitajInfo()
        {
            Film film = VratiInfoPoID(selectedID_Film);

            if (film != null)
            {
                txtNaziv.Text = film.Naziv;
                txtRedatelj.Text = film.ID_Redatelj.ToString();
                txtTrajanje.Text = film.Trajanje.ToString();
                dtpGodina.Value = film.Datum_izdavanja;

                using (var context = new PI2324_02_DBEntities())
                {
                    var dob = context.DobnoOgranicenje
                                     .Select(d => d.Naziv)
                                     .Distinct()
                                     .ToList();

                    cmbDobroOgranicenje.DataSource = dob.Select(o => new { DobnoOgranicenje = o }).ToList();
                    cmbDobroOgranicenje.DisplayMember = "DobnoOgranicenje";
                    cmbDobroOgranicenje.ValueMember = "DobnoOgranicenje";

                    Image thumbnail = PretvorbaUSliku(film.Thumbnail);
                    pbThumbnail.Image = thumbnail;
                    slikaBytes = film.Thumbnail; // Store the existing image bytes
                }
            }
        }

        private Image PretvorbaUSliku(byte[] unos)
        {
            if (unos == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream(unos))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private Film VratiInfoPoID(int ID_Film)
        {
            using (var context = new PI2324_02_DBEntities())
            {
                return context.Film.FirstOrDefault(f => f.ID_Film == ID_Film);
            }
        }

        private void pbThumbnail_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog upload = new OpenFileDialog())
            {
                upload.Filter = "Slike (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (upload.ShowDialog() == DialogResult.OK)
                {
                    string putanja = upload.FileName;
                    pbThumbnail.Image = Image.FromFile(putanja);
                    slikaBytes = File.ReadAllBytes(putanja);
                }
            }
        }

        private void btnSpremiFilm_Click(object sender, EventArgs e)
        {
            using (var context = new PI2324_02_DBEntities())
            {
                Film film = context.Film.FirstOrDefault(f => f.ID_Film == selectedID_Film);

                if (film != null)
                {
                    film.Naziv = txtNaziv.Text;
                    film.ID_Redatelj = int.Parse(txtRedatelj.Text);
                    film.Trajanje = int.Parse(txtTrajanje.Text);
                    film.Datum_izdavanja = dtpGodina.Value;

                    if (slikaBytes != null)
                    {
                        film.Thumbnail = slikaBytes;
                    }

                    context.SaveChanges();
                    MessageBox.Show("Film je uspješno uređen.");
                }
                else
                {
                    MessageBox.Show("Imate grešku.");
                }
            }
        }
    }
}
