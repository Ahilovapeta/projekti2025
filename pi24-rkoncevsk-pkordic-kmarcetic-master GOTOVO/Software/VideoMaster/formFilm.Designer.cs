namespace VideoMaster
{
    partial class formFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFilm));
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.placeholderFilm = new System.Windows.Forms.PictureBox();
            this.pbZvjezdica1 = new System.Windows.Forms.PictureBox();
            this.pbZvjezdica5 = new System.Windows.Forms.PictureBox();
            this.pbZvjezdica4 = new System.Windows.Forms.PictureBox();
            this.pbZvjezdica3 = new System.Windows.Forms.PictureBox();
            this.pbZvjezdica2 = new System.Windows.Forms.PictureBox();
            this.process1 = new System.Diagnostics.Process();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOcjena = new System.Windows.Forms.Button();
            this.rtxKomentar = new System.Windows.Forms.RichTextBox();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.placeholderFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.Purple;
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(62, 382);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(82, 32);
            this.btnNatrag.TabIndex = 0;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivFilma.Location = new System.Drawing.Point(12, 9);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(716, 73);
            this.lblNazivFilma.TabIndex = 1;
            this.lblNazivFilma.Text = "Naziv filma";
            this.lblNazivFilma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(179, 385);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(44, 13);
            this.lblOcjena.TabIndex = 2;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // placeholderFilm
            // 
            this.placeholderFilm.Location = new System.Drawing.Point(62, 79);
            this.placeholderFilm.Name = "placeholderFilm";
            this.placeholderFilm.Size = new System.Drawing.Size(620, 294);
            this.placeholderFilm.TabIndex = 3;
            this.placeholderFilm.TabStop = false;
            // 
            // pbZvjezdica1
            // 
            this.pbZvjezdica1.Image = ((System.Drawing.Image)(resources.GetObject("pbZvjezdica1.Image")));
            this.pbZvjezdica1.Location = new System.Drawing.Point(229, 382);
            this.pbZvjezdica1.Name = "pbZvjezdica1";
            this.pbZvjezdica1.Size = new System.Drawing.Size(29, 25);
            this.pbZvjezdica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZvjezdica1.TabIndex = 4;
            this.pbZvjezdica1.TabStop = false;
            // 
            // pbZvjezdica5
            // 
            this.pbZvjezdica5.Image = ((System.Drawing.Image)(resources.GetObject("pbZvjezdica5.Image")));
            this.pbZvjezdica5.Location = new System.Drawing.Point(369, 382);
            this.pbZvjezdica5.Name = "pbZvjezdica5";
            this.pbZvjezdica5.Size = new System.Drawing.Size(29, 25);
            this.pbZvjezdica5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZvjezdica5.TabIndex = 5;
            this.pbZvjezdica5.TabStop = false;
            // 
            // pbZvjezdica4
            // 
            this.pbZvjezdica4.Image = ((System.Drawing.Image)(resources.GetObject("pbZvjezdica4.Image")));
            this.pbZvjezdica4.Location = new System.Drawing.Point(334, 382);
            this.pbZvjezdica4.Name = "pbZvjezdica4";
            this.pbZvjezdica4.Size = new System.Drawing.Size(29, 25);
            this.pbZvjezdica4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZvjezdica4.TabIndex = 6;
            this.pbZvjezdica4.TabStop = false;
            // 
            // pbZvjezdica3
            // 
            this.pbZvjezdica3.Image = ((System.Drawing.Image)(resources.GetObject("pbZvjezdica3.Image")));
            this.pbZvjezdica3.Location = new System.Drawing.Point(299, 382);
            this.pbZvjezdica3.Name = "pbZvjezdica3";
            this.pbZvjezdica3.Size = new System.Drawing.Size(29, 25);
            this.pbZvjezdica3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZvjezdica3.TabIndex = 7;
            this.pbZvjezdica3.TabStop = false;
            // 
            // pbZvjezdica2
            // 
            this.pbZvjezdica2.Image = ((System.Drawing.Image)(resources.GetObject("pbZvjezdica2.Image")));
            this.pbZvjezdica2.Location = new System.Drawing.Point(264, 382);
            this.pbZvjezdica2.Name = "pbZvjezdica2";
            this.pbZvjezdica2.Size = new System.Drawing.Size(29, 25);
            this.pbZvjezdica2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZvjezdica2.TabIndex = 8;
            this.pbZvjezdica2.TabStop = false;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(62, 79);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(620, 294);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(600, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gledaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOcjena
            // 
            this.btnOcjena.BackColor = System.Drawing.Color.Purple;
            this.btnOcjena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcjena.ForeColor = System.Drawing.Color.White;
            this.btnOcjena.Location = new System.Drawing.Point(600, 382);
            this.btnOcjena.Name = "btnOcjena";
            this.btnOcjena.Size = new System.Drawing.Size(82, 32);
            this.btnOcjena.TabIndex = 12;
            this.btnOcjena.Text = "Ocjeni";
            this.btnOcjena.UseVisualStyleBackColor = false;
            this.btnOcjena.Click += new System.EventHandler(this.btnOcjena_Click);
            // 
            // rtxKomentar
            // 
            this.rtxKomentar.Location = new System.Drawing.Point(143, 453);
            this.rtxKomentar.Name = "rtxKomentar";
            this.rtxKomentar.Size = new System.Drawing.Size(419, 74);
            this.rtxKomentar.TabIndex = 13;
            this.rtxKomentar.Text = "";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(62, 453);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(55, 13);
            this.lblKomentar.TabIndex = 14;
            this.lblKomentar.Text = "Komentar:";
            // 
            // formFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 529);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.rtxKomentar);
            this.Controls.Add(this.btnOcjena);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pbZvjezdica2);
            this.Controls.Add(this.pbZvjezdica3);
            this.Controls.Add(this.pbZvjezdica4);
            this.Controls.Add(this.pbZvjezdica5);
            this.Controls.Add(this.pbZvjezdica1);
            this.Controls.Add(this.placeholderFilm);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lblNazivFilma);
            this.Controls.Add(this.btnNatrag);
            this.Name = "formFilm";
            this.Text = "VideoMaster - Film";
            this.Load += new System.EventHandler(this.formFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placeholderFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvjezdica2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblNazivFilma;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.PictureBox placeholderFilm;
        private System.Windows.Forms.PictureBox pbZvjezdica1;
        private System.Windows.Forms.PictureBox pbZvjezdica5;
        private System.Windows.Forms.PictureBox pbZvjezdica4;
        private System.Windows.Forms.PictureBox pbZvjezdica3;
        private System.Windows.Forms.PictureBox pbZvjezdica2;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOcjena;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.RichTextBox rtxKomentar;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}