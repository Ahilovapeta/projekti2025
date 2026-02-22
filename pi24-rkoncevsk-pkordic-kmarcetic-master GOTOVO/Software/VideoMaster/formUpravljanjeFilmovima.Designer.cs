namespace VideoMaster
{
    partial class formUpravljanjeFilmovima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUpravljanjeFilmovima));
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.txtPretraziFilm = new System.Windows.Forms.TextBox();
            this.lbl_PretraziFilm = new System.Windows.Forms.Label();
            this.btn_Natrag = new System.Windows.Forms.Button();
            this.pb_PretraziFilm = new System.Windows.Forms.PictureBox();
            this.btn_Uredi = new System.Windows.Forms.Button();
            this.btn_Dodaj = new System.Windows.Forms.Button();
            this.dgv_Filmovi = new System.Windows.Forms.DataGridView();
            this.lbl_Zanr = new System.Windows.Forms.Label();
            this.lbl_DatumIzdavanja = new System.Windows.Forms.Label();
            this.lbl_Trajanje = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.cmbDatumIzdavanja = new System.Windows.Forms.ComboBox();
            this.cmbTrajanje = new System.Windows.Forms.ComboBox();
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.pb_PretraziFilmFilter = new System.Windows.Forms.PictureBox();
            this.btnIzbrisiFilm = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PretraziFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Filmovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PretraziFilmFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBanner
            // 
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(0, 0);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(209, 452);
            this.pbBanner.TabIndex = 0;
            this.pbBanner.TabStop = false;
            // 
            // txtPretraziFilm
            // 
            this.txtPretraziFilm.Location = new System.Drawing.Point(333, 12);
            this.txtPretraziFilm.Name = "txtPretraziFilm";
            this.txtPretraziFilm.Size = new System.Drawing.Size(235, 20);
            this.txtPretraziFilm.TabIndex = 1;
            // 
            // lbl_PretraziFilm
            // 
            this.lbl_PretraziFilm.AutoSize = true;
            this.lbl_PretraziFilm.Location = new System.Drawing.Point(236, 12);
            this.lbl_PretraziFilm.Name = "lbl_PretraziFilm";
            this.lbl_PretraziFilm.Size = new System.Drawing.Size(63, 13);
            this.lbl_PretraziFilm.TabIndex = 2;
            this.lbl_PretraziFilm.Text = "Pretraži film:";
            // 
            // btn_Natrag
            // 
            this.btn_Natrag.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_Natrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Natrag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Natrag.Location = new System.Drawing.Point(504, 403);
            this.btn_Natrag.Name = "btn_Natrag";
            this.btn_Natrag.Size = new System.Drawing.Size(75, 29);
            this.btn_Natrag.TabIndex = 3;
            this.btn_Natrag.Text = "Natrag";
            this.btn_Natrag.UseVisualStyleBackColor = false;
            this.btn_Natrag.Click += new System.EventHandler(this.btn_Natrag_Click);
            // 
            // pb_PretraziFilm
            // 
            this.pb_PretraziFilm.Image = ((System.Drawing.Image)(resources.GetObject("pb_PretraziFilm.Image")));
            this.pb_PretraziFilm.Location = new System.Drawing.Point(594, 12);
            this.pb_PretraziFilm.Name = "pb_PretraziFilm";
            this.pb_PretraziFilm.Size = new System.Drawing.Size(34, 32);
            this.pb_PretraziFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PretraziFilm.TabIndex = 4;
            this.pb_PretraziFilm.TabStop = false;
            this.pb_PretraziFilm.Click += new System.EventHandler(this.pb_PretraziFilm_Click);
            // 
            // btn_Uredi
            // 
            this.btn_Uredi.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_Uredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Uredi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Uredi.Location = new System.Drawing.Point(624, 403);
            this.btn_Uredi.Name = "btn_Uredi";
            this.btn_Uredi.Size = new System.Drawing.Size(75, 29);
            this.btn_Uredi.TabIndex = 5;
            this.btn_Uredi.Text = "Uredi";
            this.btn_Uredi.UseVisualStyleBackColor = false;
            this.btn_Uredi.Click += new System.EventHandler(this.btn_Uredi_Click);
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Dodaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Dodaj.Location = new System.Drawing.Point(705, 403);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(75, 29);
            this.btn_Dodaj.TabIndex = 6;
            this.btn_Dodaj.Text = "Dodaj";
            this.btn_Dodaj.UseVisualStyleBackColor = false;
            this.btn_Dodaj.Click += new System.EventHandler(this.btn_Dodaj_Click);
            // 
            // dgv_Filmovi
            // 
            this.dgv_Filmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Filmovi.Location = new System.Drawing.Point(239, 96);
            this.dgv_Filmovi.Name = "dgv_Filmovi";
            this.dgv_Filmovi.Size = new System.Drawing.Size(541, 274);
            this.dgv_Filmovi.TabIndex = 7;
            // 
            // lbl_Zanr
            // 
            this.lbl_Zanr.AutoSize = true;
            this.lbl_Zanr.Location = new System.Drawing.Point(270, 43);
            this.lbl_Zanr.Name = "lbl_Zanr";
            this.lbl_Zanr.Size = new System.Drawing.Size(29, 13);
            this.lbl_Zanr.TabIndex = 8;
            this.lbl_Zanr.Text = "Žanr";
            // 
            // lbl_DatumIzdavanja
            // 
            this.lbl_DatumIzdavanja.AutoSize = true;
            this.lbl_DatumIzdavanja.Location = new System.Drawing.Point(386, 43);
            this.lbl_DatumIzdavanja.Name = "lbl_DatumIzdavanja";
            this.lbl_DatumIzdavanja.Size = new System.Drawing.Size(86, 13);
            this.lbl_DatumIzdavanja.TabIndex = 9;
            this.lbl_DatumIzdavanja.Text = "Datum izdavanja";
            // 
            // lbl_Trajanje
            // 
            this.lbl_Trajanje.AutoSize = true;
            this.lbl_Trajanje.Location = new System.Drawing.Point(534, 43);
            this.lbl_Trajanje.Name = "lbl_Trajanje";
            this.lbl_Trajanje.Size = new System.Drawing.Size(45, 13);
            this.lbl_Trajanje.TabIndex = 10;
            this.lbl_Trajanje.Text = "Trajanje";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(670, 43);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(41, 13);
            this.lblOcjena.TabIndex = 11;
            this.lblOcjena.Text = "Ocjena";
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(239, 59);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(107, 21);
            this.cmbZanr.TabIndex = 12;
            // 
            // cmbDatumIzdavanja
            // 
            this.cmbDatumIzdavanja.FormattingEnabled = true;
            this.cmbDatumIzdavanja.Location = new System.Drawing.Point(375, 59);
            this.cmbDatumIzdavanja.Name = "cmbDatumIzdavanja";
            this.cmbDatumIzdavanja.Size = new System.Drawing.Size(107, 21);
            this.cmbDatumIzdavanja.TabIndex = 13;
            // 
            // cmbTrajanje
            // 
            this.cmbTrajanje.FormattingEnabled = true;
            this.cmbTrajanje.Location = new System.Drawing.Point(508, 59);
            this.cmbTrajanje.Name = "cmbTrajanje";
            this.cmbTrajanje.Size = new System.Drawing.Size(107, 21);
            this.cmbTrajanje.TabIndex = 14;
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Location = new System.Drawing.Point(641, 59);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(107, 21);
            this.cmbOcjena.TabIndex = 15;
            // 
            // pb_PretraziFilmFilter
            // 
            this.pb_PretraziFilmFilter.BackColor = System.Drawing.Color.Transparent;
            this.pb_PretraziFilmFilter.Image = ((System.Drawing.Image)(resources.GetObject("pb_PretraziFilmFilter.Image")));
            this.pb_PretraziFilmFilter.Location = new System.Drawing.Point(754, 48);
            this.pb_PretraziFilmFilter.Name = "pb_PretraziFilmFilter";
            this.pb_PretraziFilmFilter.Size = new System.Drawing.Size(34, 32);
            this.pb_PretraziFilmFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PretraziFilmFilter.TabIndex = 16;
            this.pb_PretraziFilmFilter.TabStop = false;
            this.pb_PretraziFilmFilter.Click += new System.EventHandler(this.pb_PretraziFilmFilter_Click);
            // 
            // btnIzbrisiFilm
            // 
            this.btnIzbrisiFilm.BackColor = System.Drawing.Color.DarkViolet;
            this.btnIzbrisiFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiFilm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzbrisiFilm.Location = new System.Drawing.Point(239, 403);
            this.btnIzbrisiFilm.Name = "btnIzbrisiFilm";
            this.btnIzbrisiFilm.Size = new System.Drawing.Size(75, 29);
            this.btnIzbrisiFilm.TabIndex = 17;
            this.btnIzbrisiFilm.Text = "Izbriši";
            this.btnIzbrisiFilm.UseVisualStyleBackColor = false;
            this.btnIzbrisiFilm.Click += new System.EventHandler(this.btnIzbrisiFilm_Click);
            // 
            // formUpravljanjeFilmovima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzbrisiFilm);
            this.Controls.Add(this.pb_PretraziFilmFilter);
            this.Controls.Add(this.cmbOcjena);
            this.Controls.Add(this.cmbTrajanje);
            this.Controls.Add(this.cmbDatumIzdavanja);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lbl_Trajanje);
            this.Controls.Add(this.lbl_DatumIzdavanja);
            this.Controls.Add(this.lbl_Zanr);
            this.Controls.Add(this.dgv_Filmovi);
            this.Controls.Add(this.btn_Dodaj);
            this.Controls.Add(this.btn_Uredi);
            this.Controls.Add(this.pb_PretraziFilm);
            this.Controls.Add(this.btn_Natrag);
            this.Controls.Add(this.lbl_PretraziFilm);
            this.Controls.Add(this.txtPretraziFilm);
            this.Controls.Add(this.pbBanner);
            this.Name = "formUpravljanjeFilmovima";
            this.Text = "VideoMaster - Upravljanje filmovima";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PretraziFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Filmovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PretraziFilmFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.TextBox txtPretraziFilm;
        private System.Windows.Forms.Label lbl_PretraziFilm;
        private System.Windows.Forms.Button btn_Natrag;
        private System.Windows.Forms.PictureBox pb_PretraziFilm;
        private System.Windows.Forms.Button btn_Uredi;
        private System.Windows.Forms.Button btn_Dodaj;
        private System.Windows.Forms.DataGridView dgv_Filmovi;
        private System.Windows.Forms.Label lbl_Zanr;
        private System.Windows.Forms.Label lbl_DatumIzdavanja;
        private System.Windows.Forms.Label lbl_Trajanje;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.ComboBox cmbDatumIzdavanja;
        private System.Windows.Forms.ComboBox cmbTrajanje;
        private System.Windows.Forms.ComboBox cmbOcjena;
        private System.Windows.Forms.PictureBox pb_PretraziFilmFilter;
        private System.Windows.Forms.Button btnIzbrisiFilm;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

