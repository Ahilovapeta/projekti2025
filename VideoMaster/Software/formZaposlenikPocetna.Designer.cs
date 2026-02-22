namespace VideoMaster
{
    partial class formZaposlenikPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formZaposlenikPocetna));
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnUpravljanjeNovostima = new System.Windows.Forms.Button();
            this.btnUpravljanjeFilmovima = new System.Windows.Forms.Button();
            this.pbProfilna = new System.Windows.Forms.PictureBox();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.DarkViolet;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOdjava.Location = new System.Drawing.Point(40, 391);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(133, 46);
            this.btnOdjava.TabIndex = 16;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnUpravljanjeNovostima
            // 
            this.btnUpravljanjeNovostima.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUpravljanjeNovostima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpravljanjeNovostima.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpravljanjeNovostima.Location = new System.Drawing.Point(251, 107);
            this.btnUpravljanjeNovostima.Name = "btnUpravljanjeNovostima";
            this.btnUpravljanjeNovostima.Size = new System.Drawing.Size(126, 46);
            this.btnUpravljanjeNovostima.TabIndex = 15;
            this.btnUpravljanjeNovostima.Text = "Upravljanje novostima";
            this.btnUpravljanjeNovostima.UseVisualStyleBackColor = false;
            this.btnUpravljanjeNovostima.Click += new System.EventHandler(this.btnUpravljanjeNovostima_Click);
            // 
            // btnUpravljanjeFilmovima
            // 
            this.btnUpravljanjeFilmovima.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUpravljanjeFilmovima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpravljanjeFilmovima.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpravljanjeFilmovima.Location = new System.Drawing.Point(251, 34);
            this.btnUpravljanjeFilmovima.Name = "btnUpravljanjeFilmovima";
            this.btnUpravljanjeFilmovima.Size = new System.Drawing.Size(126, 47);
            this.btnUpravljanjeFilmovima.TabIndex = 14;
            this.btnUpravljanjeFilmovima.Text = "Upravljanje filmovima";
            this.btnUpravljanjeFilmovima.UseVisualStyleBackColor = false;
            this.btnUpravljanjeFilmovima.Click += new System.EventHandler(this.btnUpravljanjeFilmovima_Click);
            // 
            // pbProfilna
            // 
            this.pbProfilna.Location = new System.Drawing.Point(40, 211);
            this.pbProfilna.Name = "pbProfilna";
            this.pbProfilna.Size = new System.Drawing.Size(133, 107);
            this.pbProfilna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilna.TabIndex = 12;
            this.pbProfilna.TabStop = false;
            this.pbProfilna.Click += new System.EventHandler(this.pbProfilna_Click);
            // 
            // pbBanner
            // 
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(0, -1);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(209, 452);
            this.pbBanner.TabIndex = 11;
            this.pbBanner.TabStop = false;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(26, 330);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(157, 26);
            this.lblKorisnickoIme.TabIndex = 20;
            this.lblKorisnickoIme.Text = "<Korisnicko_Ime>";
            this.lblKorisnickoIme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formZaposlenikPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnUpravljanjeNovostima);
            this.Controls.Add(this.btnUpravljanjeFilmovima);
            this.Controls.Add(this.pbProfilna);
            this.Controls.Add(this.pbBanner);
            this.Name = "formZaposlenikPocetna";
            this.Text = "VideoMaster -Početna";
            this.Load += new System.EventHandler(this.formZaposlenikPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnUpravljanjeNovostima;
        private System.Windows.Forms.Button btnUpravljanjeFilmovima;
        private System.Windows.Forms.PictureBox pbProfilna;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}