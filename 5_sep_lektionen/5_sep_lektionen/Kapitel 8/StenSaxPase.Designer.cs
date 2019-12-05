namespace _5_sep_lektionen
{
    partial class StenSaxPase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StenSaxPase));
            this.gbxStenSaxPåse = new System.Windows.Forms.GroupBox();
            this.lblDatornsValde = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDatornsVal = new System.Windows.Forms.Label();
            this.lblStenSaxPåse = new System.Windows.Forms.Label();
            this.pbxSten = new System.Windows.Forms.PictureBox();
            this.pbxSax = new System.Windows.Forms.PictureBox();
            this.pbxPåse = new System.Windows.Forms.PictureBox();
            this.gbxMinaResultat = new System.Windows.Forms.GroupBox();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.btnSpela = new System.Windows.Forms.Button();
            this.gbxStenSaxPåse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).BeginInit();
            this.gbxMinaResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStenSaxPåse
            // 
            this.gbxStenSaxPåse.Controls.Add(this.lblDatornsValde);
            this.gbxStenSaxPåse.Controls.Add(this.lblResultat);
            this.gbxStenSaxPåse.Controls.Add(this.lblDatornsVal);
            this.gbxStenSaxPåse.Controls.Add(this.lblStenSaxPåse);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSten);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSax);
            this.gbxStenSaxPåse.Controls.Add(this.pbxPåse);
            this.gbxStenSaxPåse.Enabled = false;
            this.gbxStenSaxPåse.Location = new System.Drawing.Point(12, 12);
            this.gbxStenSaxPåse.Name = "gbxStenSaxPåse";
            this.gbxStenSaxPåse.Size = new System.Drawing.Size(261, 192);
            this.gbxStenSaxPåse.TabIndex = 0;
            this.gbxStenSaxPåse.TabStop = false;
            this.gbxStenSaxPåse.Text = "Sten, Sax, Påse";
            // 
            // lblDatornsValde
            // 
            this.lblDatornsValde.AutoSize = true;
            this.lblDatornsValde.Location = new System.Drawing.Point(6, 123);
            this.lblDatornsValde.Name = "lblDatornsValde";
            this.lblDatornsValde.Size = new System.Drawing.Size(72, 13);
            this.lblDatornsValde.TabIndex = 9;
            this.lblDatornsValde.Text = "Datorn Valde:";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(6, 151);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(249, 23);
            this.lblResultat.TabIndex = 8;
            // 
            // lblDatornsVal
            // 
            this.lblDatornsVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsVal.Location = new System.Drawing.Point(84, 118);
            this.lblDatornsVal.Name = "lblDatornsVal";
            this.lblDatornsVal.Size = new System.Drawing.Size(52, 23);
            this.lblDatornsVal.TabIndex = 7;
            this.lblDatornsVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStenSaxPåse
            // 
            this.lblStenSaxPåse.AutoSize = true;
            this.lblStenSaxPåse.Location = new System.Drawing.Point(6, 23);
            this.lblStenSaxPåse.Name = "lblStenSaxPåse";
            this.lblStenSaxPåse.Size = new System.Drawing.Size(247, 13);
            this.lblStenSaxPåse.TabIndex = 6;
            this.lblStenSaxPåse.Text = "Välj sten, sax eller påse genom att klicka på en blid";
            // 
            // pbxSten
            // 
            this.pbxSten.Image = ((System.Drawing.Image)(resources.GetObject("pbxSten.Image")));
            this.pbxSten.Location = new System.Drawing.Point(6, 52);
            this.pbxSten.Name = "pbxSten";
            this.pbxSten.Size = new System.Drawing.Size(50, 50);
            this.pbxSten.TabIndex = 3;
            this.pbxSten.TabStop = false;
            this.pbxSten.Click += new System.EventHandler(this.pbxSten_Click);
            // 
            // pbxSax
            // 
            this.pbxSax.Image = ((System.Drawing.Image)(resources.GetObject("pbxSax.Image")));
            this.pbxSax.Location = new System.Drawing.Point(106, 52);
            this.pbxSax.Name = "pbxSax";
            this.pbxSax.Size = new System.Drawing.Size(50, 50);
            this.pbxSax.TabIndex = 4;
            this.pbxSax.TabStop = false;
            this.pbxSax.Click += new System.EventHandler(this.pbxSax_Click);
            // 
            // pbxPåse
            // 
            this.pbxPåse.Image = ((System.Drawing.Image)(resources.GetObject("pbxPåse.Image")));
            this.pbxPåse.Location = new System.Drawing.Point(205, 52);
            this.pbxPåse.Name = "pbxPåse";
            this.pbxPåse.Size = new System.Drawing.Size(50, 50);
            this.pbxPåse.TabIndex = 5;
            this.pbxPåse.TabStop = false;
            this.pbxPåse.Click += new System.EventHandler(this.pbxPåse_Click);
            // 
            // gbxMinaResultat
            // 
            this.gbxMinaResultat.Controls.Add(this.tbxMinaResultat);
            this.gbxMinaResultat.Enabled = false;
            this.gbxMinaResultat.Location = new System.Drawing.Point(279, 59);
            this.gbxMinaResultat.Name = "gbxMinaResultat";
            this.gbxMinaResultat.Size = new System.Drawing.Size(165, 145);
            this.gbxMinaResultat.TabIndex = 1;
            this.gbxMinaResultat.TabStop = false;
            this.gbxMinaResultat.Text = "Mina Resultat";
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Location = new System.Drawing.Point(6, 19);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ReadOnly = true;
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(150, 120);
            this.tbxMinaResultat.TabIndex = 3;
            // 
            // btnSpela
            // 
            this.btnSpela.Location = new System.Drawing.Point(285, 25);
            this.btnSpela.Name = "btnSpela";
            this.btnSpela.Size = new System.Drawing.Size(75, 23);
            this.btnSpela.TabIndex = 2;
            this.btnSpela.Text = "Spela";
            this.btnSpela.UseVisualStyleBackColor = true;
            this.btnSpela.Click += new System.EventHandler(this.btnSpela_Click);
            // 
            // StenSaxPase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 232);
            this.Controls.Add(this.btnSpela);
            this.Controls.Add(this.gbxMinaResultat);
            this.Controls.Add(this.gbxStenSaxPåse);
            this.Name = "StenSaxPase";
            this.Text = "StenSaxPase";
            this.Load += new System.EventHandler(this.StenSaxPase_Load);
            this.gbxStenSaxPåse.ResumeLayout(false);
            this.gbxStenSaxPåse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).EndInit();
            this.gbxMinaResultat.ResumeLayout(false);
            this.gbxMinaResultat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStenSaxPåse;
        private System.Windows.Forms.Label lblStenSaxPåse;
        private System.Windows.Forms.PictureBox pbxSten;
        private System.Windows.Forms.PictureBox pbxSax;
        private System.Windows.Forms.PictureBox pbxPåse;
        private System.Windows.Forms.GroupBox gbxMinaResultat;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.Button btnSpela;
        private System.Windows.Forms.Label lblDatornsValde;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblDatornsVal;
    }
}