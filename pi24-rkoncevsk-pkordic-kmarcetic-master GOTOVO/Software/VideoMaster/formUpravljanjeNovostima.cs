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
    public partial class formUpravljanjeNovostima : Form
    {
        private PI2324_02_DBEntities DB_Entities;
        public formUpravljanjeNovostima()
        {
            InitializeComponent();
            DB_Entities = new PI2324_02_DBEntities();

            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formUpravljanjeNovostima.html");

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


        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formUpravljanjeNovostima_Load(object sender, EventArgs e)
        {
            dgv_Novosti.DataSource = null;
            dgv_Novosti.DataSource = DB_Entities.Novost.ToList();
            PosloziDGV();
        }
        private void PosloziDGV()
        {
            dgv_Novosti.Columns["Thumbnail"].Visible = false;
            dgv_Novosti.Columns["ID_Film"].Visible = false;
            dgv_Novosti.Columns["Film"].Visible = false;
            dgv_Novosti.Columns["Opis"].Visible = false;
            dgv_Novosti.Columns["ID_Novost"].Width = 30;
            dgv_Novosti.Columns["Naslov"].Width = 370;
            dgv_Novosti.Columns["Datum_novosti"].Width = 80;
            dgv_Novosti.Columns["ID_Novost"].HeaderText = "Rbr.";
            dgv_Novosti.Columns["Datum_novosti"].HeaderText = "Datum";
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgv_Novosti.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_Novosti.CurrentRow;
                Image thumbnail = null;
                byte[] slika = (byte[])selectedRow.Cells["Thumbnail"].Value;
                Novost odabranaNovost = dgv_Novosti.CurrentRow.DataBoundItem as Novost;
                if (slika != null && slika.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(slika))
                    {
                        thumbnail = Image.FromStream(ms);
                    }
                }
                this.Hide();
                formIzmjeniNovost formIzmjeniNovost = new formIzmjeniNovost(thumbnail, odabranaNovost);
                formIzmjeniNovost.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Označite samo jednu novost!");
            }
        }
        private void pbPretraziNovosti_Click(object sender, EventArgs e)
        {
            string unos = txtPretraziNovosti.Text.ToLower();
            var filtriraneNovosti = DB_Entities.Novost.Where(n =>
            (n.Naslov != null && n.Naslov.ToLower().Contains(unos))).ToList();
            dgv_Novosti.DataSource = null;
            dgv_Novosti.DataSource = filtriraneNovosti;
            PosloziDGV();
        }

        ~formUpravljanjeNovostima()
        {
            DB_Entities.Dispose();
        }

        
    }
}
