using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VideoMaster
{
    public partial class formFilm : Form
    {
        private PI2324_02_DBEntities DB_Entities;
        private string selectedFilmURL;
        private PictureBox[] zvijezdice;
        private int brojZvijezdica = 0;
        private int selectedFilmId;
        private Korisnik OdabraniKorisnik;

        public formFilm(int selectedFilmId, string selectedFilmName, string selectedFilmURL, Korisnik odabraniKorisnik)
        {
            InitializeComponent();
            lblNazivFilma.Text = selectedFilmName;
            this.selectedFilmId = selectedFilmId;
            this.selectedFilmURL = selectedFilmURL;
            DB_Entities = new PI2324_02_DBEntities();
            textBox1.Text = selectedFilmURL;
            UcitajZvjezdice();
            OdabraniKorisnik = odabraniKorisnik;


            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formFilm.html");

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

        private void formFilm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtLink = selectedFilmURL;
            string videoId = txtLink.Split('=')[1];

            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            this.webBrowser1.DocumentText = string.Format(html, videoId);
        }

        private void UcitajZvjezdice()
        {
            zvijezdice = new PictureBox[] { pbZvjezdica1, pbZvjezdica2, pbZvjezdica3, pbZvjezdica4, pbZvjezdica5 };

            for (int i = 0; i < zvijezdice.Length; i++)
            {
                zvijezdice[i].Click += Zvijezdice_Click;
                zvijezdice[i].Tag = i + 1;
            }

            UpdateZvijezdice();
        }

        private void Zvijezdice_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            brojZvijezdica = (int)clickedStar.Tag;
            UpdateZvijezdice();
        }

        private void UpdateZvijezdice()
        {
            for (int i = 0; i < zvijezdice.Length; i++)
            {
                if (i < brojZvijezdica)
                {
                    zvijezdice[i].Image = Properties.Resources.popunjena_zvijezdica;
                }
                else
                {
                    zvijezdice[i].Image = Properties.Resources.Prazna_zvijezdica;
                }
            }
        }

        private void btnOcjena_Click(object sender, EventArgs e)
        {

                    var gleda = new Gleda
                {
                    ID_Film = selectedFilmId,
                    ID_Korisnik = OdabraniKorisnik.ID_Korisnik,
                    Ocjena = brojZvijezdica,
                    Datum_gledanja = DateTime.Now,
                    Komentar = rtxKomentar.Text
                };

                DB_Entities.Gleda.Add(gleda);
                DB_Entities.SaveChanges();
                MessageBox.Show("Ocjena je uspješno spremljena!", "Uspjeh");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
            formFilmovi formFilmovi = new formFilmovi(OdabraniKorisnik);
            formFilmovi.Show();
        }
    }
}
