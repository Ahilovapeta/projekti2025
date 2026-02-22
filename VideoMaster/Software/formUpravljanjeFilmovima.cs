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
    public partial class formUpravljanjeFilmovima : Form
    {
        private PI2324_02_DBEntities DB_Entities;

        public formUpravljanjeFilmovima()
        {
            InitializeComponent();
            DB_Entities = new PI2324_02_DBEntities();
            LoadComboBoxes();


            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formUpravljanjeFilmovima.html");

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


        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_Filmovi.DataSource = DB_Entities.Film.ToList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Uredi_Click(object sender, EventArgs e)
        {
            if (dgv_Filmovi.SelectedRows.Count > 0)
            {
                int selectedID_Film = (int)dgv_Filmovi.SelectedRows[0].Cells["ID_Film"].Value;

                formIzmjeniFilm formIzmjeniFilm = new formIzmjeniFilm(selectedID_Film);
                formIzmjeniFilm.Show();
                this.Hide();
            }

            
        }

        private void btn_Dodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDodajFilm formDodajFilm = new formDodajFilm();
            formDodajFilm.ShowDialog();
            this.Show();
        }

        private void btn_Natrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzbrisiFilm_Click(object sender, EventArgs e)
        {

            if (dgv_Filmovi.SelectedRows.Count > 0)
            {
                int selectedID_Film = (int)dgv_Filmovi.SelectedRows[0].Cells["ID_Film"].Value;

                var filmToDelete = DB_Entities.Film.FirstOrDefault(f => f.ID_Film == selectedID_Film);
                if (filmToDelete != null)
                {
                    DB_Entities.Film.Remove(filmToDelete);
                    DB_Entities.SaveChanges();
                    MessageBox.Show("Film deleted successfully.");
                    LoadFilmovi();
                }
                else
                {
                    MessageBox.Show("Film not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a film to delete.");
            }

        }

        private void LoadFilmovi()
        {
            dgv_Filmovi.DataSource = DB_Entities.Film.ToList();
        }

        private void LoadComboBoxes()
        {
            // Load Zanr options
            var zanrList = DB_Entities.Zanr.Select(z => z.Naziv).ToList();
            cmbZanr.DataSource = zanrList;

            // Load Datum Izdavanja options
            cmbDatumIzdavanja.Items.AddRange(new string[] { "70te", "80te", "90te", "00te", "10te", "20te" });

            // Load Trajanje options
            cmbTrajanje.Items.AddRange(new string[] { "<60", "60-90", "90-120", "120>" });

            // Load Ocjena options
            cmbOcjena.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
        }

        private void pb_PretraziFilmFilter_Click(object sender, EventArgs e)
        {
            string selectedZanr = cmbZanr.SelectedItem?.ToString();
            string selectedDatumIzdavanja = cmbDatumIzdavanja.SelectedItem?.ToString();
            string selectedTrajanje = cmbTrajanje.SelectedItem?.ToString();
            string selectedOcjena = cmbOcjena.SelectedItem?.ToString();

            var query = DB_Entities.Film.AsQueryable();

            if (!string.IsNullOrEmpty(selectedZanr))
            {
                query = query.Where(f => f.Zanr.Naziv == selectedZanr);
            }

            if (!string.IsNullOrEmpty(selectedDatumIzdavanja))
            {
                int startYear = 0, endYear = 0;
                switch (selectedDatumIzdavanja)
                {
                    case "70te":
                        startYear = 1970;
                        endYear = 1979;
                        break;
                    case "80te":
                        startYear = 1980;
                        endYear = 1989;
                        break;
                    case "90te":
                        startYear = 1990;
                        endYear = 1999;
                        break;
                    case "00te":
                        startYear = 2000;
                        endYear = 2009;
                        break;
                    case "10te":
                        startYear = 2010;
                        endYear = 2019;
                        break;
                    case "20te":
                        startYear = 2020;
                        endYear = 2029;
                        break;
                }
                query = query.Where(f => f.Datum_izdavanja.Year >= startYear && f.Datum_izdavanja.Year <= endYear);
            }

            if (!string.IsNullOrEmpty(selectedTrajanje))
            {
                switch (selectedTrajanje)
                {
                    case "<60":
                        query = query.Where(f => f.Trajanje < 60);
                        break;
                    case "60-90":
                        query = query.Where(f => f.Trajanje >= 60 && f.Trajanje <= 90);
                        break;
                    case "90-120":
                        query = query.Where(f => f.Trajanje > 90 && f.Trajanje <= 120);
                        break;
                    case "120>":
                        query = query.Where(f => f.Trajanje > 120);
                        break;
                }
            }

            if (!string.IsNullOrEmpty(selectedOcjena))
            {
                int ocjena = int.Parse(selectedOcjena);
                query = query.Where(f => Math.Floor(f.Gleda.Average(g => (double?)g.Ocjena) ?? 0) == ocjena);
            }

            dgv_Filmovi.DataSource = query.ToList();
        }

        private void pb_PretraziFilm_Click(object sender, EventArgs e)
        {
            string searchText = txtPretraziFilm.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                var query = DB_Entities.Film.AsQueryable();

                query = query.Where(f => f.Naziv.Contains(searchText) ||
                                         f.Redatelj.Ime.Contains(searchText) ||
                                         f.Redatelj.Prezime.Contains(searchText) ||
                                         f.Zanr.Naziv.Contains(searchText));

                dgv_Filmovi.DataSource = query.ToList();
            }
            else
            {
                LoadFilmovi();
            }
        }
    }
}

