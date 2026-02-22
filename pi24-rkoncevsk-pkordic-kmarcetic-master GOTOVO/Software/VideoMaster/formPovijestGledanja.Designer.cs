namespace VideoMaster
{
    partial class formPovijestGledanja
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.DataGridView dgvPovijest;
        private System.Windows.Forms.Label lblNajzanr;
        private System.Windows.Forms.Label lblNajfilm;
        private System.Windows.Forms.TextBox txtNajzanr;
        private System.Windows.Forms.TextBox txtNajfilm;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPovijestGledanja));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.dgvPovijest = new System.Windows.Forms.DataGridView();
            this.lblNajzanr = new System.Windows.Forms.Label();
            this.lblNajfilm = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.txtNajzanr = new System.Windows.Forms.TextBox();
            this.txtNajfilm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijest)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(138, 572);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.Location = new System.Drawing.Point(184, 9);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(189, 30);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Povijest gledanja";
            // 
            // dgvPovijest
            // 
            this.dgvPovijest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovijest.Location = new System.Drawing.Point(178, 52);
            this.dgvPovijest.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPovijest.Name = "dgvPovijest";
            this.dgvPovijest.Size = new System.Drawing.Size(767, 407);
            this.dgvPovijest.TabIndex = 2;
            // 
            // lblNajzanr
            // 
            this.lblNajzanr.AutoSize = true;
            this.lblNajzanr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNajzanr.Location = new System.Drawing.Point(507, 483);
            this.lblNajzanr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNajzanr.Name = "lblNajzanr";
            this.lblNajzanr.Size = new System.Drawing.Size(0, 19);
            this.lblNajzanr.TabIndex = 3;
            // 
            // lblNajfilm
            // 
            this.lblNajfilm.AutoSize = true;
            this.lblNajfilm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNajfilm.Location = new System.Drawing.Point(507, 522);
            this.lblNajfilm.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.lblNajfilm.Name = "lblNajfilm";
            this.lblNajfilm.Size = new System.Drawing.Size(0, 19);
            this.lblNajfilm.TabIndex = 4;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.DarkViolet;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(205, 483);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(100, 58);
            this.btnNatrag.TabIndex = 10;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtNajzanr
            // 
            this.txtNajzanr.Location = new System.Drawing.Point(645, 503);
            this.txtNajzanr.Name = "txtNajzanr";
            this.txtNajzanr.ReadOnly = true;
            this.txtNajzanr.Size = new System.Drawing.Size(300, 20);
            this.txtNajzanr.TabIndex = 6;
            // 
            // txtNajfilm
            // 
            this.txtNajfilm.Location = new System.Drawing.Point(328, 503);
            this.txtNajfilm.Name = "txtNajfilm";
            this.txtNajfilm.ReadOnly = true;
            this.txtNajfilm.Size = new System.Drawing.Size(300, 20);
            this.txtNajfilm.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Najdraži film:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Najdraži žanr:";
            // 
            // formPovijestGledanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNajzanr);
            this.Controls.Add(this.txtNajfilm);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.lblNajfilm);
            this.Controls.Add(this.lblNajzanr);
            this.Controls.Add(this.dgvPovijest);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formPovijestGledanja";
            this.Text = "Povijest gledanja";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
