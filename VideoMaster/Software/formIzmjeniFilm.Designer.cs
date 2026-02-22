namespace VideoMaster
{
    partial class formIzmjeniFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIzmjeniFilm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblRedatelj = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblDobnoOgranicenje = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblPrenesiFilm = new System.Windows.Forms.Label();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtRedatelj = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.dtpGodina = new System.Windows.Forms.DateTimePicker();
            this.lblTrajanje2 = new System.Windows.Forms.Label();
            this.cmbDobroOgranicenje = new System.Windows.Forms.ComboBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.btnOdaberiPrenesiFilm = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblOdabereniFilm = new System.Windows.Forms.Label();
            this.btnSpremiFilm = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 452);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Location = new System.Drawing.Point(240, 9);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(59, 13);
            this.lblThumbnail.TabIndex = 2;
            this.lblThumbnail.Text = "Thumbnail:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(240, 128);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblRedatelj
            // 
            this.lblRedatelj.AutoSize = true;
            this.lblRedatelj.Location = new System.Drawing.Point(240, 165);
            this.lblRedatelj.Name = "lblRedatelj";
            this.lblRedatelj.Size = new System.Drawing.Size(49, 13);
            this.lblRedatelj.TabIndex = 4;
            this.lblRedatelj.Text = "Redatelj:";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(240, 202);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(44, 13);
            this.lblGodina.TabIndex = 5;
            this.lblGodina.Text = "Godina:";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(240, 240);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(48, 13);
            this.lblTrajanje.TabIndex = 6;
            this.lblTrajanje.Text = "Trajanje:";
            // 
            // lblDobnoOgranicenje
            // 
            this.lblDobnoOgranicenje.AutoSize = true;
            this.lblDobnoOgranicenje.Location = new System.Drawing.Point(240, 280);
            this.lblDobnoOgranicenje.Name = "lblDobnoOgranicenje";
            this.lblDobnoOgranicenje.Size = new System.Drawing.Size(100, 13);
            this.lblDobnoOgranicenje.TabIndex = 7;
            this.lblDobnoOgranicenje.Text = "Dobno ograničenje:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(240, 320);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(31, 13);
            this.lblOpis.TabIndex = 8;
            this.lblOpis.Text = "Opis:";
            // 
            // lblPrenesiFilm
            // 
            this.lblPrenesiFilm.AutoSize = true;
            this.lblPrenesiFilm.Location = new System.Drawing.Point(240, 380);
            this.lblPrenesiFilm.Name = "lblPrenesiFilm";
            this.lblPrenesiFilm.Size = new System.Drawing.Size(63, 13);
            this.lblPrenesiFilm.TabIndex = 9;
            this.lblPrenesiFilm.Text = "Prenesi film:";
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.Location = new System.Drawing.Point(431, 9);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(204, 108);
            this.pbThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThumbnail.TabIndex = 10;
            this.pbThumbnail.TabStop = false;
            this.pbThumbnail.Click += new System.EventHandler(this.pbThumbnail_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(431, 128);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(204, 20);
            this.txtNaziv.TabIndex = 11;
            // 
            // txtRedatelj
            // 
            this.txtRedatelj.Location = new System.Drawing.Point(431, 165);
            this.txtRedatelj.Name = "txtRedatelj";
            this.txtRedatelj.Size = new System.Drawing.Size(204, 20);
            this.txtRedatelj.TabIndex = 12;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(431, 240);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(204, 20);
            this.txtTrajanje.TabIndex = 13;
            // 
            // dtpGodina
            // 
            this.dtpGodina.Location = new System.Drawing.Point(431, 202);
            this.dtpGodina.Name = "dtpGodina";
            this.dtpGodina.Size = new System.Drawing.Size(204, 20);
            this.dtpGodina.TabIndex = 14;
            // 
            // lblTrajanje2
            // 
            this.lblTrajanje2.AutoSize = true;
            this.lblTrajanje2.Location = new System.Drawing.Point(641, 243);
            this.lblTrajanje2.Name = "lblTrajanje2";
            this.lblTrajanje2.Size = new System.Drawing.Size(38, 13);
            this.lblTrajanje2.TabIndex = 15;
            this.lblTrajanje2.Text = "minuta";
            // 
            // cmbDobroOgranicenje
            // 
            this.cmbDobroOgranicenje.FormattingEnabled = true;
            this.cmbDobroOgranicenje.Location = new System.Drawing.Point(431, 277);
            this.cmbDobroOgranicenje.Name = "cmbDobroOgranicenje";
            this.cmbDobroOgranicenje.Size = new System.Drawing.Size(204, 21);
            this.cmbDobroOgranicenje.TabIndex = 17;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(431, 320);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(204, 44);
            this.rtbOpis.TabIndex = 18;
            this.rtbOpis.Text = "";
            // 
            // btnOdaberiPrenesiFilm
            // 
            this.btnOdaberiPrenesiFilm.Location = new System.Drawing.Point(431, 380);
            this.btnOdaberiPrenesiFilm.Name = "btnOdaberiPrenesiFilm";
            this.btnOdaberiPrenesiFilm.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberiPrenesiFilm.TabIndex = 19;
            this.btnOdaberiPrenesiFilm.Text = "Odaberi film";
            this.btnOdaberiPrenesiFilm.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblOdabereniFilm
            // 
            this.lblOdabereniFilm.AutoSize = true;
            this.lblOdabereniFilm.Location = new System.Drawing.Point(553, 385);
            this.lblOdabereniFilm.Name = "lblOdabereniFilm";
            this.lblOdabereniFilm.Size = new System.Drawing.Size(37, 13);
            this.lblOdabereniFilm.TabIndex = 20;
            this.lblOdabereniFilm.Text = "<Film>";
            // 
            // btnSpremiFilm
            // 
            this.btnSpremiFilm.Location = new System.Drawing.Point(713, 415);
            this.btnSpremiFilm.Name = "btnSpremiFilm";
            this.btnSpremiFilm.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiFilm.TabIndex = 21;
            this.btnSpremiFilm.Text = "Spremi";
            this.btnSpremiFilm.UseVisualStyleBackColor = true;
            this.btnSpremiFilm.Click += new System.EventHandler(this.btnSpremiFilm_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(604, 415);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 22;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // formIzmjeniFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnSpremiFilm);
            this.Controls.Add(this.lblOdabereniFilm);
            this.Controls.Add(this.btnOdaberiPrenesiFilm);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.cmbDobroOgranicenje);
            this.Controls.Add(this.lblTrajanje2);
            this.Controls.Add(this.dtpGodina);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtRedatelj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.pbThumbnail);
            this.Controls.Add(this.lblPrenesiFilm);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDobnoOgranicenje);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblRedatelj);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblThumbnail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formIzmjeniFilm";
            this.Text = "VideoMaster - Izmjeni film";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblRedatelj;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblDobnoOgranicenje;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblPrenesiFilm;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtRedatelj;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.DateTimePicker dtpGodina;
        private System.Windows.Forms.Label lblTrajanje2;
        private System.Windows.Forms.ComboBox cmbDobroOgranicenje;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Button btnOdaberiPrenesiFilm;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblOdabereniFilm;
        private System.Windows.Forms.Button btnSpremiFilm;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}