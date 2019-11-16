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
    public partial class Kapitel9 : Form
    {
        public Kapitel9()
        {
            InitializeComponent();
        }

        private void btnStarta_Click(object sender, EventArgs e)
        {
            int startvärde = int.Parse(tbxStartvärde.Text);
            int slutvärde = int.Parse(tbxSlutvärde.Text);
            while (startvärde < slutvärde + 1)
            {
                tbxUtdata.Text += startvärde + " " + "\r\n";
                startvärde++;
            }
        }

        private void btnVissa_Click(object sender, EventArgs e)
        {
            double korn = 1;
            int ruta = 1;
            while (ruta < 64+1)
            {
                tbxUtdata92.Text += "Ruta: " + ruta.ToString() + "\t" + "\t" + korn.ToString() + "\r\n";
                korn = korn * 2;
                ruta++;
            }
        }

        private void btnKor_Click(object sender, EventArgs e)
        {
            for (int n = int.Parse(tbxTal.Text); n <= 100; n += int.Parse(tbxTal.Text))
            {
                tbxTalTabell.Text += n.ToString() + "\t";
            }
        }

        private void tbxTal_TextChanged(object sender, EventArgs e)
        {
            tbxTalTabell.Text = "";
        }

        private void btnKor95_Click(object sender, EventArgs e)
        {
            for (int n = int.Parse(tbxStart.Text); n <= int.Parse(tbxSlut.Text); n += int.Parse(tbxSteg.Text))
            {
                tbxStegS.Text += n.ToString() + "\t";
            }

        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            tbxNivadata.Clear();

            for (int i = 1; i <= int.Parse(tbxNiva.Text) ; i++)
            {
                for (int j=1; j<= 10; j++)
                {
                    tbxNivadata.Text += (i * j).ToString() + "\t";
                }

                tbxNivadata.Text += "\r\n";
            }
        }

        private void btnvandom_Click(object sender, EventArgs e)
        {
            char[] tecken = new char[2];
            tecken[0] = char.Parse(tbxTecken1.Text);
            tecken[1] = char.Parse(tbxTecken2.Text);

            tbxTecken1.Text = "" + tecken[1];
            tbxTecken2.Text = "" + tecken[0];
        }

        private void btnFörskjut_Click(object sender, EventArgs e)
        {
            string[] strang = new string[3];
            strang[0] = tbxstrang1.Text;
            strang[1] = tbxstrang2.Text;
            strang[2] = tbxstrang3.Text;
            tbxstrang1.Text = strang[1];
            tbxstrang2.Text = strang[2];
            tbxstrang3.Text = strang[0];
        }
    }
}
