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
            double Medel2;
            Medel2= (Tal1 + Tal2) / (double)2;
            string Medelsum2 = Medel2.ToString();
            lblMedel12.Text = Medelsum2;

            double Medel3;
            Medel3 = (Tal1 + Tal2 + Tal3) / (double)3;
            string Medelsum3 = Medel3.ToString();
            lblMedel123.Text = Medelsum3;

            double Medel4;
            Medel4 = (Tal1 + Tal2 + Tal3 + Tal4) / (double) 4;
            string Medelsum4 = Medel4.ToString();
            lblMedel1234.Text = Medelsum4;
        }

        private void BtnKör_Click(object sender, EventArgs e)
        {
            string Svenska = tbxSvenska.Text;
            string Engelska = tbxEngelska.Text;
            lblSE.Text = Engelska + " " + "betyder" + " " + Svenska + " " + "på Engelska";
        }

        private void BtnBeräkna_Click(object sender, EventArgs e)
        {
            string Namn = tbxNamn50.Text;
            int Födelseår = int.Parse(tbxFödelseår50.Text) + 50;
            //int Fyller50 = Födelseår + 50;
            string Mening50 = Namn + " " + "fyller 50 år" + " " + Födelseår.ToString();
            lblMening50.Text = Mening50;
        }

        private void Btninitial_Click(object sender, EventArgs e)
        {
            string Fornamn = tbxFornamn.Text;
            string Efternamn = tbxEfternamn.Text;
            char Finitial = Fornamn[0];
            char Einitial = Efternamn[0];
            string initialer = Fornamn + " " + Efternamn + " har initialerna " + Finitial.ToString() + "." + Einitial + ".";
            lblInitialer.Text = initialer;

            for (int i = 0; i < Fornamn.Length; i++)
            {
                MessageBox.Show("Nu är i= " + i + " och bokstaven är " + Fornamn[i]);
            }

            try
            {
                int tal = int.Parse(tbxFornamn.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du måste skriva in ett tal i texboxen");
            }

        }

        private void BtnKonventera_Click(object sender, EventArgs e)
        {
            //Tecken till Unicode
            string Tecken = tbxTecken.Text;
            char TeckenS = Tecken[0];
            int TeckenB = (int)TeckenS;
            string Unicode = TeckenB.ToString();
            lblTeckenO.Text = Tecken + " Har koden " + Unicode;

            //Versal till gemen
            Char Versal = tbxVersal.Text[0];
            int TeckenG = Versal + 32;
            Char Gemen = (char)TeckenG;
            lblGemen.Text = Gemen.ToString();

            //Unicode till Tecken
            int Code = int.Parse(tbxUnicode.Text);
            String Code1 = tbxUnicode.Text;
            Char Ucode = (char)Code;
            lblUnicodeS.Text = "Koden " + Code1 + " betyder " + Ucode.ToString() + ".";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int X = int.Parse(tbxX.Text);
            int Y = int.Parse(tbxY.Text);
            Point nybtn = new Point(X, Y);
            //Point nyY = new Point(X, Y);
            //Point nyX = new Point(Y, X);
            //tbxX.Location = nyX;
            //tbxY.Location = nyY;
            btnFlytta.Location = nybtn;
        }

        private void BtnTK_Click(object sender, EventArgs e)
        {
            Form2 Kalkylator = new Form2();
            Kalkylator.Show();
        }

        private void BtnTalbas_Click(object sender, EventArgs e)
        {
            Talbas talbas = new Talbas();
            talbas.Show();
        }

        private void BtnAvrunda_Click(object sender, EventArgs e)
        {
            double OaTal = double.Parse(tbxotal.Text);
            double aTal = OaTal + 0.5;
            long Atal = (long) aTal;
            lblAvrundningS.Text = Atal.ToString();
        }

        private void BtnAutomat_Click(object sender, EventArgs e)
        {
            Automat automat = new Automat();
            automat.Show();
        }

        private void Btnkapitel3_Click(object sender, EventArgs e)
        {
            Kapitel5 kapitel3 = new Kapitel5();
            kapitel3.Show();
        }

        private void Btnkap7_Click(object sender, EventArgs e)
        {
            Kapitel_7 kapitel7 = new Kapitel_7();
            kapitel7.Show();
        }

        private void btnKapitel8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hej", "Nej", MessageBoxButtons.YesNo);
            Spel Kapitel8 = new Spel();
            Kapitel8.Show();

        }

        private void btnKapitel9_Click(object sender, EventArgs e)
        {
            Kapitel9 kapitel_9 = new Kapitel9();
            kapitel_9.Show();
        }

        private void btnKapitel10_Click(object sender, EventArgs e)
        {
            Kapitle10 kapitle10 = new Kapitle10();
            kapitle10.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KärleksVeckan kärleksVeckan = new KärleksVeckan();
            kärleksVeckan.Show();
        }
    }
}
