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
using System.Windows.Forms.VisualStyles;

namespace VideoMaster
{
    public partial class formIzmjeniKorisnika : Form
    {
        private PI2324_02_DBEntities DB_Entities;
        private Korisnik OdabraniKorisnik;
        private byte[] slika;
        public formIzmjeniKorisnika(Korisnik odabraniKorisnik)
        {
            InitializeComponent();
            DB_Entities = new PI2324_02_DBEntities();
            this.OdabraniKorisnik = odabraniKorisnik;


            helpProvider1 = new HelpProvider();
            string documentationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"F1/formIzmjeniKorisnika.html");
            helpProvider1.HelpNamespace = documentationPath;
            helpProvider1.SetHelpNavigator(this, HelpNavigator.TableOfContents);
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

        private void formIzmjeniKorisnika_Load(object sender, EventArgs e)
        {
            Image profilna = PretvorbaUSliku(OdabraniKorisnik.Slika_profila);
            pbProfilna.Image = profilna;
            txtIme.Text = OdabraniKorisnik.Ime;
            txtPrezime.Text = OdabraniKorisnik.Prezime;
            txtNadimak.Text = OdabraniKorisnik.Nadimak;
            txtLozinka.Text = OdabraniKorisnik.Lozinka;
            cmbUloga.SelectedItem = OdabraniKorisnik.ID_Uloga.ToString();
        }
        private void btnNatrag_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
            if (OdabraniKorisnik.ID_Uloga == 1 || OdabraniKorisnik.ID_Uloga == 2)
            {
                MessageBox.Show("Admin i zaposlenik nemaju dozvolu za promjenu slike profila.", "Nema dozvole", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (OpenFileDialog upload = new OpenFileDialog())
                {
                    upload.Filter = "Slike (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                    if (upload.ShowDialog() == DialogResult.OK)
                    {
                        string putanja = upload.FileName;
                        pbProfilna.Image = Image.FromFile(putanja);
                        slika = File.ReadAllBytes(putanja);
                    }
                }
            }
            
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string nadimak = txtNadimak.Text;
            string lozinka = txtLozinka.Text;
            OdabraniKorisnik.Ime = ime;
            OdabraniKorisnik.Prezime = prezime;
            OdabraniKorisnik.Nadimak = nadimak;
            OdabraniKorisnik.Lozinka = lozinka;
            int uloga;
            if (slika != null)
            {
                OdabraniKorisnik.Slika_profila = slika;
            }
            var query = DB_Entities.Korisnik.FirstOrDefault(n => n.ID_Korisnik == OdabraniKorisnik.ID_Korisnik);
            if (int.TryParse(cmbUloga.SelectedItem.ToString(), out uloga))
            {
                OdabraniKorisnik.ID_Uloga = uloga;
                if (query != null)
                {
                    if (!string.IsNullOrWhiteSpace(txtIme.Text) && !string.IsNullOrWhiteSpace(txtPrezime.Text) && !string.IsNullOrWhiteSpace(txtNadimak.Text) && !string.IsNullOrWhiteSpace(txtLozinka.Text))
                    {
                        query.Ime = ime;
                        query.Prezime = prezime;
                        query.Nadimak = nadimak;
                        query.Lozinka = lozinka;
                        query.ID_Uloga = uloga;
                        if (slika != null)
                        {
                            query.Slika_profila = slika;

                        }
                        DB_Entities.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Polja s podacima ne mogu biti prazna!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Odaberite ulogu korisnika!");
            }
        }
        ~formIzmjeniKorisnika()
        {
            DB_Entities.Dispose();
        }
    }
}
