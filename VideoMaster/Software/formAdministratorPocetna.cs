using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMaster
{
    public partial class formAdministratorPocetna : Form
    {
        private Korisnik OdabraniKorisnik;
        public formAdministratorPocetna(Korisnik korisnik)
        {
            InitializeComponent();
            this.OdabraniKorisnik = korisnik;

            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formAdministratorPocetna.html");

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

        private void formAdministratorPocetna_Load(object sender, EventArgs e)
        {
            lblKorisnickoIme.Text = OdabraniKorisnik.Nadimak;
            lblKorisnickoIme.Parent = pbBanner;
            lblKorisnickoIme.BackColor = Color.Transparent;

            if (OdabraniKorisnik.Slika_profila != null && OdabraniKorisnik.Slika_profila.Length > 0)
            {
                Image profilna = PretvorbaUSliku(OdabraniKorisnik.Slika_profila);
                pbProfilna.Image = profilna;
            }
            else
            {
                MessageBox.Show("Slika profila nije dostupna ili je prazna.");
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            this.Hide();
            formUpravljanjeKorisnicima formUpravljanjeKorisnicima = new formUpravljanjeKorisnicima();
            formUpravljanjeKorisnicima.ShowDialog();
            this.Show();
        }

        private void btnUpravljanjeFilmovima_Click(object sender, EventArgs e)
        {
            this.Hide();
            formUpravljanjeFilmovima formUpravljanjeFilmovima = new formUpravljanjeFilmovima();
            formUpravljanjeFilmovima.ShowDialog();
            this.Show();
        }

        private void btnUpravljanjeNovostima_Click(object sender, EventArgs e)
        {
            this.Hide();
            formUpravljanjeNovostima formUpravljanjeNovostima = new formUpravljanjeNovostima();
            formUpravljanjeNovostima.ShowDialog();
            this.Show();
        }

        private Image PretvorbaUSliku(byte[] unos)
        {
            if (unos == null)
                return null;

            using (MemoryStream ms = new MemoryStream(unos))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void pbProfilna_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin nema dozvolu za promjenu slike profila.", "Nema dozvole", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
