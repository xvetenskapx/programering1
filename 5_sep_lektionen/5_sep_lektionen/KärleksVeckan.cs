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
            Färg färg = new Färg();
            färg.Show();
        }

        private void btnVäljFärg_Click(object sender, EventArgs e)
        {

        }

        void RitaHjärta(int Storlek, int[] Färg, int Tecken)
        {
            int i = 8;
            int y = 16;
            while (0 < i)
            {
                tbxHjärta.Text += 'A';
                while (0 < y)
                {
                    tbxHjärta.Text += " ";
                    y--;
                }
                tbxHjärta.Text += 'A';
                i--;
                y = 16 - 2;
            }
            tbxHjärta.Text = 'A' + "\t" + "\t" + "\t" + 'A'; 
            
        }

        private void btnRita_Click(object sender, EventArgs e)
        {
            RitaHjärta(1, Färg, 1);
        }
    }
}
