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
        int[] AntalPrickar = new int[6];
        int[] Längd = new int[6];
        public Kapitel9()
        {
            InitializeComponent();
            lbxMeny.Items.Add("Medelvärde");
            lbxMeny.SelectedIndex = 0;
            lbxMeny910.SelectedIndex = 0;
          
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush penselSvart = new SolidBrush(Color.Black);
            SolidBrush penselRöd = new SolidBrush(Color.Red);
            SolidBrush penselGul = new SolidBrush(Color.Yellow);
            SolidBrush penselGrön = new SolidBrush(Color.Green);
            SolidBrush penselBlå = new SolidBrush(Color.Blue);
            SolidBrush penselViolet = new SolidBrush(Color.DarkViolet);

            //1
            g.FillRectangle(penselSvart, 824, 939 - Längd[0], 75, Längd[0]);

            //2
            g.FillRectangle(penselRöd, 905, 939 - Längd[1], 75, Längd[1]);

            //3
            g.FillRectangle(penselGul, 986, 939 - Längd[2], 75, Längd[2]);

            //4
            g.FillRectangle(penselGrön, 1067, 939 - Längd[3], 75, Längd[3]);

            //5
            g.FillRectangle(penselBlå, 1148, 939 - Längd[4], 75, Längd[4]);

            //6
            g.FillRectangle(penselViolet, 1229, 939 - Längd[5], 75, Längd[5]);

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
            AntalPrickar[0]= 0;
            AntalPrickar[1]= 0;
            AntalPrickar[2]= 0;
            AntalPrickar[3]= 0;
            AntalPrickar[4]= 0;
            AntalPrickar[5]= 0;


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

            int skala = int.Parse(tbxstappelskala.Text);

            Längd[0] = AntalPrickar[0] / skala;
            Längd[1] = AntalPrickar[1] / skala;
            Längd[2] = AntalPrickar[2] / skala;
            Längd[3] = AntalPrickar[3] / skala;
            Längd[4] = AntalPrickar[4] / skala;
            Längd[5] = AntalPrickar[5] / skala;

            lblEttor97.Location = new Point(lblEttor97.Location.X, 939 - Längd[0] - 23);
            lblEttor97.Text = AntalPrickar[0].ToString();

            lblTvåor97.Location = new Point(lblTvåor97.Location.X, 939 - Längd[1] - 23);
            lblTvåor97.Text = AntalPrickar[1].ToString();

            lblTreor97.Location = new Point(lblTreor97.Location.X, 939 - Längd[2] - 23);
            lblTreor97.Text = AntalPrickar[2].ToString();

            lblFyror97.Location = new Point(lblFyror97.Location.X, 939 - Längd[3] - 23);
            lblFyror97.Text = AntalPrickar[3].ToString();

            lblFemor97.Location = new Point(lblFemor97.Location.X, 939 - Längd[4] - 23);
            lblFemor97.Text = AntalPrickar[4].ToString();

            lblSexor97.Location = new Point(lblSexor97.Location.X, 939 - Längd[5] - 23);
            lblSexor97.Text = AntalPrickar[5].ToString();

            Invalidate();
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

        private void btnGenerera910_Click(object sender, EventArgs e)
        {
            tbxRad1.Clear();
            tbxRad2.Clear();
            tbxRad3.Clear();
            Random tärning = new Random();
            //Rad 1
            int[] Rad1 = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Rad1[i] = tärning.Next(1, 21);
                tbxRad1.Text += Rad1[i].ToString() + "\r\n";
            }

            //Rad 2
            int[] Rad2 = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Rad2[i] = tärning.Next(1, 21);
                tbxRad2.Text += Rad2[i].ToString() + "\r\n";
            }

            //Rad 3
            int[] Rad3 = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Rad3[i] = tärning.Next(1, 21);
                tbxRad3.Text += Rad3[i].ToString() + "\r\n";
            }
        }

        private void btnVälj_Click(object sender, EventArgs e)
        {
            tbxVal.Clear();
            if (lbxMeny910.SelectedIndex == 0)
                tbxVal.Text = tbxRad1.Text;

            else if (lbxMeny910.SelectedIndex == 1)
                tbxVal.Text = tbxRad2.Text;

            else if (lbxMeny910.SelectedIndex == 2)
                tbxVal.Text = tbxRad3.Text;

            else
                MessageBox.Show("Oväntat Fel", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Kapitel9_Load(object sender, EventArgs e)
        {

        }

        private void lblBeraknatillväxt_Click(object sender, EventArgs e)
        {
            double Startantal = double.Parse(tbxStartantal.Text);
            int Interval = int.Parse(tbxTid.Text);
            for(int i=0; i < Interval; i++)
            {
                Startantal *=2;
                
            }
            lblslutantalet.Text = Startantal.ToString();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            //int starttalen = 1;
            int eftertalet = 0;

            int[] Fib = new int[102];
            Fib[0] = 1;
            Fib[1] = 1;

            tbxfibonacistal.Text = "Tal0" + "\t" + "1" + "\r\n" + "Tal1" + "\t" + "1" + "\r\n";
            for (int i = 2; i <= 100; i++)
            {
                Fib[i] = Fib[i-2] + Fib[i-1];
                eftertalet++;
                tbxfibonacistal.Text += "Tal" + i.ToString() + "\t" + Fib[i] + "\r\n";
            }
        }

        private void btnberäkna93_Click(object sender, EventArgs e)
        {
            double pappretstjocklek = double.Parse(tbxPappretstjocklek.Text);
            double Hojd = double.Parse(tbxHojd.Text);
            int AntalVikningar = 0;
            for (double i=pappretstjocklek; i<=Hojd; i++)
            {
                Math.Pow(pappretstjocklek, 2);
                AntalVikningar++;
                i++;
            }
            lblSvar931.Text = AntalVikningar.ToString();
        }

        private void btnBeräkna100_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbxTalet100.Text);
            int[] Tal = new int [x];
            Tal[0] = x;

            for (int i = 1; x>i ; x++)
            {
                Tal[i] = x - i;
                --i;
            }
        }
    }
}
