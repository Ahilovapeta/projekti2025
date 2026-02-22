using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VideoMaster
{
    public partial class formFilmovi : Form
    {
        private PI2324_02_DBEntities DB_Entities;
        private Korisnik OdabraniKorisnik;
        private List<FilmInfo> filmovi1;

        public formFilmovi(Korisnik odabraniKorisnik)
        {
            InitializeComponent();
            DB_Entities = new PI2324_02_DBEntities();
            this.OdabraniKorisnik = odabraniKorisnik;


            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formFilmovi.html");

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

        private void formFilmovi_Load(object sender, EventArgs e)
        {
            UcitajDGV();
            UcitajComboBoxes();
            pb_PretraziFilm.Click += pb_PretraziFilm_Click;
            pb_PretraziFilmFilter.Click += pb_PretraziFilmFilter_Click;
        }

        private void pb_PretraziFilmFilter_Click(object sender, EventArgs e)
        {
            FilterFilms();
        }

        private void pb_PretraziFilm_Click(object sender, EventArgs e)
        {
            FilterPretraziFilm();
        }

        private void UcitajComboBoxes()
        {
            using (var context = new PI2324_02_DBEntities())
            {
                var zanrovi = context.Zanr
                                     .Select(z => new { z.ID_Zanr, z.Naziv })
                                     .ToList();

                cmbZanr.DataSource = zanrovi;
                cmbZanr.DisplayMember = "Naziv";
                cmbZanr.ValueMember = "ID_Zanr";
            }

            using (var context = new PI2324_02_DBEntities())
            {
                var ocjene = context.Gleda
                                    .Select(g => g.Ocjena)
                                    .Distinct()
                                    .ToList();

                cmbOcjena.DataSource = ocjene.Select(o => new { Ocjena = o }).ToList();
                cmbOcjena.DisplayMember = "Ocjena";
                cmbOcjena.ValueMember = "Ocjena";
            }

            var godista = new List<string> { "70te", "80te", "90te", "00te", "2010te", "2020te" };
            cmbDatumIzdavanja.DataSource = godista;

            var trajanja = new List<string> { "<60", "60-90", "90-120", "120>" };
            cmbTrajanje.DataSource = trajanja;
        }

        private void FilterFilms()
        {
            try
            {
                if (cmbZanr.SelectedValue != null && cmbOcjena.SelectedValue != null &&
                    cmbDatumIzdavanja.SelectedItem != null && cmbTrajanje.SelectedItem != null)
                {
                    string selectedZanr = cmbZanr.Text;
                    double selectedOcjena = double.Parse(cmbOcjena.SelectedValue.ToString());
                    string selectedDatum_izdavanja = cmbDatumIzdavanja.SelectedItem.ToString();
                    string selectedTrajanje = cmbTrajanje.SelectedItem.ToString();

                    var filmsQuery = filmovi1.AsQueryable();

                    filmsQuery = filmsQuery.Where(f =>
                        f.Zanr == selectedZanr &&
                        f.ProsjecnaOcjena == selectedOcjena);

                    switch (selectedDatum_izdavanja)
                    {
                        case "70te":
                            filmsQuery = filmsQuery.Where(f => f.Datum_izdavanja.Year >= 1970 && f.Datum_izdavanja.Year < 1980);
                            break;
                        case "80te":
                            filmsQuery = filmsQuery.Where(f => f.Datum_izdavanja.Year >= 1980 && f.Datum_izdavanja.Year < 1990);
                            break;
                        case "90te":
                            filmsQuery = filmsQuery.Where(f => f.Datum_izdavanja.Year >= 1990 && f.Datum_izdavanja.Year < 2000);
                            break;
                        case "00te":
                            filmsQuery = filmsQuery.Where(f => f.Datum_izdavanja.Year >= 2000 && f.Datum_izdavanja.Year < 2010);
                            break;
                        case "2010te":
                            filmsQuery = filmsQuery.Where(f => f.Datum_izdavanja.Year >= 2010 && f.Datum_izdavanja.Year < 2020);
                            break;
                        case "2020te":
                            filmsQuery = filmsQuery.Where(f => f.Datum_izdavanja.Year >= 2020);
                            break;
                    }

                    switch (selectedTrajanje)
                    {
                        case "<60":
                            filmsQuery = filmsQuery.Where(f => f.Trajanje < 60);
                            break;
                        case "60-90":
                            filmsQuery = filmsQuery.Where(f => f.Trajanje >= 60 && f.Trajanje <= 90);
                            break;
                        case "90-120":
                            filmsQuery = filmsQuery.Where(f => f.Trajanje > 90 && f.Trajanje <= 120);
                            break;
                        case "120>":
                            filmsQuery = filmsQuery.Where(f => f.Trajanje > 120);
                            break;
                    }

                    dgv_Filmovi.DataSource = filmsQuery.ToList();
                }
                else
                {
                    dgv_Filmovi.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering films: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UcitajDGV()
        {
            var filmovi = DB_Entities.Film
                .GroupJoin(DB_Entities.Gleda,
                    film => film.ID_Film, gleda => gleda.ID_Film, (film, gleda) => new
                    {
                        film,
                        ProsjecnaOcjena = gleda.Average(g => (double?)g.Ocjena) ?? 0.0
                    })
                .Select(f => new FilmInfo
                {
                    ID_Film = f.film.ID_Film,
                    Naziv = f.film.Naziv,
                    Datum_izdavanja = f.film.Datum_izdavanja,
                    Trajanje = f.film.Trajanje,
                    Redatelj = f.film.Redatelj.Ime + " " + f.film.Redatelj.Prezime,
                    DobnoOgranicenje = f.film.DobnoOgranicenje.Naziv,
                    Zanr = f.film.Zanr.Naziv,
                    ProsjecnaOcjena = Math.Round(f.ProsjecnaOcjena, 2),
                    Adresa_url = f.film.Adresa_url,
                }).ToList();

            filmovi1 = new List<FilmInfo>();
            foreach (var film in filmovi)
            {
                string dobnoOgranicenje = film.DobnoOgranicenje;
                int razinaZastite = (int)OdabraniKorisnik.ID_Roditeljska_zastita;
                switch (razinaZastite)
                {
                    case 3:
                        if (!(dobnoOgranicenje == "PG" || dobnoOgranicenje == "PG-13" || dobnoOgranicenje == "R" || dobnoOgranicenje == "NC-17"))
                            filmovi1.Add(film);
                        break;
                    case 4:
                        if (!(dobnoOgranicenje == "PG-13" || dobnoOgranicenje == "R" || dobnoOgranicenje == "NC-17"))
                            filmovi1.Add(film);
                        break;
                    case 5:
                        if (!(dobnoOgranicenje == "R" || dobnoOgranicenje == "NC-17"))
                            filmovi1.Add(film);
                        break;
                    case 6:
                        if (!(dobnoOgranicenje == "NC-17"))
                            filmovi1.Add(film);
                        break;
                    default:
                        filmovi1.Add(film);
                        break;
                }
            }

            dgv_Filmovi.DataSource = filmovi1;
            AdjustDataGridViewColumns();
        }

        private void AdjustDataGridViewColumns()
        {
            dgv_Filmovi.Columns["ID_Film"].Width = 30;
            dgv_Filmovi.Columns["Naziv"].Width = 225;
            dgv_Filmovi.Columns["Trajanje"].Width = 55;
            dgv_Filmovi.Columns["Datum_izdavanja"].Width = 75;
            dgv_Filmovi.Columns["DobnoOgranicenje"].Width = 75;
            dgv_Filmovi.Columns["Zanr"].Width = 120;
            dgv_Filmovi.Columns["ProsjecnaOcjena"].Width = 55;
            dgv_Filmovi.Columns["ID_Film"].HeaderText = "Rbr.";
            dgv_Filmovi.Columns["Datum_izdavanja"].HeaderText = "Datum izdavanja";
            dgv_Filmovi.Columns["DobnoOgranicenje"].HeaderText = "Dobno ograničenje";
            dgv_Filmovi.Columns["Zanr"].HeaderText = "Žanr";
            dgv_Filmovi.Columns["ProsjecnaOcjena"].HeaderText = "Ocjena";
        }

        private void FilterPretraziFilm()
        {
            string searchText = tbPretraziFilm.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filmsQuery = filmovi1
                    .Where(f => f.Naziv.Contains(searchText))
                    .ToList();

                dgv_Filmovi.DataSource = filmsQuery;
            }
            else
            {
                dgv_Filmovi.DataSource = filmovi1;
            }
        }

        private void btnGledaj_Click(object sender, EventArgs e)
        {
            if (dgv_Filmovi.SelectedRows.Count > 0)
            {
                int selectedFilmId = (int)dgv_Filmovi.SelectedRows[0].Cells["ID_Film"].Value;
                string selectedFilmName = dgv_Filmovi.SelectedRows[0].Cells["Naziv"].Value.ToString();
                string selectedFilmURL = dgv_Filmovi.SelectedRows[0].Cells["Adresa_url"].Value.ToString();

                formFilm formFilm = new formFilm(selectedFilmId, selectedFilmName, selectedFilmURL, OdabraniKorisnik);
                formFilm.Show();
            }
        }
    }
}
