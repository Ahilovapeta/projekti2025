using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VideoMaster
{
    public partial class formPrijava : Form
    {
        private PI2324_02_DBEntities DB_Entities;

        public formPrijava()
        {
            InitializeComponent();
            DB_Entities = new PI2324_02_DBEntities();

            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "Prijava.html");

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

        private void bntNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            if (!string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && !string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                var korisnik = DB_Entities.Korisnik.FirstOrDefault(k => k.Nadimak == korIme && k.Lozinka == lozinka);
                if(korisnik != null)
                {
                    if (korisnik.ID_Uloga == 1)
                    {
                        this.Hide();
                        formAdministratorPocetna formAdministratorPocetna = new formAdministratorPocetna(korisnik);
                        formAdministratorPocetna.ShowDialog();
                        this.Show();
                    }
                    else if (korisnik.ID_Uloga == 2)
                    {
                        this.Hide();
                        formZaposlenikPocetna formZaposlenikPocetna = new formZaposlenikPocetna(korisnik);
                        formZaposlenikPocetna.ShowDialog();
                    }
                    else if (korisnik.ID_Uloga == 3)
                    {
                        this.Hide();
                        formIndividualniKorisnikPocetna formIndividualniKorisnikPocetna = new formIndividualniKorisnikPocetna(korisnik);
                        formIndividualniKorisnikPocetna.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Neispravni podaci!");
                }
            }
            else
            {
                MessageBox.Show("Popunite oba polja!");
            }
        }

        private void formPrijava_Load(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = "Marko66";
            txtLozinka.Text = "juric66";
            //txtKorisnickoIme.Text = "Admin";
            //txtLozinka.Text = "AkSDe23";
            //txtKorisnickoIme.Text = "Zaposlenik1";
            //txtLozinka.Text = "smor9a";

            // Privremeni ispis svih korisnika u konzolu
            foreach (var korisnik in DB_Entities.Korisnik)
            {
                Console.WriteLine($"{korisnik.Nadimak} - {korisnik.Lozinka}");
            }
        }

        ~formPrijava()
        {
            DB_Entities.Dispose();
        }
    }
}
