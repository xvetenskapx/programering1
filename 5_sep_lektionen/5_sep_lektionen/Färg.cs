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
        PictureBox pbx;
        int[] FärgTest = new int[3];

        int[] stefan;
	
        public Färg()
        {
            InitializeComponent();
            
        }

        public Färg(PictureBox p)
        {
            InitializeComponent();
            pbx = p;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Visar hur det funkar
            KärleksVeckan.tal = 3;

            int t = KärleksVeckan.tal;

            KärleksVeckan.ändraText("stefan");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                KärleksVeckan.Färg[0] = FärgTest[0];
            }

            pbxVäljfärg.BackColor = Color.FromArgb(FärgTest[0], FärgTest[1], FärgTest[2]);


            pbx.BackColor = Color.FromArgb(FärgTest[0], FärgTest[1], FärgTest[2]);


            this.Close();
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
                FärgTest[1] = 0;
                FärgTest[2] = 0;
                pbxVäljfärg.BackColor = Color.FromArgb(255, 0, 0);
            }

            //Grön
            else if (cbxFärgAlternativ.SelectedIndex == 1)
            {
                FärgTest[0] = 0;
                FärgTest[1] = 255;
                FärgTest[2] = 0;
                pbxVäljfärg.BackColor = Color.FromArgb(0, 255, 0);
            }

            //Blå
            else if (cbxFärgAlternativ.SelectedIndex == 2)
            {
                FärgTest[0] = 0;
                FärgTest[1] = 0;
                FärgTest[2] = 255;
                pbxVäljfärg.BackColor = Color.FromArgb(0, 0, 255);
            }

            //Gul
            else if (cbxFärgAlternativ.SelectedIndex == 3)
            {
                FärgTest[0] = 255;
                FärgTest[1] = 255;
                FärgTest[2] = 0;
                pbxVäljfärg.BackColor = Color.FromArgb(255, 255, 0);
            }

            //Cayen
            else if (cbxFärgAlternativ.SelectedIndex == 4)
            {
                FärgTest[0] = 0;
                FärgTest[1] = 255;
                FärgTest[2] = 255;
                pbxVäljfärg.BackColor = Color.FromArgb(0, 255, 255);
            }

            //Rosa
            else if (cbxFärgAlternativ.SelectedIndex == 5)
            {
                FärgTest[0] = 255;
                FärgTest[1] = 0;
                FärgTest[2] = 255;
                pbxVäljfärg.BackColor = Color.FromArgb(255, 0, 255);
            }

            //Orange
            else if (cbxFärgAlternativ.SelectedIndex == 6)
            {
                FärgTest[0] = 255;
                FärgTest[1] = 126;
                FärgTest[2] = 64;
                pbxVäljfärg.BackColor = Color.FromArgb(255, 126, 64);
            }

            //Lila
            else if (cbxFärgAlternativ.SelectedIndex == 7)
            {
                FärgTest[0] = 128;
                FärgTest[1] = 0;
                FärgTest[2] = 255;
                pbxVäljfärg.BackColor = Color.FromArgb(128, 0, 255);
            }

            //Svart
            else if (cbxFärgAlternativ.SelectedIndex == 8)
            {
                FärgTest[0] = 0;
                FärgTest[1] = 0;
                FärgTest[2] = 0;
                pbxVäljfärg.BackColor = Color.FromArgb(0, 0, 0);
            }

            //Vit
            else if (cbxFärgAlternativ.SelectedIndex == 9)
            {
                FärgTest[0] = 255;
                FärgTest[1] = 255;
                FärgTest[2] = 255;
                pbxVäljfärg.BackColor = Color.FromArgb(255, 255, 255);
            }

            //Fel
            else
            {

            }
            tbxRed.Text = FärgTest[0].ToString();
            tbxGreen.Text = FärgTest[1].ToString();
            tbxBlue.Text = FärgTest[2].ToString();
        }

        private void btnRGBFärg_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxRed.Text) > 255)
            {
                tbxRed.Text = "Förstort Tal";
            }
            else if (int.Parse(tbxGreen.Text) > 255)
            {
                tbxGreen.Text = "Förstort Tal";
            }
            else if (int.Parse(tbxBlue.Text) > 255)
            {
                tbxBlue.Text = "Förstort Tal";
            }
            else
            {
                FärgTest[0] = int.Parse(tbxRed.Text);
                FärgTest[1] = int.Parse(tbxGreen.Text);
                FärgTest[2] = int.Parse(tbxBlue.Text);
                pbxVäljfärg.BackColor = Color.FromArgb(FärgTest[0], FärgTest[1], FärgTest[2]);
            }
            
        }
    }
}
