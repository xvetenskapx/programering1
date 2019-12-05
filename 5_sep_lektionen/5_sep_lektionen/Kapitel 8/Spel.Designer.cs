namespace _5_sep_lektionen
{
    partial class Spel
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
            this.btnGissatalet = new System.Windows.Forms.Button();
            this.btnstensaxpåse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGissatalet
            // 
            this.btnGissatalet.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGissatalet.Location = new System.Drawing.Point(12, 12);
            this.btnGissatalet.Name = "btnGissatalet";
            this.btnGissatalet.Size = new System.Drawing.Size(300, 200);
            this.btnGissatalet.TabIndex = 0;
            this.btnGissatalet.Text = "Gissa Talet";
            this.btnGissatalet.UseVisualStyleBackColor = true;
            this.btnGissatalet.Click += new System.EventHandler(this.btnGissatalet_Click);
            // 
            // btnstensaxpåse
            // 
            this.btnstensaxpåse.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstensaxpåse.Location = new System.Drawing.Point(342, 12);
            this.btnstensaxpåse.Name = "btnstensaxpåse";
            this.btnstensaxpåse.Size = new System.Drawing.Size(300, 200);
            this.btnstensaxpåse.TabIndex = 1;
            this.btnstensaxpåse.Text = "StenSaxPåse";
            this.btnstensaxpåse.UseVisualStyleBackColor = true;
            this.btnstensaxpåse.Click += new System.EventHandler(this.btnstensaxpåse_Click);
            // 
            // Spel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 232);
            this.Controls.Add(this.btnstensaxpåse);
            this.Controls.Add(this.btnGissatalet);
            this.Name = "Spel";
            this.Text = "Spel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGissatalet;
        private System.Windows.Forms.Button btnstensaxpåse;
    }
}