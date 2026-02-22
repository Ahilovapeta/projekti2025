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
    public partial class formRoditeljskaZastita : Form
    {
        private PI2324_02_DBEntities DB_Entities;
        private Korisnik OdabraniKorisnik;
        private bool onemoguci = false;

        public formRoditeljskaZastita(Korisnik odabraniKorisnik)
        {
            InitializeComponent();
            this.OdabraniKorisnik = odabraniKorisnik;
            DB_Entities = new PI2324_02_DBEntities();


            helpProvider1 = new HelpProvider();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string documentationPath = Path.Combine(projectDirectory, "F1", "formRoditeljskaZastita.html");

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

        private void formRoditeljskaZastita_Load(object sender, EventArgs e)
        {
            UcitajDefault();
            PostojiPodatak();
        }

        private void UcitajDefault()
        {
            cbRoditeljskaZastita.Enabled = true;
            cbRoditeljskaZastita.Checked = false;

            ResetirajCheckBoxeve();
        }

        private void ResetirajCheckBoxeve()
        {
            onemoguci = true;

            cbNC17.Enabled = false;
            cbNC17.Checked = false;

            cbR.Enabled = false;
            cbR.Checked = false;

            cbPG13.Enabled = false;
            cbPG13.Checked = false;

            cbPG.Enabled = false;
            cbPG.Checked = false;

            onemoguci = false;
        }

        private void cbRoditeljskaZastita_CheckedChanged(object sender, EventArgs e)
        {
            if (onemoguci)
            {
                return;
            }
            if (cbRoditeljskaZastita.Checked)
            {
                cbNC17.Enabled = true;
                cbR.Enabled = true;
                cbPG13.Enabled = true;
                cbPG.Enabled = true;

                cbNC17.Checked = false;
                cbR.Checked = false;
                cbPG13.Checked = false;
                cbPG.Checked = false;
            }
            else
            {
                ResetirajCheckBoxeve();
            }
        }

        private void cbPG_CheckedChanged(object sender, EventArgs e)
        {
            if (onemoguci)
            {
                return;
            }
            onemoguci = true;
            if (cbPG.Checked)
            {
                cbNC17.Checked = true;
                cbR.Checked = true;
                cbPG13.Checked = true;

                cbNC17.Enabled = false;
                cbR.Enabled = false;
                cbPG13.Enabled = false;
            }
            else
            {
                ResetirajCheckBoxeve();
                Enable();
            }
            onemoguci = false;
        }

        private void cbPG13_CheckedChanged(object sender, EventArgs e)
        {
            if (onemoguci)
            {
                return;
            }
            onemoguci = true;
            if (cbPG13.Checked)
            {
                cbNC17.Checked = true;
                cbR.Checked = true;

                cbNC17.Enabled = false;
                cbR.Enabled = false;
            }
            else
            {
                cbNC17.Checked = false;
                cbR.Checked = false;
                cbNC17.Enabled = true;
                cbR.Enabled = true;
            }
            onemoguci = false;
        }

        private void cbR_CheckedChanged(object sender, EventArgs e)
        {
            if (onemoguci)
            {
                return;
            }
            onemoguci = true;
            if (cbR.Checked)
            {
                cbNC17.Checked = true;
                cbNC17.Enabled = false;
            }
            else
            {
                cbNC17.Checked = false;
                cbNC17.Enabled = true;
            }
            onemoguci = false;
        }

        private void cbNC17_CheckedChanged(object sender, EventArgs e)
        {
            if (onemoguci)
            {
                return;
            }
            onemoguci = true;
            if (cbNC17.Checked)
            {
                cbNC17.Checked = true;
                cbR.Checked = false;
                cbPG13.Checked = false;
                cbPG.Checked = false;
            }
            onemoguci = false;
        }

        private void Enable()
        {
            if (cbRoditeljskaZastita.Checked)
            {
                cbNC17.Enabled = true;
                cbR.Enabled = true;
                cbPG13.Enabled = true;
                cbPG.Enabled = true;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var query = DB_Entities.Korisnik.FirstOrDefault(n => n.ID_Korisnik == OdabraniKorisnik.ID_Korisnik);
            if (query != null)
            {
                if (cbRoditeljskaZastita.Checked)
                {
                    if (cbPG.Checked)
                    {
                        OdabraniKorisnik.ID_Roditeljska_zastita = 3;
                        query.ID_Roditeljska_zastita = 3;
                        DB_Entities.SaveChanges();
                        this.Close();
                    }
                    else if (cbPG13.Checked)
                    {
                        OdabraniKorisnik.ID_Roditeljska_zastita = 4;
                        query.ID_Roditeljska_zastita = 4;
                        DB_Entities.SaveChanges();
                        this.Close();
                    }
                    else if (cbR.Checked)
                    {
                        OdabraniKorisnik.ID_Roditeljska_zastita = 5;
                        query.ID_Roditeljska_zastita = 5;
                        DB_Entities.SaveChanges();
                        this.Close();
                    }
                    else if (cbNC17.Checked)
                    {
                        OdabraniKorisnik.ID_Roditeljska_zastita = 6;
                        query.ID_Roditeljska_zastita = 6;
                        DB_Entities.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Odaberite razinu zaštite!");
                    }
                }
                else
                {
                    OdabraniKorisnik.ID_Roditeljska_zastita = 1;
                    query.ID_Roditeljska_zastita = 1;
                    DB_Entities.SaveChanges();
                    this.Close();

                }
                
            }
            
        }

        private void PostojiPodatak()
        {
            var query1 = DB_Entities.Korisnik.FirstOrDefault(n => n.ID_Korisnik == OdabraniKorisnik.ID_Korisnik);

            if (query1 != null)
            {
                if (query1.ID_Roditeljska_zastita.HasValue)
                {
                    switch (query1.ID_Roditeljska_zastita.Value)
                    {
                        case 1:
                            cbRoditeljskaZastita.Checked = false;
                            break;
                        case 3:
                            cbRoditeljskaZastita.Checked = true;
                            cbPG.Checked = true;
                            break;
                        case 4:
                            cbRoditeljskaZastita.Checked = true;
                            cbPG13.Checked = true;
                            break;
                        case 5:
                            cbRoditeljskaZastita.Checked = true;
                            cbR.Checked = true;
                            break;
                        case 6: 
                            cbRoditeljskaZastita.Checked = true;
                            cbNC17.Checked = true;
                            break;
                        default:
                            return;
                    }
                }
                else
                {
                    cbRoditeljskaZastita.Checked = false;
                    ResetirajCheckBoxeve();
                }
            }
        }
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ~formRoditeljskaZastita()
        {
            DB_Entities.Dispose();
        }

       
    }
}