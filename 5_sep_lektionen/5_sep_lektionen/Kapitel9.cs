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
        Random generator = new Random();
        int[] TAL;
        public Kapitel9()
        {
            InitializeComponent();
            lbxMeny.Items.Add("Medelvärde");
            lbxMeny.SelectedIndex = 0;
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

        private void btnGenerera_Click(object sender, EventArgs e)
        {
            tbxLista.Clear();

            int[] AntalPrickar = new int[6];

            int antalTal        =int.Parse(tbxAntal.Text);
            TAL                 =new int[antalTal];

            for (int i = 0; i < TAL.Length; i++)
            {
                TAL[i] = generator.Next(1, 7);
                tbxLista.AppendText(TAL[i] + "\r\n");
                switch (TAL[i])
                {
                    case 1:
                        AntalPrickar[0]++;
                        break;

                    case 2:
                        AntalPrickar[1]++;
                        break;

                    case 3:
                        AntalPrickar[2]++;
                        break;

                    case 4:
                        AntalPrickar[3]++;
                        break;

                    case 5:
                        AntalPrickar[4]++;
                        break;

                    case 6:
                        AntalPrickar[5]++;
                        break;

                    default:
                        break;
                }
            }

            lblantal1.Text = AntalPrickar[0].ToString();
            lblAntal2.Text = AntalPrickar[1].ToString();
            lblAntal3.Text = AntalPrickar[2].ToString();
            lblAntal4.Text = AntalPrickar[3].ToString();
            lblAntal5.Text = AntalPrickar[4].ToString();
            lblAntal6.Text = AntalPrickar[5].ToString();

            gbxBeräkna.Enabled = true;
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            double summa = 0;

            for (int i = 0; i < TAL.Length; i++)    summa += + TAL[i];

            if      (lbxMeny.SelectedIndex == 0)    tbxdata.Text = "" + summa;
            else if (lbxMeny.SelectedIndex == 1)    tbxdata.Text = "" + summa / TAL.Length;
        }

        private void tbxAntal_TextChanged(object sender, EventArgs e)
        {
            tbxLista.Clear();
            tbxdata.Clear();
        }
    }
}
