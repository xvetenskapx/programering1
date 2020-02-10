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
            this.button1 = new System.Windows.Forms.Button();
            this.btnRGBFärg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.cbxFärgAlternativ = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbxVäljfärg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVäljfärg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRGBFärg
            // 
            this.btnRGBFärg.Location = new System.Drawing.Point(476, 56);
            this.btnRGBFärg.Name = "btnRGBFärg";
            this.btnRGBFärg.Size = new System.Drawing.Size(312, 23);
            this.btnRGBFärg.TabIndex = 1;
            this.btnRGBFärg.Text = "button2";
            this.btnRGBFärg.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(688, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(476, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
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
            this.cbxFärgAlternativ.Location = new System.Drawing.Point(84, 30);
            this.cbxFärgAlternativ.Name = "cbxFärgAlternativ";
            this.cbxFärgAlternativ.Size = new System.Drawing.Size(121, 21);
            this.cbxFärgAlternativ.TabIndex = 8;
            this.cbxFärgAlternativ.SelectedIndexChanged += new System.EventHandler(this.cbxFärgAlternativ_SelectedIndexChanged);
            // 
            // pbxVäljfärg
            // 
            this.pbxVäljfärg.BackColor = System.Drawing.Color.Red;
            this.pbxVäljfärg.Location = new System.Drawing.Point(330, 12);
            this.pbxVäljfärg.Name = "pbxVäljfärg";
            this.pbxVäljfärg.Size = new System.Drawing.Size(137, 297);
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
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRGBFärg);
            this.Controls.Add(this.button1);
            this.Name = "Färg";
            this.Text = "Färg";
            this.Load += new System.EventHandler(this.Färg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVäljfärg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRGBFärg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.ComboBox cbxFärgAlternativ;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbxVäljfärg;
    }
}