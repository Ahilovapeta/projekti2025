using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VideoMaster
{
    public partial class formIzmjeniNovost : Form
    {
        private PI2324_02_DBEntities DB_Entities;
        private Novost OdabranaNovost;
        private byte[] slikaBytes;
        private string Naslov;
        private string Opis;
        private Image Thumbnail;
        public formIzmjeniNovost(Image thumbnail, Novost odabranaNovost)
        {
            InitializeComponent();
            DB_Entities = new PI2324_02_DBEntities();
            this.OdabranaNovost = odabranaNovost;
            this.Naslov = odabranaNovost.Naslov;
            this.Opis = odabranaNovost.Opis;
            this.Thumbnail = thumbnail;


            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formIzmjeniNovosti.html");

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



        private void formIzmjeniNovost_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = Naslov;
            rtxOpis.Text = Opis;
            pbThumbnail.Image = Thumbnail;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslov.Text;
            string opis = rtxOpis.Text;
            OdabranaNovost.Naslov = naslov;
            OdabranaNovost.Opis = opis;
            if (slikaBytes != null)
            {
                OdabranaNovost.Thumbnail = slikaBytes;
            }
            var query = DB_Entities.Novost.FirstOrDefault(n => n.ID_Novost == OdabranaNovost.ID_Novost);
            if (query != null)
            {
                query.Naslov = naslov;
                query.Opis = opis;
                if (slikaBytes != null)
                {
                    query.Thumbnail = slikaBytes;
                }
                DB_Entities.SaveChanges();
                Close();
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
        ~formIzmjeniNovost()
        {
            DB_Entities.Dispose();
        }
    }
}
