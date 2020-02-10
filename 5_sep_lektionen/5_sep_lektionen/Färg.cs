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
    public partial class Färg : Form
    {

        int[] FärgTest = new int[3];

        int[] stefan;
	
        public Färg()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KärleksVeckan.tal = 3;

            int t = KärleksVeckan.tal;

            KärleksVeckan.ändraText("stefan");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
        }

        private void Färg_Load(object sender, EventArgs e)
        {
            //cbxFärgAlternativ.Items.Add("Röd");

        }

        private void cbxFärgAlternativ_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Röd
            if (cbxFärgAlternativ.SelectedIndex == 0)
            {
                FärgTest[0] = 255;
            }

            //Grön
            else if (cbxFärgAlternativ.SelectedIndex == 1)
            {
                FärgTest[1] = 255;
            }

            //Blå
            else if (cbxFärgAlternativ.SelectedIndex == 2)
            {
                FärgTest[2] = 255;
            }

            //Gul
            else if (cbxFärgAlternativ.SelectedIndex == 3)
            {
                FärgTest[0] = 255;
                FärgTest[1] = 255;
            }

            //Cayen
            else if (cbxFärgAlternativ.SelectedIndex == 4)
            {
                FärgTest[1] = 255;
                FärgTest[2] = 255;
            }

            //Rosa
            else if (cbxFärgAlternativ.SelectedIndex == 1)
            {
                FärgTest[0] = 255;
                FärgTest[1] = 126;
                FärgTest[2] = 64;
            }

            //Orange
            else if (cbxFärgAlternativ.SelectedIndex == 5)
            {
                FärgTest[0] = 255;
                FärgTest[2] = 255;
            }

            //Lila
            else if (cbxFärgAlternativ.SelectedIndex == 6)
            {
                FärgTest[0] = 128;
                FärgTest[2] = 255;
            }

            //Svart
            else if (cbxFärgAlternativ.SelectedIndex == 7)
            {
                
            }

            //Vit
            else if (cbxFärgAlternativ.SelectedIndex == 8)
            {
                FärgTest[0] = 255;
                FärgTest[1] = 255;
                FärgTest[2] = 255;
            }

            //Fel
            else
            {

            }
        }
    }
}
