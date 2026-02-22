using System;
using System.IO;
using System.Windows.Forms;

namespace VideoMaster
{
    public partial class formPrva : Form
    {


        public formPrva()
        {
            InitializeComponent();

            
            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formPrva.html");

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

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPrijava form = new formPrijava();
            form.ShowDialog();
            this.Show();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegistracija form = new formRegistracija();
            form.ShowDialog();
            this.Show();
        }
    }
}
