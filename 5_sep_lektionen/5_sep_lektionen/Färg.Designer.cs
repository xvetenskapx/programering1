namespace _5_sep_lektionen
{
    partial class Färg
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
            this.btnValdFärg = new System.Windows.Forms.Button();
            this.btnRGBFärg = new System.Windows.Forms.Button();
            this.tbxGreen = new System.Windows.Forms.TextBox();
            this.tbxBlue = new System.Windows.Forms.TextBox();
            this.tbxRed = new System.Windows.Forms.TextBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.cbxFärgAlternativ = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbxVäljfärg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVäljfärg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValdFärg
            // 
            this.btnValdFärg.Location = new System.Drawing.Point(330, 415);
            this.btnValdFärg.Name = "btnValdFärg";
            this.btnValdFärg.Size = new System.Drawing.Size(137, 23);
            this.btnValdFärg.TabIndex = 0;
            this.btnValdFärg.Text = "Denna Färgen";
            this.btnValdFärg.UseVisualStyleBackColor = true;
            this.btnValdFärg.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRGBFärg
            // 
            this.btnRGBFärg.Location = new System.Drawing.Point(476, 56);
            this.btnRGBFärg.Name = "btnRGBFärg";
            this.btnRGBFärg.Size = new System.Drawing.Size(312, 23);
            this.btnRGBFärg.TabIndex = 1;
            this.btnRGBFärg.Text = "Testa Kombinationen";
            this.btnRGBFärg.UseVisualStyleBackColor = true;
            this.btnRGBFärg.Click += new System.EventHandler(this.btnRGBFärg_Click);
            // 
            // tbxGreen
            // 
            this.tbxGreen.Location = new System.Drawing.Point(582, 30);
            this.tbxGreen.Name = "tbxGreen";
            this.tbxGreen.Size = new System.Drawing.Size(100, 20);
            this.tbxGreen.TabIndex = 2;
            // 
            // tbxBlue
            // 
            this.tbxBlue.Location = new System.Drawing.Point(688, 30);
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(100, 20);
            this.tbxBlue.TabIndex = 3;
            // 
            // tbxRed
            // 
            this.tbxRed.Location = new System.Drawing.Point(476, 30);
            this.tbxRed.Name = "tbxRed";
            this.tbxRed.Size = new System.Drawing.Size(100, 20);
            this.tbxRed.TabIndex = 4;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(473, 14);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(582, 14);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 6;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(688, 14);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(31, 13);
            this.lblBlue.TabIndex = 7;
            this.lblBlue.Text = "Blue:";
            // 
            // cbxFärgAlternativ
            // 
            this.cbxFärgAlternativ.FormattingEnabled = true;
            this.cbxFärgAlternativ.Items.AddRange(new object[] {
            "Röd",
            "Grön",
            "Blå",
            "Gul",
            "Cayen",
            "Rosa",
            "Orange",
            "Lila",
            "Svart",
            "Vit"});
            this.cbxFärgAlternativ.Location = new System.Drawing.Point(12, 29);
            this.cbxFärgAlternativ.Name = "cbxFärgAlternativ";
            this.cbxFärgAlternativ.Size = new System.Drawing.Size(312, 21);
            this.cbxFärgAlternativ.TabIndex = 8;
            this.cbxFärgAlternativ.SelectedIndexChanged += new System.EventHandler(this.cbxFärgAlternativ_SelectedIndexChanged);
            // 
            // pbxVäljfärg
            // 
            this.pbxVäljfärg.BackColor = System.Drawing.Color.Red;
            this.pbxVäljfärg.Location = new System.Drawing.Point(330, 12);
            this.pbxVäljfärg.Name = "pbxVäljfärg";
            this.pbxVäljfärg.Size = new System.Drawing.Size(137, 397);
            this.pbxVäljfärg.TabIndex = 11;
            this.pbxVäljfärg.TabStop = false;
            // 
            // Färg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxVäljfärg);
            this.Controls.Add(this.cbxFärgAlternativ);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.tbxRed);
            this.Controls.Add(this.tbxBlue);
            this.Controls.Add(this.tbxGreen);
            this.Controls.Add(this.btnRGBFärg);
            this.Controls.Add(this.btnValdFärg);
            this.Name = "Färg";
            this.Text = "Färg";
            this.Load += new System.EventHandler(this.Färg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVäljfärg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValdFärg;
        private System.Windows.Forms.Button btnRGBFärg;
        private System.Windows.Forms.TextBox tbxGreen;
        private System.Windows.Forms.TextBox tbxBlue;
        private System.Windows.Forms.TextBox tbxRed;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.ComboBox cbxFärgAlternativ;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbxVäljfärg;
    }
}