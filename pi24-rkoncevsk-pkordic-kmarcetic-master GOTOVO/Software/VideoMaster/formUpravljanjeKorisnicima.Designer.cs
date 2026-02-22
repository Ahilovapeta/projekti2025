namespace VideoMaster
{
    partial class formUpravljanjeKorisnicima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUpravljanjeKorisnicima));
            this.pbPretraziKorisnikaFilter = new System.Windows.Forms.PictureBox();
            this.cmbUlogaKorisnika = new System.Windows.Forms.ComboBox();
            this.dgv_Korisnici = new System.Windows.Forms.DataGridView();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.pbPretraziKorisnika = new System.Windows.Forms.PictureBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.txtPretraziKorisnika = new System.Windows.Forms.TextBox();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnUredi = new System.Windows.Forms.Button();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.lblPretraziKorisnika = new System.Windows.Forms.Label();
            this.lblVrstaKorisnika = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbPretraziKorisnikaFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Korisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPretraziKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPretraziKorisnikaFilter
            // 
            this.pbPretraziKorisnikaFilter.BackColor = System.Drawing.Color.Transparent;
            this.pbPretraziKorisnikaFilter.Image = ((System.Drawing.Image)(resources.GetObject("pbPretraziKorisnikaFilter.Image")));
            this.pbPretraziKorisnikaFilter.Location = new System.Drawing.Point(414, 60);
            this.pbPretraziKorisnikaFilter.Name = "pbPretraziKorisnikaFilter";
            this.pbPretraziKorisnikaFilter.Size = new System.Drawing.Size(45, 43);
            this.pbPretraziKorisnikaFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPretraziKorisnikaFilter.TabIndex = 33;
            this.pbPretraziKorisnikaFilter.TabStop = false;
            this.pbPretraziKorisnikaFilter.Click += new System.EventHandler(this.pbPretraziKorisnikaFilter_Click);
            // 
            // cmbUlogaKorisnika
            // 
            this.cmbUlogaKorisnika.FormattingEnabled = true;
            this.cmbUlogaKorisnika.Items.AddRange(new object[] {
            "Svi",
            "Administrator",
            "Zaposlenici",
            "Individualni korisnici"});
            this.cmbUlogaKorisnika.Location = new System.Drawing.Point(245, 72);
            this.cmbUlogaKorisnika.Name = "cmbUlogaKorisnika";
            this.cmbUlogaKorisnika.Size = new System.Drawing.Size(163, 21);
            this.cmbUlogaKorisnika.TabIndex = 32;
            // 
            // dgv_Korisnici
            // 
            this.dgv_Korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Korisnici.Location = new System.Drawing.Point(245, 110);
            this.dgv_Korisnici.Name = "dgv_Korisnici";
            this.dgv_Korisnici.Size = new System.Drawing.Size(772, 274);
            this.dgv_Korisnici.TabIndex = 24;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.DarkViolet;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzbrisi.Location = new System.Drawing.Point(861, 402);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 29);
            this.btnIzbrisi.TabIndex = 23;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // pbPretraziKorisnika
            // 
            this.pbPretraziKorisnika.Image = ((System.Drawing.Image)(resources.GetObject("pbPretraziKorisnika.Image")));
            this.pbPretraziKorisnika.Location = new System.Drawing.Point(615, -1);
            this.pbPretraziKorisnika.Name = "pbPretraziKorisnika";
            this.pbPretraziKorisnika.Size = new System.Drawing.Size(45, 43);
            this.pbPretraziKorisnika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPretraziKorisnika.TabIndex = 21;
            this.pbPretraziKorisnika.TabStop = false;
            this.pbPretraziKorisnika.Click += new System.EventHandler(this.pbPretraziKorisnika_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.DarkViolet;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(741, 402);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 29);
            this.btnNatrag.TabIndex = 20;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtPretraziKorisnika
            // 
            this.txtPretraziKorisnika.Location = new System.Drawing.Point(374, 12);
            this.txtPretraziKorisnika.Name = "txtPretraziKorisnika";
            this.txtPretraziKorisnika.Size = new System.Drawing.Size(235, 20);
            this.txtPretraziKorisnika.TabIndex = 18;
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUredi.Location = new System.Drawing.Point(942, 402);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 29);
            this.btnUredi.TabIndex = 22;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // pbBanner
            // 
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(6, -1);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(209, 452);
            this.pbBanner.TabIndex = 17;
            this.pbBanner.TabStop = false;
            // 
            // lblPretraziKorisnika
            // 
            this.lblPretraziKorisnika.AutoSize = true;
            this.lblPretraziKorisnika.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretraziKorisnika.Location = new System.Drawing.Point(241, 12);
            this.lblPretraziKorisnika.Name = "lblPretraziKorisnika";
            this.lblPretraziKorisnika.Size = new System.Drawing.Size(127, 20);
            this.lblPretraziKorisnika.TabIndex = 37;
            this.lblPretraziKorisnika.Text = "Pretraži korisnika:";
            // 
            // lblVrstaKorisnika
            // 
            this.lblVrstaKorisnika.AutoSize = true;
            this.lblVrstaKorisnika.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrstaKorisnika.Location = new System.Drawing.Point(241, 49);
            this.lblVrstaKorisnika.Name = "lblVrstaKorisnika";
            this.lblVrstaKorisnika.Size = new System.Drawing.Size(115, 20);
            this.lblVrstaKorisnika.TabIndex = 38;
            this.lblVrstaKorisnika.Text = "Uloga korisnika:";
            // 
            // formUpravljanjeKorisnicima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.lblVrstaKorisnika);
            this.Controls.Add(this.lblPretraziKorisnika);
            this.Controls.Add(this.pbPretraziKorisnikaFilter);
            this.Controls.Add(this.cmbUlogaKorisnika);
            this.Controls.Add(this.dgv_Korisnici);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.pbPretraziKorisnika);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtPretraziKorisnika);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.pbBanner);
            this.Name = "formUpravljanjeKorisnicima";
            this.Text = "VideoMaster - Upravljanje korisnicima";
            this.Load += new System.EventHandler(this.formUpravljanjeKorisnicima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPretraziKorisnikaFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Korisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPretraziKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPretraziKorisnikaFilter;
        private System.Windows.Forms.ComboBox cmbUlogaKorisnika;
        private System.Windows.Forms.DataGridView dgv_Korisnici;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.PictureBox pbPretraziKorisnika;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.TextBox txtPretraziKorisnika;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label lblPretraziKorisnika;
        private System.Windows.Forms.Label lblVrstaKorisnika;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}