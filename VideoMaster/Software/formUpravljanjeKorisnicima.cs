using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMaster
{
    public partial class formUpravljanjeKorisnicima : Form
    {
        private PI2324_02_DBEntities DB_Entities;
        public formUpravljanjeKorisnicima()
        {
            InitializeComponent();
            DB_Entities = new PI2324_02_DBEntities();


            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formUpravljanjeKorisnicima.html");

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


        private void formUpravljanjeKorisnicima_Load(object sender, EventArgs e)
        {
            UcitajDGV();
            cmbUlogaKorisnika.SelectedIndex = 0;
        }

        private void UcitajDGV()
        {
            dgv_Korisnici.DataSource = null;
            dgv_Korisnici.DataSource = DB_Entities.Korisnik.ToList();
            PosloziDGV();
        }

        private void PosloziDGV()
        {
            dgv_Korisnici.Columns["Slika_profila"].Visible = false;
            dgv_Korisnici.Columns["ID_Uloga"].Visible = false;
            dgv_Korisnici.Columns["Gleda"].Visible = false;
            dgv_Korisnici.Columns["Uloga"].Visible = false;
            dgv_Korisnici.Columns["ID_Roditeljska_zastita"].Visible = false;
            dgv_Korisnici.Columns["RoditeljskaZastita"].Visible = false;
            dgv_Korisnici.Columns["ID_Korisnik"].Width = 30;
            dgv_Korisnici.Columns["ID_Korisnik"].HeaderText = "Rbr.";
            dgv_Korisnici.Columns["Datum_izrade_racuna"].HeaderText = "Datum izrade";
            dgv_Korisnici.Columns["Nadimak"].HeaderText = "Username";
            dgv_Korisnici.Columns["Email"].Width = 170;
        }

        private Korisnik DohvatiKorisnika()
        {
            return dgv_Korisnici.CurrentRow.DataBoundItem as Korisnik;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgv_Korisnici.SelectedRows.Count == 1)
            {
                Korisnik dohvaceniKorisnik = DohvatiKorisnika();
                this.Hide();
                formIzmjeniKorisnika formIzmjeniKorisnika = new formIzmjeniKorisnika(dohvaceniKorisnik);
                formIzmjeniKorisnika.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Označite samo jednog korisnika!");
            }
            UcitajDGV();
        }
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (dgv_Korisnici.SelectedRows.Count == 1)
            {
                Korisnik dohvaceniKorisnik = DohvatiKorisnika();
                DialogResult odluka = MessageBox.Show
                    ("Jeste li sigurni da želite izbrisati odabranog korisnika?", "Potvrda brisanja korisnika",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (odluka == DialogResult.Yes)
                {
                    DB_Entities.Korisnik.Remove(dohvaceniKorisnik);
                    DB_Entities.SaveChanges();
                    UcitajDGV();
                }
            }
            else
            {
                MessageBox.Show("Označite samo jednog korisnika!");
            }
        }

        private void pbPretraziKorisnikaFilter_Click(object sender, EventArgs e)
        {
            string odabranaUloga = cmbUlogaKorisnika.SelectedItem.ToString();
            var filtriraniKorisnici = DB_Entities.Korisnik.ToList();
            switch (odabranaUloga)
            {
                case "Svi":
                    UcitajDGV();
                    break;
                case "Administrator":
                    filtriraniKorisnici = DB_Entities.Korisnik.Where(k => k.ID_Uloga == 1).ToList();
                    break;
                case "Zaposlenici":
                    filtriraniKorisnici = DB_Entities.Korisnik.Where(k => k.ID_Uloga == 2).ToList();
                    break;
                case "Individualni korisnici":
                    filtriraniKorisnici = DB_Entities.Korisnik.Where(k => k.ID_Uloga == 3).ToList();
                    break;
                default:
                    return;
            }
            dgv_Korisnici.DataSource = null;
            dgv_Korisnici.DataSource = filtriraniKorisnici;
            PosloziDGV();
        }

        private void pbPretraziKorisnika_Click(object sender, EventArgs e)
        {
            string unos = txtPretraziKorisnika.Text.ToLower();
            var filtriraniKorisnici = DB_Entities.Korisnik.Where(k =>
            (k.Ime != null && k.Ime.ToLower().Contains(unos)) ||
            (k.Prezime != null && k.Prezime.ToLower().Contains(unos)) ||
            (k.Nadimak != null && k.Nadimak.ToLower().Contains(unos)) ||
            (k.Email != null && k.Email.ToLower().Contains(unos))).ToList();
            dgv_Korisnici.DataSource = null;
            dgv_Korisnici.DataSource = filtriraniKorisnici;
            PosloziDGV();
        }
        ~formUpravljanjeKorisnicima()
        {
            DB_Entities.Dispose();
        }
    }
}
