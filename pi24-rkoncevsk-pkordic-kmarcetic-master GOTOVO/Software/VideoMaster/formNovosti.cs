using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMaster
{
    public partial class formNovosti : Form
    {
        private PI2324_02_DBEntities DB_Entities;
        public formNovosti()
        {
            InitializeComponent();
            DB_Entities = new PI2324_02_DBEntities();
            this.Shown += new System.EventHandler(this.formNovosti_Shown);

            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formNovosti.html");

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
        private void formNovosti_Shown(object sender, EventArgs e)
        {
            this.AutoScrollPosition = new Point(0, 0);
        }

        private void formNovosti_Load(object sender, EventArgs e)
        {
            IzvrsiUnos();
        }
        private void IzvrsiUnos()
        {
            lblNovost1.MaximumSize = new Size(214, 50); 
            lblNovost2.MaximumSize = new Size(214, 50);
            lblNovost3.MaximumSize = new Size(214, 50);
            lblNovost4.MaximumSize = new Size(214, 50);
            lblNovost5.MaximumSize = new Size(214, 50);
            lblNovost6.MaximumSize = new Size(214, 50);
            lblNovostA.MaximumSize = new Size(214, 64);
            lblNovostB.MaximumSize = new Size(214, 64);
            lblNovostC.MaximumSize = new Size(214, 64);
            lblNovostD.MaximumSize = new Size(214, 64);
            lblNovostE.MaximumSize = new Size(214, 64);
            lblNovostF.MaximumSize = new Size(214, 64);

            for (int i = 1; i <= 6; i++)
            {
                var novost = DB_Entities.Novost.FirstOrDefault(k => k.ID_Novost == i);

                if (novost != null)
                {
                    Image thumbnailImage = PretvorbaUSliku(novost.Thumbnail);
                    switch (i)
                    {
                        case 1:
                            pbNovost1.Image = thumbnailImage;
                            lblNovost1.Text = novost.Naslov;
                            lblNovostA.Text = novost.Opis;
                            break;
                        case 2:
                            pbNovost2.Image = thumbnailImage;
                            lblNovost2.Text = novost.Naslov;
                            lblNovostB.Text = novost.Opis;
                            break;
                        case 3:
                            pbNovost3.Image = thumbnailImage;
                            lblNovost3.Text = novost.Naslov;
                            lblNovostC.Text = novost.Opis;
                            break;
                        case 4:
                            pbNovost4.Image = thumbnailImage;
                            lblNovost4.Text = novost.Naslov;
                            lblNovostD.Text = novost.Opis;
                            break;
                        case 5:
                            pbNovost5.Image = thumbnailImage;
                            lblNovost5.Text = novost.Naslov;
                            lblNovostE.Text = novost.Opis;
                            break;
                        case 6:
                            pbNovost6.Image = thumbnailImage;
                            lblNovost6.Text = novost.Naslov;
                            lblNovostF.Text = novost.Opis;
                            break;
                        default:
                            return;
                    }
                }
            }
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
        ~formNovosti()
        {
            DB_Entities.Dispose();
        }
    }
}
