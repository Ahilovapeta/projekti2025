using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.IO;

namespace VideoMaster
{
    public partial class formPreporukaFilmova : Form
    {
        private PI2324_02_DBEntities DB_Entities;
        private Korisnik OdabraniKorisnik;
        private List<int> preskoceniFilmovi = new List<int>();
        private List<int> prioritetZanrovi = new List<int>();
        private int trenutniZanrIndex = 0;
        private HelpProvider helpProvider1;

        public formPreporukaFilmova(Korisnik korisnik)
        {
            InitializeComponent();
            DB_Entities = new PI2324_02_DBEntities();
            OdabraniKorisnik = korisnik;
            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formPreporukaFilmova.html");
            if (!File.Exists(documentationPath))
            {
                MessageBox.Show("Datoteka s dokumentacijom ne postoji: " + documentationPath);
            }
            else
            {
                helpProvider1.HelpNamespace = documentationPath;
                helpProvider1.SetHelpNavigator(this, HelpNavigator.TableOfContents);
            }
            UcitajPrioriteteZanrova();
            PrikaziPreporukeZaTrenutniZanr();
        }

        private void UcitajPrioriteteZanrova()
        {
            List<int> zanrovi = new List<int>();
            List<int> brojevi = new List<int>();
            foreach (var gleda in DB_Entities.Gleda)
            {
                if (gleda.ID_Korisnik == OdabraniKorisnik.ID_Korisnik && gleda.Film != null && gleda.Film.Zanr != null)
                {
                    int idZanr = gleda.Film.ID_Zanr;
                    int index = zanrovi.IndexOf(idZanr);
                    if (index >= 0)
                    {
                        brojevi[index]++;
                    }
                    else
                    {
                        zanrovi.Add(idZanr);
                        brojevi.Add(1);
                    }
                }
            }
            prioritetZanrovi = zanrovi.OrderByDescending(z => brojevi[zanrovi.IndexOf(z)]).ToList();
            trenutniZanrIndex = 0;
        }
        
        private void PrikaziPreporukeZaTrenutniZanr()
        {
            while (trenutniZanrIndex < prioritetZanrovi.Count)
            {
                int trenutniZanrId = prioritetZanrovi[trenutniZanrIndex];
                List<object> preporuceniFilmovi = new List<object>();
                foreach (var film in DB_Entities.Film)
                {
                    if (film.ID_Zanr == trenutniZanrId && !preskoceniFilmovi.Contains(film.ID_Film))
                    {
                        preporuceniFilmovi.Add(new { film.ID_Film, film.Adresa_url, film.Naziv, film.Datum_izdavanja });
                    }
                }
                if (preporuceniFilmovi.Count > 0)
                {
                    dgvPreporuke.DataSource = preporuceniFilmovi;
                    if (dgvPreporuke.Columns["ID_Film"] != null) dgvPreporuke.Columns["ID_Film"].Visible = false;
                    if (dgvPreporuke.Columns["Adresa_url"] != null) dgvPreporuke.Columns["Adresa_url"].Visible = false;
                    return;
                }
                else
                {
                    trenutniZanrIndex++;
                }
            }
            dgvPreporuke.DataSource = null;
            MessageBox.Show("Nema više preporu?enih filmova.");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pocetnaForm = new formIndividualniKorisnikPocetna(OdabraniKorisnik);
            pocetnaForm.ShowDialog();
            this.Close();
        }

        private void btnGledaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formFilm = new formFilm(Convert.ToInt32(dgvPreporuke.SelectedRows[0].Cells["ID_Film"].Value.ToString()), dgvPreporuke.SelectedRows[0].Cells["Naziv"].Value.ToString(), dgvPreporuke.SelectedRows[0].Cells["Adresa_url"].Value.ToString(), OdabraniKorisnik);
            formFilm.ShowDialog();
            this.Close();
        }

        private void btnPreskoci_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPreporuke.Rows)
            {
                if (row.DataBoundItem != null)
                {
                    int id = Convert.ToInt32(row.Cells["ID_Film"].Value);
                    if (!preskoceniFilmovi.Contains(id))
                    {
                        preskoceniFilmovi.Add(id);
                    }
                }
            }
            PrikaziPreporukeZaTrenutniZanr();
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
    }
}
