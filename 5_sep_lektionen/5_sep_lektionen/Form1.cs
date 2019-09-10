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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TbxTal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxTal2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxTal3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxTal4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnKvadrera_Click(object sender, EventArgs e)
        {
            //Kvadrerings Koden
            int Tal1 = int.Parse(tbxTal1.Text);
            int Kvadrat1 = Tal1 * Tal1;
            string SvarK1 = Kvadrat1.ToString();
            lblKvadrat1.Text = SvarK1;

            int Tal2 = int.Parse(tbxTal2.Text);
            int Kvadrat2 = Tal2 * Tal2;
            string SvarK2 = Kvadrat2.ToString();
            lblKvadrat2.Text = SvarK2;

            int Tal3 = int.Parse(tbxTal3.Text);
            int Kvadrat3 = Tal3 * Tal3;
            string SvarK3 = Kvadrat3.ToString();
            lblKvadrat3.Text = SvarK3;

            int Tal4 = int.Parse(tbxTal4.Text);
            int Kvadrat4 = Tal4 * Tal4;
            string SvarK4 = Kvadrat4.ToString();
            lblKvadrat4.Text = SvarK4;

            //Sumerings koden
            int Summa12 = Tal1 + Tal2;
            string Svarsum12 = Summa12.ToString();
            lblSum12.Text = Svarsum12;

            int Summa123 = Tal1 + Tal2 + Tal3;
            string Svarsum123 = Summa123.ToString();
            lblsum123.Text = Svarsum123;

            int Summa1234 = Tal1 + Tal2 + Tal3 + Tal4;
            string Svarsum1234 = Summa1234.ToString();
            lblSum1234.Text = Svarsum1234;

            //MedelVärde Koden
            int Medel2 = (Tal1 + Tal2) / 2;
            string Medelsum2 = Medel2.ToString();
            lblMedel12.Text = Medelsum2;

            int Medel3 = (Tal1 + Tal2 + Tal3) / 3;
            string Medelsum3 = Medel3.ToString();
            lblMedel123.Text = Medelsum3;

            int Medel4 = (Tal1 + Tal2 + Tal3 + Tal4) / 4;
            string Medelsum4 = Medel4.ToString();
            lblMedel1234.Text = Medelsum4;
        }
    }
}
