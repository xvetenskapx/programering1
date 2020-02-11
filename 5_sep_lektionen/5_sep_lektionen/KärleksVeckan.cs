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
    public partial class KärleksVeckan : Form
    {
        public static int tal = 1;
        public static int[] Färg = new int[3];
        public KärleksVeckan()
        {
            InitializeComponent();
        }

        private void KärleksVeckan_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }


        public static void ändraText(string s)
        {
            //tbxNamn1.Text = s;
        }

        private void pbxVäljfärg_Click(object sender, EventArgs e)
        {

        }

        private void pbxVäljfärg_DoubleClick(object sender, EventArgs e)
        {
            Färg färg = new Färg(this.pbxVäljfärg);
            färg.Show();

           
        }

        public void bytFärg(Color c)
        {
            pbxVäljfärg.BackColor = c;
        }

        private void btnVäljFärg_Click(object sender, EventArgs e)
        {

        }


        void RitaHjärtaÖver(int Storlek, int[] Färg, int Tecken)
        {
            for (int i = 0; i < 13; i++)
            {
                tbxHjärta.Text += "  ";
                if (i==2)
                {
                    tbxHjärta.Text += 'A';
                }
            }

            for (int h = 0; h < 16; h++)
            {
                //tbxHjärta.Text +=
            }
            

            //for (int t = 0; t < 10; t++)
            //{
            //    tbxHjärta.Text += "  ";
            //}

            tbxHjärta.Text += 'A' + "\r\n";
        }

        void RitaHjärtaUnder(int Storlek, int[] Färg, int Tecken)
        {
            int t = 4;
            int n = 32;
            int i = 8;
            int y = 32;
            int h = 0;
            while (0 < i)
            {

                for (int i1 = 0; i1 < h; i1++)
                {
                    tbxHjärta.Text += "  ";
                }

                tbxHjärta.Text += 'A';

                while (0 < y)
                {
                    tbxHjärta.Text += "  ";
                    y = y-2;
                }

                tbxHjärta.Text += 'A' + "\r\n";
                i--;
                y = n - t;
                t = t + 4;
                h++;
            }
            for (int i1 = 0; i1 < 8; i1++)
            {
                tbxHjärta.Text += "  ";
            }
            tbxHjärta.Text += " " + 'A';
        }

        private void btnRita_Click(object sender, EventArgs e)
        {
            
            RitaHjärtaÖver(1, Färg, 1);
            RitaHjärtaUnder(1, Färg, 1);
        }
    }
}
