using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_sep_lektionen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblArea_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            double Bas = double.Parse(tbxBas.Text);
            double Hojd = double.Parse(tbxHojd.Text);
            double Area = (Bas * Hojd) / 2;
            lblSvarArea.Text = Area.ToString();
        }

        private void BtnKalkyleraKKH_Click(object sender, EventArgs e)
        {
            double katet1 = double.Parse(tbxKatet1.Text);
            double katet2 = double.Parse(tbxKatet2.Text);
            double hypotenusa = double.Parse(tbxHypotenusa.Text);

            //beräkna Hypotenusa
            double hypotenusaS1 = (katet1 * katet1 + katet2 * katet2);
            double hypotenusaS2 = Math.Sqrt(hypotenusaS1);
            lblHypotenusaSvar.Text = hypotenusaS2.ToString();

            //beräkna Katet1
            double Katet1S1 = (hypotenusa * hypotenusa - katet2 * katet2);
            double Katet1S2 = Math.Sqrt(Katet1S1);
            lblKatet1Svar.Text = Katet1S2.ToString();

            //beräkna Katet2
            double Katet2S1 = (hypotenusa * hypotenusa - katet1 * katet1);
            double Katet2S2 = Math.Sqrt(Katet1S1);
            lblKatet2Svar.Text = Katet2S2.ToString();
        }
    }
}
