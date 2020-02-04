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
    public partial class Kapitle10 : Form
    {
        public Kapitle10()
        {
            InitializeComponent();
        }

        double Tempomvandling(double Grader, int textlength)
        {
            if (textlength==0)
            {
                double Celsius = (Grader - 32) / 1.8;
                return Celsius;
            }
            else
            {
                double Farenhiet = (Grader * 1.8) + 32;
                return Farenhiet;
            }
        }

        private void btnTempomvandling_Click(object sender, EventArgs e)
        {
            int textlength = tbxCelsius.Text.Length;

            if (textlength==0)
            {
                double Grader = double.Parse(tbxFarenhiet.Text);
                tbxCelsius.Clear();
                tbxCelsius.Text = Tempomvandling(Grader, textlength).ToString();
            }
            else
            {
                double Grader = double.Parse(tbxCelsius.Text);
                tbxFarenhiet.Clear();
                tbxFarenhiet.Text = Tempomvandling(Grader, textlength).ToString();
            }
        }

        private void tbxFarenhiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCelsius_TextChanged(object sender, EventArgs e)
        {

        }

        double CirkelArea(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        private void btnBeräkna101_Click(object sender, EventArgs e)
        {
            lblAreasvar.Text = CirkelArea(double.Parse(tbxRadie.Text)).ToString();
        }

        private int Minsta2Tal(int Tal1, int Tal2)
        {
            if (Tal1 < Tal2)
            {
                return Tal1;
            }
            else
            {
                return Tal2;
            }
        }

        private void btnMinst102_Click(object sender, EventArgs e)
        {

            tbxMinstaTal.Text = Minsta2Tal(int.Parse(tbxTal1102.Text), int.Parse(tbxTal2102.Text)).ToString();
        }

        double VolymCylinder(double Radie, double höjd)
        {
            double volym = CirkelArea(Radie) * höjd;
            return volym;
        }

        private void btnBeräkna102_Click(object sender, EventArgs e)
        {
            tbxVolym.Text = VolymCylinder(double.Parse(tbxRadie102.Text), double.Parse(tbxHöjd.Text)).ToString();
        }

        void Vändom2Tal(ref int a, ref int b)
        {
            int c = b;
            b = a;
            a = c;
        }

        private void btnBytPlats_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbxTal1105.Text);
            int b = int.Parse(tbxTal2105.Text);
            Vändom2Tal(ref a, ref b);
            tbxTal1OM105.Text = a.ToString();
            tbxTal2OM105.Text = b.ToString();
        }

        private void btnMinst106_Click(object sender, EventArgs e)
        {
            int Tal1;
            int Tal2;
            indata(out Tal1, out Tal2);
            int minsta = Minsta2Tal(Tal1, Tal2);
            tbxMinst106.Text = minsta.ToString();


        }
        void indata(out int t1, out int t2)
        {
            t1 = int.Parse(tbxTal1106.Text);
            t2 = int.Parse(tbxTal2106.Text);
        }

        private void btnBeräkna106_Click(object sender, EventArgs e)
        {
            int Radie;
            int Höjd;
            indata106(out Radie, out Höjd);
            tbxVolym106.Text = VolymCylinder(Radie, Höjd).ToString();
        }
        void indata106(out int Radie, out int Höjd)
        {
            Radie = int.Parse(tbxRadie106.Text);
            Höjd = int.Parse(tbxHöjd106.Text);
        }

        private void btnKasta_Click(object sender, EventArgs e)
        {
            tbxTärnstatistik.Clear();
            int Antalkast = 5;
            int AntalSidor = 6;
            int[] Tärningar = new int[Antalkast];
            KastaTärning(Tärningar, AntalSidor);
            for (int i = 0; i < Antalkast; i++)
            {
                tbxTärnstatistik.Text += "Tärning" + (i+1) + ":\t" + Tärningar[i] + "\r\n";
            }
            
        }
        void KastaTärning(int[] Arr, int Antalsidor)
        {
            Random slump = new Random();
            int i = 0;
            while (i < Arr.Length)
            {
                Arr[i] = slump.Next(1, Antalsidor++);
                i++;
            }
        }

        private void btnBeräknaOmkrets_Click(object sender, EventArgs e)
        {
            lblOmkretsSvar101.Text = CirklensOmkrets(double.Parse(tbxRadie101.Text)).ToString();
        }

        double CirklensOmkrets(double Radie)
        {
            double Omkrets = (2 * Radie) * Math.PI;
            return Omkrets;
        }

        private void btnVisaTecken_Click(object sender, EventArgs e)
        {
            lblTeckenSvar102.Text = BestämTecken(double.Parse(tbxTal102.Text)).ToString();
        }

        char BestämTecken(double Tal)
        {
            if (Tal > 0)
                return '+';
            
            else if (Tal < 0)
                return '-';
           
            else
                return '0';
        }

        bool ÄrSiffra(char tecken)
        {
            if (tecken > 47 && tecken < 58)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnTeckenResultat103_Click(object sender, EventArgs e)
        {
            char tecken = char.Parse(tbxTecken103.Text);
            if (ÄrSiffra(tecken) == true)
            {
                lblTeckenSvar.Text = "Tecknet är en sifra";
            }
            else
            {
                lblTeckenSvar.Text = "Tecknet är inte en sifra";

            }
        }

        private void Kapitle10_Load(object sender, EventArgs e)
        {

        }

        char Gemen_Versal (char Gemen)
        {
            int Versalint = Gemen-32;
            char Versal = (char)Versalint;
            return Versal;
        }

        private void btnvisaVersal_Click(object sender, EventArgs e)
        {
            char Gemen = tbxGemen.Text[0];
            if (Gemen > 96 && Gemen < 122 || Gemen > 227 && Gemen < 230 || Gemen == 246)
            {
                lblVersalSvar.Text = Gemen_Versal(Gemen).ToString();
            }
            else if (Gemen > 64 && Gemen < 91 || Gemen > 195 && Gemen < 198 || Gemen == 214)
            {
                lblVersalSvar.Text = "Tecknet är redan Versal";
            }
            else
            {
                lblVersalSvar.Text = "Tecknet är inte ett Gemen";
            }
        }

        bool ÄrPrimTal (long Primtal)
        {
            int i = 1;
            double dPrim = (double)Primtal;
            while (i < Primtal)
            {
                i++;
                if (Primtal == i)
                {
                    return true;
                }
                else if (dPrim/i == Primtal/i)
                {
                    return false;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 PT64 = new Int64();
            PT64 = Int64.Parse(tbxTal106.Text);
            //int PT = Convert.ToInt32(tbxTal106.Text);
            //int PrimTal = int.Parse(tbxTal106.Text);
            if (ÄrPrimTal(PT64) == true )
            {
                lblPrimtal106.Text = "Talet är Primtal";
            }
            else
            {
                lblPrimtal106.Text = "Talet är inte Primtal";
            }
        }

        private void tbxTal106_TextChanged(object sender, EventArgs e)
        {
            lblPrimtal106.Text = "";
        }

        double Potens (double Bas, double Exponent)
        {
            double Potens = Bas;
            if (Exponent==0)
            {
                return 1;
            }
            for (int i = 1; i < Exponent; i++)
            {
                Potens *= Bas;
            }
            return Potens;
        }

        private void btnPotens_Click(object sender, EventArgs e)
        {
            double Bas = double.Parse(tbxBas.Text);
            double Exponent = double.Parse(tbxExponent.Text);
            lblPotensSvar.Text = Bas.ToString() + " upphöjt till " + Exponent.ToString() + " till " + Potens(Bas, Exponent).ToString();
        }

        void Väderlös_TidOmvandlingSek_Tim (out int Tidh, out int Tidm, out int Tids)
        {
            Tids = int.Parse(tbxTidSek.Text);
            if (Tids/3600 > 0)
            {
                Tidh = Tids / 3600;
                Tids %= 3600;
                if (Tids/60 > 0)
                {
                    Tidm = Tids / 60;
                    Tids %= 60;
                }
            }
            else if (Tids/60 > 0)
            {
                Tidh = 0;
                Tidm = Tids / 60;
                Tids %= 60;
            }
            else
            {
                Tidh = 0;
                Tidm = 0;
            }
            Tidh = 0;
            Tidm = 0;
        }

        private void btnTidSek_Click(object sender, EventArgs e)
        {
            
        }
    }
}
