namespace VideoMaster
{
    partial class formUpravljanjeNovostima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUpravljanjeNovostima));
            this.dgv_Novosti = new System.Windows.Forms.DataGridView();
            this.pbPretraziNovosti = new System.Windows.Forms.PictureBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.txtPretraziNovosti = new System.Windows.Forms.TextBox();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnUredi = new System.Windows.Forms.Button();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.lblPretraziNovosti = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Novosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPretraziNovosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Novosti
            // 
            this.dgv_Novosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Novosti.Location = new System.Drawing.Point(230, 50);
            this.dgv_Novosti.Name = "dgv_Novosti";
            this.dgv_Novosti.Size = new System.Drawing.Size(510, 274);
            this.dgv_Novosti.TabIndex = 41;
            // 
            // pbPretraziNovosti
            // 
            this.pbPretraziNovosti.Image = ((System.Drawing.Image)(resources.GetObject("pbPretraziNovosti.Image")));
            this.pbPretraziNovosti.Location = new System.Drawing.Point(583, 1);
            this.pbPretraziNovosti.Name = "pbPretraziNovosti";
            this.pbPretraziNovosti.Size = new System.Drawing.Size(45, 43);
            this.pbPretraziNovosti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPretraziNovosti.TabIndex = 38;
            this.pbPretraziNovosti.TabStop = false;
            this.pbPretraziNovosti.Click += new System.EventHandler(this.pbPretraziNovosti_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.DarkViolet;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(579, 343);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 29);
            this.btnNatrag.TabIndex = 37;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtPretraziNovosti
            // 
            this.txtPretraziNovosti.Location = new System.Drawing.Point(342, 12);
            this.txtPretraziNovosti.Name = "txtPretraziNovosti";
            this.txtPretraziNovosti.Size = new System.Drawing.Size(235, 20);
            this.txtPretraziNovosti.TabIndex = 35;
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUredi.Location = new System.Drawing.Point(671, 343);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 29);
            this.btnUredi.TabIndex = 39;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // pbBanner
            // 
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(0, 0);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(209, 385);
            this.pbBanner.TabIndex = 34;
            this.pbBanner.TabStop = false;
            // 
            // lblPretraziNovosti
            // 
            this.lblPretraziNovosti.AutoSize = true;
            this.lblPretraziNovosti.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretraziNovosti.Location = new System.Drawing.Point(226, 12);
            this.lblPretraziNovosti.Name = "lblPretraziNovosti";
            this.lblPretraziNovosti.Size = new System.Drawing.Size(114, 20);
            this.lblPretraziNovosti.TabIndex = 42;
            this.lblPretraziNovosti.Text = "Pretraži novosti:";
            // 
            // formUpravljanjeNovostima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 384);
            this.Controls.Add(this.lblPretraziNovosti);
            this.Controls.Add(this.dgv_Novosti);
            this.Controls.Add(this.pbPretraziNovosti);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtPretraziNovosti);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.pbBanner);
            this.Name = "formUpravljanjeNovostima";
            this.Text = "VideoMaster - Upravljanje novostima";
            this.Load += new System.EventHandler(this.formUpravljanjeNovostima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Novosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPretraziNovosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Novosti;
        private System.Windows.Forms.PictureBox pbPretraziNovosti;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.TextBox txtPretraziNovosti;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label lblPretraziNovosti;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}