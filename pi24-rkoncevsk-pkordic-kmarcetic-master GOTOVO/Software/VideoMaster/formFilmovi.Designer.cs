namespace VideoMaster
{
    partial class formFilmovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFilmovi));
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.pb_PretraziFilmFilter = new System.Windows.Forms.PictureBox();
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.cmbTrajanje = new System.Windows.Forms.ComboBox();
            this.cmbDatumIzdavanja = new System.Windows.Forms.ComboBox();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblDatumIzdavanja = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.dgv_Filmovi = new System.Windows.Forms.DataGridView();
            this.pb_PretraziFilm = new System.Windows.Forms.PictureBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblPretraziFilm = new System.Windows.Forms.Label();
            this.tbPretraziFilm = new System.Windows.Forms.TextBox();
            this.btnGledaj = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PretraziFilmFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Filmovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PretraziFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBanner
            // 
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(0, 0);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(209, 452);
            this.pbBanner.TabIndex = 1;
            this.pbBanner.TabStop = false;
            // 
            // pb_PretraziFilmFilter
            // 
            this.pb_PretraziFilmFilter.BackColor = System.Drawing.Color.Transparent;
            this.pb_PretraziFilmFilter.Image = ((System.Drawing.Image)(resources.GetObject("pb_PretraziFilmFilter.Image")));
            this.pb_PretraziFilmFilter.Location = new System.Drawing.Point(748, 56);
            this.pb_PretraziFilmFilter.Name = "pb_PretraziFilmFilter";
            this.pb_PretraziFilmFilter.Size = new System.Drawing.Size(34, 32);
            this.pb_PretraziFilmFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PretraziFilmFilter.TabIndex = 30;
            this.pb_PretraziFilmFilter.TabStop = false;
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Location = new System.Drawing.Point(635, 67);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(107, 21);
            this.cmbOcjena.TabIndex = 29;
            // 
            // cmbTrajanje
            // 
            this.cmbTrajanje.FormattingEnabled = true;
            this.cmbTrajanje.Location = new System.Drawing.Point(502, 67);
            this.cmbTrajanje.Name = "cmbTrajanje";
            this.cmbTrajanje.Size = new System.Drawing.Size(107, 21);
            this.cmbTrajanje.TabIndex = 28;
            // 
            // cmbDatumIzdavanja
            // 
            this.cmbDatumIzdavanja.FormattingEnabled = true;
            this.cmbDatumIzdavanja.Location = new System.Drawing.Point(369, 67);
            this.cmbDatumIzdavanja.Name = "cmbDatumIzdavanja";
            this.cmbDatumIzdavanja.Size = new System.Drawing.Size(107, 21);
            this.cmbDatumIzdavanja.TabIndex = 27;
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(233, 67);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(107, 21);
            this.cmbZanr.TabIndex = 26;
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(664, 51);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(41, 13);
            this.lblOcjena.TabIndex = 25;
            this.lblOcjena.Text = "Ocjena";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(528, 51);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(45, 13);
            this.lblTrajanje.TabIndex = 24;
            this.lblTrajanje.Text = "Trajanje";
            // 
            // lblDatumIzdavanja
            // 
            this.lblDatumIzdavanja.AutoSize = true;
            this.lblDatumIzdavanja.Location = new System.Drawing.Point(380, 51);
            this.lblDatumIzdavanja.Name = "lblDatumIzdavanja";
            this.lblDatumIzdavanja.Size = new System.Drawing.Size(86, 13);
            this.lblDatumIzdavanja.TabIndex = 23;
            this.lblDatumIzdavanja.Text = "Datum izdavanja";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(264, 51);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(29, 13);
            this.lblZanr.TabIndex = 22;
            this.lblZanr.Text = "Žanr";
            // 
            // dgv_Filmovi
            // 
            this.dgv_Filmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Filmovi.Location = new System.Drawing.Point(233, 104);
            this.dgv_Filmovi.Name = "dgv_Filmovi";
            this.dgv_Filmovi.Size = new System.Drawing.Size(801, 274);
            this.dgv_Filmovi.TabIndex = 21;
            // 
            // pb_PretraziFilm
            // 
            this.pb_PretraziFilm.Image = ((System.Drawing.Image)(resources.GetObject("pb_PretraziFilm.Image")));
            this.pb_PretraziFilm.Location = new System.Drawing.Point(584, 12);
            this.pb_PretraziFilm.Name = "pb_PretraziFilm";
            this.pb_PretraziFilm.Size = new System.Drawing.Size(34, 32);
            this.pb_PretraziFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PretraziFilm.TabIndex = 20;
            this.pb_PretraziFilm.TabStop = false;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.DarkViolet;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(867, 397);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 29);
            this.btnNatrag.TabIndex = 19;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            // 
            // lblPretraziFilm
            // 
            this.lblPretraziFilm.AutoSize = true;
            this.lblPretraziFilm.Location = new System.Drawing.Point(236, 12);
            this.lblPretraziFilm.Name = "lblPretraziFilm";
            this.lblPretraziFilm.Size = new System.Drawing.Size(63, 13);
            this.lblPretraziFilm.TabIndex = 18;
            this.lblPretraziFilm.Text = "Pretraži film:";
            // 
            // tbPretraziFilm
            // 
            this.tbPretraziFilm.Location = new System.Drawing.Point(327, 12);
            this.tbPretraziFilm.Name = "tbPretraziFilm";
            this.tbPretraziFilm.Size = new System.Drawing.Size(235, 20);
            this.tbPretraziFilm.TabIndex = 17;
            // 
            // btnGledaj
            // 
            this.btnGledaj.BackColor = System.Drawing.Color.DarkViolet;
            this.btnGledaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGledaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGledaj.Location = new System.Drawing.Point(959, 397);
            this.btnGledaj.Name = "btnGledaj";
            this.btnGledaj.Size = new System.Drawing.Size(75, 29);
            this.btnGledaj.TabIndex = 31;
            this.btnGledaj.Text = "Gledaj";
            this.btnGledaj.UseVisualStyleBackColor = false;
            this.btnGledaj.Click += new System.EventHandler(this.btnGledaj_Click);
            // 
            // formFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 438);
            this.Controls.Add(this.btnGledaj);
            this.Controls.Add(this.pb_PretraziFilmFilter);
            this.Controls.Add(this.cmbOcjena);
            this.Controls.Add(this.cmbTrajanje);
            this.Controls.Add(this.cmbDatumIzdavanja);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.lblDatumIzdavanja);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.dgv_Filmovi);
            this.Controls.Add(this.pb_PretraziFilm);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.lblPretraziFilm);
            this.Controls.Add(this.tbPretraziFilm);
            this.Controls.Add(this.pbBanner);
            this.Name = "formFilmovi";
            this.Text = "VideoMaster - Filmovi";
            this.Load += new System.EventHandler(this.formFilmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PretraziFilmFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Filmovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PretraziFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.PictureBox pb_PretraziFilmFilter;
        private System.Windows.Forms.ComboBox cmbOcjena;
        private System.Windows.Forms.ComboBox cmbTrajanje;
        private System.Windows.Forms.ComboBox cmbDatumIzdavanja;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblDatumIzdavanja;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.DataGridView dgv_Filmovi;
        private System.Windows.Forms.PictureBox pb_PretraziFilm;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblPretraziFilm;
        private System.Windows.Forms.TextBox tbPretraziFilm;
        private System.Windows.Forms.Button btnGledaj;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}