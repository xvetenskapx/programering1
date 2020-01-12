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
            this.tbxOctaDeci = new System.Windows.Forms.Button();
            this.btnDeciOcta = new System.Windows.Forms.Button();
            this.lblOctantalet = new System.Windows.Forms.Label();
            this.lblDecimalatalet = new System.Windows.Forms.Label();
            this.tbxOctantalet1 = new System.Windows.Forms.TextBox();
            this.tbxDecimaltalet1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDecimalatalet2 = new System.Windows.Forms.Label();
            this.tbxOctatalet2 = new System.Windows.Forms.TextBox();
            this.tbxDeciamltalet2 = new System.Windows.Forms.TextBox();
            this.lblBinäratalet3 = new System.Windows.Forms.Label();
            this.lblDecimaltalet3 = new System.Windows.Forms.Label();
            this.tbxBinäratalet3 = new System.Windows.Forms.TextBox();
            this.tbxDecimaltalet3 = new System.Windows.Forms.TextBox();
            this.btnDeciBi = new System.Windows.Forms.Button();
            this.lblDecimalatalet4 = new System.Windows.Forms.Label();
            this.lblBinäratalet4 = new System.Windows.Forms.Label();
            this.tbxDecimaltalet4 = new System.Windows.Forms.TextBox();
            this.tbxBinäratalet4 = new System.Windows.Forms.TextBox();
            this.btnBiDeci = new System.Windows.Forms.Button();
            this.lblRuta1 = new System.Windows.Forms.Label();
            this.lblRuta2 = new System.Windows.Forms.Label();
            this.lblRuta3 = new System.Windows.Forms.Label();
            this.lblRuta4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Location = new System.Drawing.Point(13, 255);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(92, 23);
            this.btnBeräkna.TabIndex = 0;
            this.btnBeräkna.Text = "Binärt>Decimal";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.BtnBeräkna_Click);
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(13, 284);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxTal.Size = new System.Drawing.Size(100, 20);
            this.tbxTal.TabIndex = 1;
            this.tbxTal.Text = "00000";
            // 
            // lblTalbas
            // 
            this.lblTalbas.AutoSize = true;
            this.lblTalbas.Location = new System.Drawing.Point(51, 307);
            this.lblTalbas.Name = "lblTalbas";
            this.lblTalbas.Size = new System.Drawing.Size(16, 13);
            this.lblTalbas.TabIndex = 2;
            this.lblTalbas.Text = "---";
            // 
            // lblSvarD
            // 
            this.lblSvarD.AutoSize = true;
            this.lblSvarD.Location = new System.Drawing.Point(13, 307);
            this.lblSvarD.Name = "lblSvarD";
            this.lblSvarD.Size = new System.Drawing.Size(32, 13);
            this.lblSvarD.TabIndex = 3;
            this.lblSvarD.Text = "Svar:";
            // 
            // tbxOctaDeci
            // 
            this.tbxOctaDeci.Location = new System.Drawing.Point(192, 79);
            this.tbxOctaDeci.Name = "tbxOctaDeci";
            this.tbxOctaDeci.Size = new System.Drawing.Size(168, 23);
            this.tbxOctaDeci.TabIndex = 116;
            this.tbxOctaDeci.Text = "Octa - Deci";
            this.tbxOctaDeci.UseVisualStyleBackColor = true;
            this.tbxOctaDeci.Click += new System.EventHandler(this.tbxOctaDeci_Click);
            // 
            // btnDeciOcta
            // 
            this.btnDeciOcta.Location = new System.Drawing.Point(13, 79);
            this.btnDeciOcta.Name = "btnDeciOcta";
            this.btnDeciOcta.Size = new System.Drawing.Size(168, 23);
            this.btnDeciOcta.TabIndex = 115;
            this.btnDeciOcta.Text = "Deci - Octa";
            this.btnDeciOcta.UseVisualStyleBackColor = true;
            this.btnDeciOcta.Click += new System.EventHandler(this.btnDeciOcta_Click);
            // 
            // lblOctantalet
            // 
            this.lblOctantalet.AutoSize = true;
            this.lblOctantalet.Location = new System.Drawing.Point(10, 56);
            this.lblOctantalet.Name = "lblOctantalet";
            this.lblOctantalet.Size = new System.Drawing.Size(56, 13);
            this.lblOctantalet.TabIndex = 114;
            this.lblOctantalet.Text = "Octantalet";
            // 
            // lblDecimalatalet
            // 
            this.lblDecimalatalet.AutoSize = true;
            this.lblDecimalatalet.Location = new System.Drawing.Point(10, 30);
            this.lblDecimalatalet.Name = "lblDecimalatalet";
            this.lblDecimalatalet.Size = new System.Drawing.Size(65, 13);
            this.lblDecimalatalet.TabIndex = 113;
            this.lblDecimalatalet.Text = "Decimaltalet";
            // 
            // tbxOctantalet1
            // 
            this.tbxOctantalet1.Location = new System.Drawing.Point(12, 108);
            this.tbxOctantalet1.Name = "tbxOctantalet1";
            this.tbxOctantalet1.ReadOnly = true;
            this.tbxOctantalet1.Size = new System.Drawing.Size(169, 20);
            this.tbxOctantalet1.TabIndex = 111;
            // 
            // tbxDecimaltalet1
            // 
            this.tbxDecimaltalet1.Location = new System.Drawing.Point(81, 27);
            this.tbxDecimaltalet1.Name = "tbxDecimaltalet1";
            this.tbxDecimaltalet1.Size = new System.Drawing.Size(100, 20);
            this.tbxDecimaltalet1.TabIndex = 110;
            this.tbxDecimaltalet1.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Octantalet";
            // 
            // lblDecimalatalet2
            // 
            this.lblDecimalatalet2.AutoSize = true;
            this.lblDecimalatalet2.Location = new System.Drawing.Point(189, 56);
            this.lblDecimalatalet2.Name = "lblDecimalatalet2";
            this.lblDecimalatalet2.Size = new System.Drawing.Size(65, 13);
            this.lblDecimalatalet2.TabIndex = 119;
            this.lblDecimalatalet2.Text = "Decimaltalet";
            // 
            // tbxOctatalet2
            // 
            this.tbxOctatalet2.Location = new System.Drawing.Point(260, 27);
            this.tbxOctatalet2.Name = "tbxOctatalet2";
            this.tbxOctatalet2.Size = new System.Drawing.Size(100, 20);
            this.tbxOctatalet2.TabIndex = 118;
            this.tbxOctatalet2.Text = "87922";
            // 
            // tbxDeciamltalet2
            // 
            this.tbxDeciamltalet2.Location = new System.Drawing.Point(260, 53);
            this.tbxDeciamltalet2.Name = "tbxDeciamltalet2";
            this.tbxDeciamltalet2.ReadOnly = true;
            this.tbxDeciamltalet2.Size = new System.Drawing.Size(100, 20);
            this.tbxDeciamltalet2.TabIndex = 117;
            // 
            // lblBinäratalet3
            // 
            this.lblBinäratalet3.AutoSize = true;
            this.lblBinäratalet3.Location = new System.Drawing.Point(369, 56);
            this.lblBinäratalet3.Name = "lblBinäratalet3";
            this.lblBinäratalet3.Size = new System.Drawing.Size(57, 13);
            this.lblBinäratalet3.TabIndex = 125;
            this.lblBinäratalet3.Text = "Binäratalet";
            // 
            // lblDecimaltalet3
            // 
            this.lblDecimaltalet3.AutoSize = true;
            this.lblDecimaltalet3.Location = new System.Drawing.Point(369, 30);
            this.lblDecimaltalet3.Name = "lblDecimaltalet3";
            this.lblDecimaltalet3.Size = new System.Drawing.Size(65, 13);
            this.lblDecimaltalet3.TabIndex = 124;
            this.lblDecimaltalet3.Text = "Decimaltalet";
            // 
            // tbxBinäratalet3
            // 
            this.tbxBinäratalet3.Location = new System.Drawing.Point(440, 53);
            this.tbxBinäratalet3.Name = "tbxBinäratalet3";
            this.tbxBinäratalet3.ReadOnly = true;
            this.tbxBinäratalet3.Size = new System.Drawing.Size(100, 20);
            this.tbxBinäratalet3.TabIndex = 123;
            this.tbxBinäratalet3.Text = "87922";
            // 
            // tbxDecimaltalet3
            // 
            this.tbxDecimaltalet3.Location = new System.Drawing.Point(440, 27);
            this.tbxDecimaltalet3.Name = "tbxDecimaltalet3";
            this.tbxDecimaltalet3.Size = new System.Drawing.Size(100, 20);
            this.tbxDecimaltalet3.TabIndex = 122;
            this.tbxDecimaltalet3.Text = "0";
            // 
            // btnDeciBi
            // 
            this.btnDeciBi.Location = new System.Drawing.Point(372, 79);
            this.btnDeciBi.Name = "btnDeciBi";
            this.btnDeciBi.Size = new System.Drawing.Size(168, 23);
            this.btnDeciBi.TabIndex = 121;
            this.btnDeciBi.Text = "Deci - Bi";
            this.btnDeciBi.UseVisualStyleBackColor = true;
            this.btnDeciBi.Click += new System.EventHandler(this.btnDeciBi_Click);
            // 
            // lblDecimalatalet4
            // 
            this.lblDecimalatalet4.AutoSize = true;
            this.lblDecimalatalet4.Location = new System.Drawing.Point(549, 56);
            this.lblDecimalatalet4.Name = "lblDecimalatalet4";
            this.lblDecimalatalet4.Size = new System.Drawing.Size(65, 13);
            this.lblDecimalatalet4.TabIndex = 130;
            this.lblDecimalatalet4.Text = "Decimaltalet";
            // 
            // lblBinäratalet4
            // 
            this.lblBinäratalet4.AutoSize = true;
            this.lblBinäratalet4.Location = new System.Drawing.Point(549, 30);
            this.lblBinäratalet4.Name = "lblBinäratalet4";
            this.lblBinäratalet4.Size = new System.Drawing.Size(57, 13);
            this.lblBinäratalet4.TabIndex = 129;
            this.lblBinäratalet4.Text = "Binäratalet";
            // 
            // tbxDecimaltalet4
            // 
            this.tbxDecimaltalet4.Location = new System.Drawing.Point(620, 53);
            this.tbxDecimaltalet4.Name = "tbxDecimaltalet4";
            this.tbxDecimaltalet4.ReadOnly = true;
            this.tbxDecimaltalet4.Size = new System.Drawing.Size(100, 20);
            this.tbxDecimaltalet4.TabIndex = 128;
            // 
            // tbxBinäratalet4
            // 
            this.tbxBinäratalet4.Location = new System.Drawing.Point(620, 27);
            this.tbxBinäratalet4.Name = "tbxBinäratalet4";
            this.tbxBinäratalet4.Size = new System.Drawing.Size(100, 20);
            this.tbxBinäratalet4.TabIndex = 127;
            this.tbxBinäratalet4.Text = "1101";
            // 
            // btnBiDeci
            // 
            this.btnBiDeci.Location = new System.Drawing.Point(552, 79);
            this.btnBiDeci.Name = "btnBiDeci";
            this.btnBiDeci.Size = new System.Drawing.Size(168, 23);
            this.btnBiDeci.TabIndex = 126;
            this.btnBiDeci.Text = "Bi - Deci";
            this.btnBiDeci.UseVisualStyleBackColor = true;
            this.btnBiDeci.Click += new System.EventHandler(this.btnBiDeci_Click);
            // 
            // lblRuta1
            // 
            this.lblRuta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRuta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRuta1.Location = new System.Drawing.Point(81, 9);
            this.lblRuta1.Name = "lblRuta1";
            this.lblRuta1.Size = new System.Drawing.Size(30, 15);
            this.lblRuta1.TabIndex = 131;
            this.lblRuta1.Text = "1";
            this.lblRuta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRuta2
            // 
            this.lblRuta2.BackColor = System.Drawing.SystemColors.Control;
            this.lblRuta2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRuta2.Location = new System.Drawing.Point(261, 9);
            this.lblRuta2.Name = "lblRuta2";
            this.lblRuta2.Size = new System.Drawing.Size(30, 15);
            this.lblRuta2.TabIndex = 132;
            this.lblRuta2.Text = "2";
            this.lblRuta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRuta3
            // 
            this.lblRuta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRuta3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRuta3.Location = new System.Drawing.Point(441, 9);
            this.lblRuta3.Name = "lblRuta3";
            this.lblRuta3.Size = new System.Drawing.Size(30, 15);
            this.lblRuta3.TabIndex = 133;
            this.lblRuta3.Text = "3";
            this.lblRuta3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRuta4
            // 
            this.lblRuta4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRuta4.Location = new System.Drawing.Point(621, 9);
            this.lblRuta4.Name = "lblRuta4";
            this.lblRuta4.Size = new System.Drawing.Size(30, 15);
            this.lblRuta4.TabIndex = 134;
            this.lblRuta4.Text = "4";
            this.lblRuta4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Talbas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRuta4);
            this.Controls.Add(this.lblRuta3);
            this.Controls.Add(this.lblRuta2);
            this.Controls.Add(this.lblRuta1);
            this.Controls.Add(this.lblDecimalatalet4);
            this.Controls.Add(this.lblBinäratalet4);
            this.Controls.Add(this.tbxDecimaltalet4);
            this.Controls.Add(this.tbxBinäratalet4);
            this.Controls.Add(this.btnBiDeci);
            this.Controls.Add(this.lblBinäratalet3);
            this.Controls.Add(this.lblDecimaltalet3);
            this.Controls.Add(this.tbxBinäratalet3);
            this.Controls.Add(this.tbxDecimaltalet3);
            this.Controls.Add(this.btnDeciBi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDecimalatalet2);
            this.Controls.Add(this.tbxOctatalet2);
            this.Controls.Add(this.tbxDeciamltalet2);
            this.Controls.Add(this.tbxOctaDeci);
            this.Controls.Add(this.btnDeciOcta);
            this.Controls.Add(this.lblOctantalet);
            this.Controls.Add(this.lblDecimalatalet);
            this.Controls.Add(this.tbxOctantalet1);
            this.Controls.Add(this.tbxDecimaltalet1);
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
        private System.Windows.Forms.Button tbxOctaDeci;
        private System.Windows.Forms.Button btnDeciOcta;
        private System.Windows.Forms.Label lblOctantalet;
        private System.Windows.Forms.Label lblDecimalatalet;
        private System.Windows.Forms.TextBox tbxOctantalet1;
        private System.Windows.Forms.TextBox tbxDecimaltalet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDecimalatalet2;
        private System.Windows.Forms.TextBox tbxOctatalet2;
        private System.Windows.Forms.TextBox tbxDeciamltalet2;
        private System.Windows.Forms.Label lblBinäratalet3;
        private System.Windows.Forms.Label lblDecimaltalet3;
        private System.Windows.Forms.TextBox tbxBinäratalet3;
        private System.Windows.Forms.TextBox tbxDecimaltalet3;
        private System.Windows.Forms.Button btnDeciBi;
        private System.Windows.Forms.Label lblDecimalatalet4;
        private System.Windows.Forms.Label lblBinäratalet4;
        private System.Windows.Forms.TextBox tbxDecimaltalet4;
        private System.Windows.Forms.TextBox tbxBinäratalet4;
        private System.Windows.Forms.Button btnBiDeci;
        private System.Windows.Forms.Label lblRuta1;
        private System.Windows.Forms.Label lblRuta2;
        private System.Windows.Forms.Label lblRuta3;
        private System.Windows.Forms.Label lblRuta4;
    }
}