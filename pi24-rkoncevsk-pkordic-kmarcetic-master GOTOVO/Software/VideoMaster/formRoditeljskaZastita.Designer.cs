namespace VideoMaster
{
    partial class formRoditeljskaZastita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRoditeljskaZastita));
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cbRoditeljskaZastita = new System.Windows.Forms.CheckBox();
            this.cbNC17 = new System.Windows.Forms.CheckBox();
            this.cbR = new System.Windows.Forms.CheckBox();
            this.cbPG13 = new System.Windows.Forms.CheckBox();
            this.cbPG = new System.Windows.Forms.CheckBox();
            this.lblRoditeljskaZastita = new System.Windows.Forms.Label();
            this.lblRazinaZastite = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBanner
            // 
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(-4, -1);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(191, 147);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabIndex = 0;
            this.pbBanner.TabStop = false;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.Purple;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNatrag.Location = new System.Drawing.Point(317, 95);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 29);
            this.btnNatrag.TabIndex = 8;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Purple;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSpremi.Location = new System.Drawing.Point(404, 95);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 29);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cbRoditeljskaZastita
            // 
            this.cbRoditeljskaZastita.AutoSize = true;
            this.cbRoditeljskaZastita.Location = new System.Drawing.Point(390, 22);
            this.cbRoditeljskaZastita.Name = "cbRoditeljskaZastita";
            this.cbRoditeljskaZastita.Size = new System.Drawing.Size(15, 14);
            this.cbRoditeljskaZastita.TabIndex = 11;
            this.cbRoditeljskaZastita.UseVisualStyleBackColor = true;
            this.cbRoditeljskaZastita.CheckedChanged += new System.EventHandler(this.cbRoditeljskaZastita_CheckedChanged);
            // 
            // cbNC17
            // 
            this.cbNC17.AutoSize = true;
            this.cbNC17.Enabled = false;
            this.cbNC17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNC17.Location = new System.Drawing.Point(275, 56);
            this.cbNC17.Name = "cbNC17";
            this.cbNC17.Size = new System.Drawing.Size(56, 17);
            this.cbNC17.TabIndex = 12;
            this.cbNC17.Text = "NC-17";
            this.cbNC17.UseVisualStyleBackColor = true;
            this.cbNC17.CheckedChanged += new System.EventHandler(this.cbNC17_CheckedChanged);
            // 
            // cbR
            // 
            this.cbR.AutoSize = true;
            this.cbR.Enabled = false;
            this.cbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbR.Location = new System.Drawing.Point(337, 56);
            this.cbR.Name = "cbR";
            this.cbR.Size = new System.Drawing.Size(34, 17);
            this.cbR.TabIndex = 13;
            this.cbR.Text = "R";
            this.cbR.UseVisualStyleBackColor = true;
            this.cbR.CheckedChanged += new System.EventHandler(this.cbR_CheckedChanged);
            // 
            // cbPG13
            // 
            this.cbPG13.AutoSize = true;
            this.cbPG13.Enabled = false;
            this.cbPG13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPG13.Location = new System.Drawing.Point(376, 56);
            this.cbPG13.Name = "cbPG13";
            this.cbPG13.Size = new System.Drawing.Size(56, 17);
            this.cbPG13.TabIndex = 14;
            this.cbPG13.Text = "PG-13";
            this.cbPG13.UseVisualStyleBackColor = true;
            this.cbPG13.CheckedChanged += new System.EventHandler(this.cbPG13_CheckedChanged);
            // 
            // cbPG
            // 
            this.cbPG.AutoSize = true;
            this.cbPG.Enabled = false;
            this.cbPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPG.Location = new System.Drawing.Point(438, 57);
            this.cbPG.Name = "cbPG";
            this.cbPG.Size = new System.Drawing.Size(41, 17);
            this.cbPG.TabIndex = 15;
            this.cbPG.Text = "PG";
            this.cbPG.UseVisualStyleBackColor = true;
            this.cbPG.CheckedChanged += new System.EventHandler(this.cbPG_CheckedChanged);
            // 
            // lblRoditeljskaZastita
            // 
            this.lblRoditeljskaZastita.AutoSize = true;
            this.lblRoditeljskaZastita.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRoditeljskaZastita.Location = new System.Drawing.Point(193, 18);
            this.lblRoditeljskaZastita.Name = "lblRoditeljskaZastita";
            this.lblRoditeljskaZastita.Size = new System.Drawing.Size(191, 20);
            this.lblRoditeljskaZastita.TabIndex = 36;
            this.lblRoditeljskaZastita.Text = "Omogući roditeljsku zaštitu:";
            // 
            // lblRazinaZastite
            // 
            this.lblRazinaZastite.AutoSize = true;
            this.lblRazinaZastite.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRazinaZastite.Location = new System.Drawing.Point(218, 53);
            this.lblRazinaZastite.Name = "lblRazinaZastite";
            this.lblRazinaZastite.Size = new System.Drawing.Size(51, 20);
            this.lblRazinaZastite.TabIndex = 37;
            this.lblRazinaZastite.Text = "Sakrji:";
            // 
            // formRoditeljskaZastita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 136);
            this.Controls.Add(this.lblRazinaZastite);
            this.Controls.Add(this.lblRoditeljskaZastita);
            this.Controls.Add(this.cbPG);
            this.Controls.Add(this.cbPG13);
            this.Controls.Add(this.cbR);
            this.Controls.Add(this.cbNC17);
            this.Controls.Add(this.cbRoditeljskaZastita);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.pbBanner);
            this.Name = "formRoditeljskaZastita";
            this.Text = "VideoMaster - Roditeljska zaštita";
            this.Load += new System.EventHandler(this.formRoditeljskaZastita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.CheckBox cbRoditeljskaZastita;
        private System.Windows.Forms.CheckBox cbNC17;
        private System.Windows.Forms.CheckBox cbR;
        private System.Windows.Forms.CheckBox cbPG13;
        private System.Windows.Forms.CheckBox cbPG;
        private System.Windows.Forms.Label lblRoditeljskaZastita;
        private System.Windows.Forms.Label lblRazinaZastite;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}