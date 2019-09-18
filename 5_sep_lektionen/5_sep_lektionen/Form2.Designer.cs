namespace _5_sep_lektionen
{
    partial class Form2
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
            this.tbxKatet1 = new System.Windows.Forms.TextBox();
            this.btnKalkyleraArea = new System.Windows.Forms.Button();
            this.tbxHojd = new System.Windows.Forms.TextBox();
            this.tbxHypotenusa = new System.Windows.Forms.TextBox();
            this.lblTriangel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblHypotenusa = new System.Windows.Forms.Label();
            this.lblKatet2 = new System.Windows.Forms.Label();
            this.lblBas = new System.Windows.Forms.Label();
            this.lblHojd = new System.Windows.Forms.Label();
            this.lblKatet1 = new System.Windows.Forms.Label();
            this.tbxKatet2 = new System.Windows.Forms.TextBox();
            this.tbxBas = new System.Windows.Forms.TextBox();
            this.lblSvarArea = new System.Windows.Forms.Label();
            this.lblHypotenusalbl = new System.Windows.Forms.Label();
            this.lblHypotenusaSvar = new System.Windows.Forms.Label();
            this.lblKatet1lbl = new System.Windows.Forms.Label();
            this.lblKatet2lbl = new System.Windows.Forms.Label();
            this.lblKatet2Svar = new System.Windows.Forms.Label();
            this.lblKatet1Svar = new System.Windows.Forms.Label();
            this.btnKalkyleraKKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxKatet1
            // 
            this.tbxKatet1.Location = new System.Drawing.Point(332, 250);
            this.tbxKatet1.Name = "tbxKatet1";
            this.tbxKatet1.Size = new System.Drawing.Size(100, 20);
            this.tbxKatet1.TabIndex = 0;
            this.tbxKatet1.Text = "0";
            this.tbxKatet1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnKalkyleraArea
            // 
            this.btnKalkyleraArea.Location = new System.Drawing.Point(1182, 20);
            this.btnKalkyleraArea.Name = "btnKalkyleraArea";
            this.btnKalkyleraArea.Size = new System.Drawing.Size(96, 23);
            this.btnKalkyleraArea.TabIndex = 1;
            this.btnKalkyleraArea.Text = "Kalkylera Area";
            this.btnKalkyleraArea.UseVisualStyleBackColor = true;
            this.btnKalkyleraArea.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tbxHojd
            // 
            this.tbxHojd.Location = new System.Drawing.Point(332, 324);
            this.tbxHojd.Name = "tbxHojd";
            this.tbxHojd.Size = new System.Drawing.Size(100, 20);
            this.tbxHojd.TabIndex = 2;
            this.tbxHojd.Text = "0";
            // 
            // tbxHypotenusa
            // 
            this.tbxHypotenusa.Location = new System.Drawing.Point(904, 213);
            this.tbxHypotenusa.Name = "tbxHypotenusa";
            this.tbxHypotenusa.Size = new System.Drawing.Size(100, 20);
            this.tbxHypotenusa.TabIndex = 3;
            this.tbxHypotenusa.Text = "0";
            // 
            // lblTriangel
            // 
            this.lblTriangel.AutoSize = true;
            this.lblTriangel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriangel.Location = new System.Drawing.Point(643, 9);
            this.lblTriangel.Name = "lblTriangel";
            this.lblTriangel.Size = new System.Drawing.Size(191, 25);
            this.lblTriangel.TabIndex = 4;
            this.lblTriangel.Text = "Triangel Kalkylator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_5_sep_lektionen.Properties.Resources.Namnlös11;
            this.pictureBox1.Location = new System.Drawing.Point(251, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 545);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(1179, 46);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Area";
            this.lblArea.Click += new System.EventHandler(this.LblArea_Click);
            // 
            // lblHypotenusa
            // 
            this.lblHypotenusa.AutoSize = true;
            this.lblHypotenusa.Location = new System.Drawing.Point(901, 197);
            this.lblHypotenusa.Name = "lblHypotenusa";
            this.lblHypotenusa.Size = new System.Drawing.Size(64, 13);
            this.lblHypotenusa.TabIndex = 8;
            this.lblHypotenusa.Text = "Hypotenusa";
            // 
            // lblKatet2
            // 
            this.lblKatet2.AutoSize = true;
            this.lblKatet2.Location = new System.Drawing.Point(818, 496);
            this.lblKatet2.Name = "lblKatet2";
            this.lblKatet2.Size = new System.Drawing.Size(41, 13);
            this.lblKatet2.TabIndex = 9;
            this.lblKatet2.Text = "Katet 2";
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Location = new System.Drawing.Point(667, 496);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(25, 13);
            this.lblBas.TabIndex = 10;
            this.lblBas.Text = "Bas";
            // 
            // lblHojd
            // 
            this.lblHojd.AutoSize = true;
            this.lblHojd.Location = new System.Drawing.Point(329, 308);
            this.lblHojd.Name = "lblHojd";
            this.lblHojd.Size = new System.Drawing.Size(29, 13);
            this.lblHojd.TabIndex = 11;
            this.lblHojd.Text = "Höjd";
            // 
            // lblKatet1
            // 
            this.lblKatet1.AutoSize = true;
            this.lblKatet1.Location = new System.Drawing.Point(329, 234);
            this.lblKatet1.Name = "lblKatet1";
            this.lblKatet1.Size = new System.Drawing.Size(32, 13);
            this.lblKatet1.TabIndex = 12;
            this.lblKatet1.Text = "Katet";
            // 
            // tbxKatet2
            // 
            this.tbxKatet2.Location = new System.Drawing.Point(821, 512);
            this.tbxKatet2.Name = "tbxKatet2";
            this.tbxKatet2.Size = new System.Drawing.Size(100, 20);
            this.tbxKatet2.TabIndex = 13;
            this.tbxKatet2.Text = "0";
            // 
            // tbxBas
            // 
            this.tbxBas.Location = new System.Drawing.Point(670, 512);
            this.tbxBas.Name = "tbxBas";
            this.tbxBas.Size = new System.Drawing.Size(100, 20);
            this.tbxBas.TabIndex = 14;
            this.tbxBas.Text = "0";
            // 
            // lblSvarArea
            // 
            this.lblSvarArea.AutoSize = true;
            this.lblSvarArea.Location = new System.Drawing.Point(1252, 46);
            this.lblSvarArea.Name = "lblSvarArea";
            this.lblSvarArea.Size = new System.Drawing.Size(19, 13);
            this.lblSvarArea.TabIndex = 16;
            this.lblSvarArea.Text = "----";
            // 
            // lblHypotenusalbl
            // 
            this.lblHypotenusalbl.AutoSize = true;
            this.lblHypotenusalbl.Location = new System.Drawing.Point(1179, 125);
            this.lblHypotenusalbl.Name = "lblHypotenusalbl";
            this.lblHypotenusalbl.Size = new System.Drawing.Size(67, 13);
            this.lblHypotenusalbl.TabIndex = 17;
            this.lblHypotenusalbl.Text = "Hypotenusa:";
            // 
            // lblHypotenusaSvar
            // 
            this.lblHypotenusaSvar.AutoSize = true;
            this.lblHypotenusaSvar.Location = new System.Drawing.Point(1252, 125);
            this.lblHypotenusaSvar.Name = "lblHypotenusaSvar";
            this.lblHypotenusaSvar.Size = new System.Drawing.Size(19, 13);
            this.lblHypotenusaSvar.TabIndex = 18;
            this.lblHypotenusaSvar.Text = "----";
            // 
            // lblKatet1lbl
            // 
            this.lblKatet1lbl.AutoSize = true;
            this.lblKatet1lbl.Location = new System.Drawing.Point(1179, 138);
            this.lblKatet1lbl.Name = "lblKatet1lbl";
            this.lblKatet1lbl.Size = new System.Drawing.Size(41, 13);
            this.lblKatet1lbl.TabIndex = 19;
            this.lblKatet1lbl.Text = "Katet 1";
            // 
            // lblKatet2lbl
            // 
            this.lblKatet2lbl.AutoSize = true;
            this.lblKatet2lbl.Location = new System.Drawing.Point(1179, 151);
            this.lblKatet2lbl.Name = "lblKatet2lbl";
            this.lblKatet2lbl.Size = new System.Drawing.Size(41, 13);
            this.lblKatet2lbl.TabIndex = 20;
            this.lblKatet2lbl.Text = "Katet 2";
            // 
            // lblKatet2Svar
            // 
            this.lblKatet2Svar.AutoSize = true;
            this.lblKatet2Svar.Location = new System.Drawing.Point(1252, 151);
            this.lblKatet2Svar.Name = "lblKatet2Svar";
            this.lblKatet2Svar.Size = new System.Drawing.Size(19, 13);
            this.lblKatet2Svar.TabIndex = 21;
            this.lblKatet2Svar.Text = "----";
            // 
            // lblKatet1Svar
            // 
            this.lblKatet1Svar.AutoSize = true;
            this.lblKatet1Svar.Location = new System.Drawing.Point(1252, 138);
            this.lblKatet1Svar.Name = "lblKatet1Svar";
            this.lblKatet1Svar.Size = new System.Drawing.Size(19, 13);
            this.lblKatet1Svar.TabIndex = 22;
            this.lblKatet1Svar.Text = "----";
            // 
            // btnKalkyleraKKH
            // 
            this.btnKalkyleraKKH.Location = new System.Drawing.Point(1182, 99);
            this.btnKalkyleraKKH.Name = "btnKalkyleraKKH";
            this.btnKalkyleraKKH.Size = new System.Drawing.Size(96, 23);
            this.btnKalkyleraKKH.TabIndex = 23;
            this.btnKalkyleraKKH.Text = "Kalkylera KKH";
            this.btnKalkyleraKKH.UseVisualStyleBackColor = true;
            this.btnKalkyleraKKH.Click += new System.EventHandler(this.BtnKalkyleraKKH_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 904);
            this.Controls.Add(this.btnKalkyleraKKH);
            this.Controls.Add(this.lblKatet1Svar);
            this.Controls.Add(this.lblKatet2Svar);
            this.Controls.Add(this.lblKatet2lbl);
            this.Controls.Add(this.lblKatet1lbl);
            this.Controls.Add(this.lblHypotenusaSvar);
            this.Controls.Add(this.lblHypotenusalbl);
            this.Controls.Add(this.lblSvarArea);
            this.Controls.Add(this.tbxBas);
            this.Controls.Add(this.tbxKatet2);
            this.Controls.Add(this.lblKatet1);
            this.Controls.Add(this.lblHojd);
            this.Controls.Add(this.lblBas);
            this.Controls.Add(this.lblKatet2);
            this.Controls.Add(this.lblHypotenusa);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblTriangel);
            this.Controls.Add(this.tbxHypotenusa);
            this.Controls.Add(this.tbxHojd);
            this.Controls.Add(this.btnKalkyleraArea);
            this.Controls.Add(this.tbxKatet1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxKatet1;
        private System.Windows.Forms.Button btnKalkyleraArea;
        private System.Windows.Forms.TextBox tbxHojd;
        private System.Windows.Forms.TextBox tbxHypotenusa;
        private System.Windows.Forms.Label lblTriangel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblHypotenusa;
        private System.Windows.Forms.Label lblKatet2;
        private System.Windows.Forms.Label lblBas;
        private System.Windows.Forms.Label lblHojd;
        private System.Windows.Forms.Label lblKatet1;
        private System.Windows.Forms.TextBox tbxKatet2;
        private System.Windows.Forms.TextBox tbxBas;
        private System.Windows.Forms.Label lblSvarArea;
        private System.Windows.Forms.Label lblHypotenusalbl;
        private System.Windows.Forms.Label lblHypotenusaSvar;
        private System.Windows.Forms.Label lblKatet1lbl;
        private System.Windows.Forms.Label lblKatet2lbl;
        private System.Windows.Forms.Label lblKatet2Svar;
        private System.Windows.Forms.Label lblKatet1Svar;
        private System.Windows.Forms.Button btnKalkyleraKKH;
    }
}