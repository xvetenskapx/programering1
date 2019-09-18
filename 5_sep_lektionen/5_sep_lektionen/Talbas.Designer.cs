namespace _5_sep_lektionen
{
    partial class Talbas
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
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.tbxTal = new System.Windows.Forms.TextBox();
            this.lblTalbas = new System.Windows.Forms.Label();
            this.lblSvarD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Location = new System.Drawing.Point(12, 12);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(92, 23);
            this.btnBeräkna.TabIndex = 0;
            this.btnBeräkna.Text = "Binärt>Decimal";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.BtnBeräkna_Click);
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(12, 41);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxTal.Size = new System.Drawing.Size(100, 20);
            this.tbxTal.TabIndex = 1;
            this.tbxTal.Text = "00000";
            // 
            // lblTalbas
            // 
            this.lblTalbas.AutoSize = true;
            this.lblTalbas.Location = new System.Drawing.Point(50, 64);
            this.lblTalbas.Name = "lblTalbas";
            this.lblTalbas.Size = new System.Drawing.Size(16, 13);
            this.lblTalbas.TabIndex = 2;
            this.lblTalbas.Text = "---";
            // 
            // lblSvarD
            // 
            this.lblSvarD.AutoSize = true;
            this.lblSvarD.Location = new System.Drawing.Point(12, 64);
            this.lblSvarD.Name = "lblSvarD";
            this.lblSvarD.Size = new System.Drawing.Size(32, 13);
            this.lblSvarD.TabIndex = 3;
            this.lblSvarD.Text = "Svar:";
            // 
            // Talbas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSvarD);
            this.Controls.Add(this.lblTalbas);
            this.Controls.Add(this.tbxTal);
            this.Controls.Add(this.btnBeräkna);
            this.Name = "Talbas";
            this.Text = "Talbas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeräkna;
        private System.Windows.Forms.TextBox tbxTal;
        private System.Windows.Forms.Label lblTalbas;
        private System.Windows.Forms.Label lblSvarD;
    }
}