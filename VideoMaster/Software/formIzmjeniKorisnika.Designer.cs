namespace VideoMaster
{
    partial class formIzmjeniKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIzmjeniKorisnika));
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.txtNadimak = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.pbProfilna = new System.Windows.Forms.PictureBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblNadimak = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilna)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBanner
            // 
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(-1, -1);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(209, 452);
            this.pbBanner.TabIndex = 18;
            this.pbBanner.TabStop = false;
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(310, 220);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(222, 20);
            this.txtNadimak.TabIndex = 23;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(310, 178);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(222, 20);
            this.txtPrezime.TabIndex = 24;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(310, 136);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(222, 20);
            this.txtIme.TabIndex = 25;
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbUloga.Location = new System.Drawing.Point(310, 305);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(222, 21);
            this.cmbUloga.TabIndex = 26;
            // 
            // pbProfilna
            // 
            this.pbProfilna.Location = new System.Drawing.Point(310, 12);
            this.pbProfilna.Name = "pbProfilna";
            this.pbProfilna.Size = new System.Drawing.Size(133, 107);
            this.pbProfilna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilna.TabIndex = 29;
            this.pbProfilna.TabStop = false;
            this.pbProfilna.Click += new System.EventHandler(this.pbProfilna_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(310, 262);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(222, 20);
            this.txtLozinka.TabIndex = 31;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(227, 178);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(65, 20);
            this.lblPrezime.TabIndex = 32;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(227, 136);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(37, 20);
            this.lblIme.TabIndex = 33;
            this.lblIme.Text = "Ime:";
            // 
            // lblNadimak
            // 
            this.lblNadimak.AutoSize = true;
            this.lblNadimak.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNadimak.Location = new System.Drawing.Point(227, 220);
            this.lblNadimak.Name = "lblNadimak";
            this.lblNadimak.Size = new System.Drawing.Size(71, 20);
            this.lblNadimak.TabIndex = 34;
            this.lblNadimak.Text = "Nadimak:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(227, 262);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(63, 20);
            this.lblLozinka.TabIndex = 35;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUloga.Location = new System.Drawing.Point(227, 304);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(51, 20);
            this.lblUloga.TabIndex = 36;
            this.lblUloga.Text = "Uloga:";
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.DarkViolet;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(368, 353);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 29);
            this.btnNatrag.TabIndex = 37;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click_1);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpremi.Location = new System.Drawing.Point(457, 353);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 29);
            this.btnSpremi.TabIndex = 38;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // formIzmjeniKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 399);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblNadimak);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.pbProfilna);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtNadimak);
            this.Controls.Add(this.pbBanner);
            this.Name = "formIzmjeniKorisnika";
            this.Text = "VideoMaster - Izmjeni korisnika";
            this.Load += new System.EventHandler(this.formIzmjeniKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.TextBox txtNadimak;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.PictureBox pbProfilna;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblNadimak;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}