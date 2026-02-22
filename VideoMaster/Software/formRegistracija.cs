using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoMaster.Iznimke;


namespace VideoMaster
{
    public partial class formRegistracija : Form
    {
        private PI2324_02_DBEntities DB_Entities = new PI2324_02_DBEntities();

        public formRegistracija()
        {
            InitializeComponent();

            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formRegistracija.html");

            if (!File.Exists(documentationPath))
            {
                MessageBox.Show("Datoteka s dokumentacijom ne postoji: " + documentationPath);
            }
            else
            {
                helpProvider1.HelpNamespace = documentationPath;
                helpProvider1.SetHelpNavigator(this, HelpNavigator.TableOfContents);
            }

            btnRegistracija.Click += btnRegistracija_Click;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, helpProvider1.HelpNamespace);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korisnickoIme = txtKorisnickoIme.Text;
            string email = txtEmail.Text;
            string lozinka = txtLozinka.Text;
            string potvrdiLozinku = txtPotvrdiLozinku.Text;

            if (ime == null || ime == "" ||
                prezime == null || prezime == "" ||
                korisnickoIme == null || korisnickoIme == "" ||
                email == null || email == "" ||
                lozinka == null || lozinka == "" ||
                potvrdiLozinku == null || potvrdiLozinku == "")
            {
                var ex = new RegistracijaException("Sva polja su obavezna");
                MessageBox.Show(ex.Poruka);
                return;
            }

            string emailPattern = @"^[^@\\s]+@[^@\\s]+\.[^@\\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                var ex = new RegistracijaException("Email nije u ispravnom formatu (npr. korisnik@domena.com)");
                MessageBox.Show(ex.Poruka);
                return;
            }

            if (lozinka != potvrdiLozinku)
            {
                var ex = new RegistracijaException("Niste potvrdili lozinku, oba polja za lozinku moraju biti ista");
                MessageBox.Show(ex.Poruka);
                return;
            }

            if (DB_Entities.Korisnik.Any(k => k.Nadimak == korisnickoIme))
            {
                var ex = new RegistracijaException("Korisničko ime je već zauzeto");
                MessageBox.Show(ex.Poruka);
                return;
            }

            var noviKorisnik = new Korisnik
            {
                Ime = ime,
                Prezime = prezime,
                Nadimak = korisnickoIme,
                Email = email,
                Lozinka = lozinka,
                Datum_izrade_racuna = DateTime.Now,
                ID_Uloga = 3 
            };
            DB_Entities.Korisnik.Add(noviKorisnik);

            try
            {
                DB_Entities.SaveChanges();
                MessageBox.Show("Registracija uspješna! Sada se možete prijaviti.");
                this.Close();
            }
            catch (RegistracijaException rex)
            {
                MessageBox.Show($"Registracija nije uspjela: {rex.Poruka}");
            }
        }

        private void btnRegistracija_Click_1(object sender, EventArgs e)
        {

        }
    }
}
