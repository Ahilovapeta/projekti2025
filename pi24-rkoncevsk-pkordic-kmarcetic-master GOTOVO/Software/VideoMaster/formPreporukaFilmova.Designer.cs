namespace VideoMaster
{
    partial class formPreporukaFilmova
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPreporuke;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPreporukaFilmova));
            this.dgvPreporuke = new System.Windows.Forms.DataGridView();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.btnGledaj = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnPreskoci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpisFilma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreporuke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreporuke
            // 
            this.dgvPreporuke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreporuke.Location = new System.Drawing.Point(236, 103);
            this.dgvPreporuke.Name = "dgvPreporuke";
            this.dgvPreporuke.Size = new System.Drawing.Size(642, 310);
            this.dgvPreporuke.TabIndex = 0;
            // 
            // pbBanner
            // 
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(-1, -2);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(212, 883);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBanner.TabIndex = 3;
            this.pbBanner.TabStop = false;
            // 
            // btnGledaj
            // 
            this.btnGledaj.BackColor = System.Drawing.Color.DarkViolet;
            this.btnGledaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGledaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGledaj.Location = new System.Drawing.Point(785, 524);
            this.btnGledaj.Name = "btnGledaj";
            this.btnGledaj.Size = new System.Drawing.Size(75, 29);
            this.btnGledaj.TabIndex = 12;
            this.btnGledaj.Text = "Gledaj";
            this.btnGledaj.UseVisualStyleBackColor = false;
            this.btnGledaj.Click += new System.EventHandler(this.btnGledaj_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.DarkViolet;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(394, 524);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 29);
            this.btnNatrag.TabIndex = 11;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnPreskoci
            // 
            this.btnPreskoci.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPreskoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreskoci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreskoci.Location = new System.Drawing.Point(685, 524);
            this.btnPreskoci.Name = "btnPreskoci";
            this.btnPreskoci.Size = new System.Drawing.Size(75, 29);
            this.btnPreskoci.TabIndex = 13;
            this.btnPreskoci.Text = "Preskoci";
            this.btnPreskoci.UseVisualStyleBackColor = false;
            this.btnPreskoci.Click += new System.EventHandler(this.btnPreskoci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.35F);
            this.label1.Location = new System.Drawing.Point(387, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "VideoMaster preporucuje";
            // 
            // txtOpisFilma
            // 
            this.txtOpisFilma.Location = new System.Drawing.Point(236, 419);
            this.txtOpisFilma.Multiline = true;
            this.txtOpisFilma.Name = "txtOpisFilma";
            this.txtOpisFilma.Size = new System.Drawing.Size(642, 99);
            this.txtOpisFilma.TabIndex = 15;
            // 
            // formPreporukaFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 583);
            this.Controls.Add(this.txtOpisFilma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreskoci);
            this.Controls.Add(this.btnGledaj);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.dgvPreporuke);
            this.Name = "formPreporukaFilmova";
            this.Text = "Preporuka filmova";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreporuke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Button btnGledaj;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnPreskoci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpisFilma;
    }
}
