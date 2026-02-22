namespace VideoMaster
{
    partial class formDodajFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDodajFilm));
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.lblDobnoOgranicenje = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblRedatelj = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.cmbDobnoOgranicenje = new System.Windows.Forms.ComboBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtRedatelj = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.sfdThumbnail = new System.Windows.Forms.SaveFileDialog();
            this.sfdUploadFilm = new System.Windows.Forms.SaveFileDialog();
            this.lblUploadajFilm = new System.Windows.Forms.Label();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.opfDodajFilm = new System.Windows.Forms.OpenFileDialog();
            this.dtpGodina = new System.Windows.Forms.DateTimePicker();
            this.opfDodajThumbnail = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadThumbnail = new System.Windows.Forms.Button();
            this.txtAdresa_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBanner
            // 
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(-2, -1);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(209, 452);
            this.pbBanner.TabIndex = 1;
            this.pbBanner.TabStop = false;
            // 
            // lblDobnoOgranicenje
            // 
            this.lblDobnoOgranicenje.AutoSize = true;
            this.lblDobnoOgranicenje.Location = new System.Drawing.Point(243, 316);
            this.lblDobnoOgranicenje.Name = "lblDobnoOgranicenje";
            this.lblDobnoOgranicenje.Size = new System.Drawing.Size(100, 13);
            this.lblDobnoOgranicenje.TabIndex = 2;
            this.lblDobnoOgranicenje.Text = "Dobno ograničenje:";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(243, 280);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(48, 13);
            this.lblTrajanje.TabIndex = 3;
            this.lblTrajanje.Text = "Trajanje:";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(243, 236);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(44, 13);
            this.lblGodina.TabIndex = 4;
            this.lblGodina.Text = "Godina:";
            // 
            // lblRedatelj
            // 
            this.lblRedatelj.AutoSize = true;
            this.lblRedatelj.Location = new System.Drawing.Point(243, 190);
            this.lblRedatelj.Name = "lblRedatelj";
            this.lblRedatelj.Size = new System.Drawing.Size(49, 13);
            this.lblRedatelj.TabIndex = 5;
            this.lblRedatelj.Text = "Redatelj:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(243, 140);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Location = new System.Drawing.Point(243, 20);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(59, 13);
            this.lblThumbnail.TabIndex = 7;
            this.lblThumbnail.Text = "Thumbnail:";
            // 
            // cmbDobnoOgranicenje
            // 
            this.cmbDobnoOgranicenje.FormattingEnabled = true;
            this.cmbDobnoOgranicenje.Location = new System.Drawing.Point(409, 316);
            this.cmbDobnoOgranicenje.Name = "cmbDobnoOgranicenje";
            this.cmbDobnoOgranicenje.Size = new System.Drawing.Size(242, 21);
            this.cmbDobnoOgranicenje.TabIndex = 8;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(409, 280);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(242, 20);
            this.txtTrajanje.TabIndex = 9;
            // 
            // txtRedatelj
            // 
            this.txtRedatelj.Location = new System.Drawing.Point(409, 190);
            this.txtRedatelj.Name = "txtRedatelj";
            this.txtRedatelj.Size = new System.Drawing.Size(242, 20);
            this.txtRedatelj.TabIndex = 11;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(409, 140);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(242, 20);
            this.txtNaziv.TabIndex = 12;
            // 
            // lblUploadajFilm
            // 
            this.lblUploadajFilm.AutoSize = true;
            this.lblUploadajFilm.Location = new System.Drawing.Point(243, 365);
            this.lblUploadajFilm.Name = "lblUploadajFilm";
            this.lblUploadajFilm.Size = new System.Drawing.Size(70, 13);
            this.lblUploadajFilm.TabIndex = 13;
            this.lblUploadajFilm.Text = "Uploadaj film:";
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.Location = new System.Drawing.Point(409, 20);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(242, 114);
            this.pbThumbnail.TabIndex = 14;
            this.pbThumbnail.TabStop = false;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(485, 415);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 15;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(576, 415);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // opfDodajFilm
            // 
            this.opfDodajFilm.FileName = "openFileDialog1";
            // 
            // dtpGodina
            // 
            this.dtpGodina.Location = new System.Drawing.Point(409, 236);
            this.dtpGodina.Name = "dtpGodina";
            this.dtpGodina.Size = new System.Drawing.Size(242, 20);
            this.dtpGodina.TabIndex = 19;
            // 
            // opfDodajThumbnail
            // 
            this.opfDodajThumbnail.FileName = "openFileDialog1";
            // 
            // btnUploadThumbnail
            // 
            this.btnUploadThumbnail.Location = new System.Drawing.Point(246, 56);
            this.btnUploadThumbnail.Name = "btnUploadThumbnail";
            this.btnUploadThumbnail.Size = new System.Drawing.Size(56, 23);
            this.btnUploadThumbnail.TabIndex = 20;
            this.btnUploadThumbnail.Text = "Dodaj thumbnail";
            this.btnUploadThumbnail.UseVisualStyleBackColor = true;
            this.btnUploadThumbnail.Click += new System.EventHandler(this.btnUploadThumbnail_Click);
            // 
            // txtAdresa_url
            // 
            this.txtAdresa_url.Location = new System.Drawing.Point(409, 362);
            this.txtAdresa_url.Name = "txtAdresa_url";
            this.txtAdresa_url.Size = new System.Drawing.Size(242, 20);
            this.txtAdresa_url.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Zanr:";
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(409, 165);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(242, 20);
            this.txtZanr.TabIndex = 23;
            // 
            // formDodajFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.txtZanr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdresa_url);
            this.Controls.Add(this.btnUploadThumbnail);
            this.Controls.Add(this.dtpGodina);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.pbThumbnail);
            this.Controls.Add(this.lblUploadajFilm);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtRedatelj);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.cmbDobnoOgranicenje);
            this.Controls.Add(this.lblThumbnail);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblRedatelj);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.lblDobnoOgranicenje);
            this.Controls.Add(this.pbBanner);
            this.Name = "formDodajFilm";
            this.Text = "VideoMaster - Dodaj film";
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label lblDobnoOgranicenje;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblRedatelj;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.ComboBox cmbDobnoOgranicenje;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtRedatelj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.SaveFileDialog sfdThumbnail;
        private System.Windows.Forms.SaveFileDialog sfdUploadFilm;
        private System.Windows.Forms.Label lblUploadajFilm;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.OpenFileDialog opfDodajFilm;
        private System.Windows.Forms.DateTimePicker dtpGodina;
        private System.Windows.Forms.OpenFileDialog opfDodajThumbnail;
        private System.Windows.Forms.Button btnUploadThumbnail;
        private System.Windows.Forms.TextBox txtAdresa_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}