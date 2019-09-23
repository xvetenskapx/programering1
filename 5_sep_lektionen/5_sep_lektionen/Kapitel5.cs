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
    public partial class Kapitel5 : Form
    {
        public Kapitel5()
        {
            InitializeComponent();
        }

        private void BtnBerakna1_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(tbxTal1.Text);
            int tal2 = int.Parse(tbxTal2.Text);
            int Division = tal1 / tal2;
            int Modulus = tal1 % tal2;
            lblDivisionSvar.Text = Division.ToString();
            lblModulusSvar.Text = Modulus.ToString();
        }

        private void BtnTid_Click(object sender, EventArgs e)
        {
            //Värden
            int Sek = int.Parse(tbxTidS.Text);
            int Min = int.Parse(tbxTidMi.Text);
            int Tim = int.Parse(tbxTidT.Text);
            int Dyg = int.Parse(tbxTidD.Text);
            int Vec = int.Parse(tbxTidV.Text);
            int Man = int.Parse(tbxTidMa.Text);
            int Ar = int.Parse(tbxTidA.Text);

            int Tiden = Sek + Min + Tim + Dyg + Vec + Man + Ar;
            tbxTid.Text = Tiden.ToString();

            //Sek - Min
            //int Min2 = Sek / 60;
            //int Sek1 = Sek % 60;

            //tbxTidMi.Text = Min2.ToString();
            //tbxTidS.Text = Sek1.ToString();

            //Min - Tim
 

            //Tim - Dyg
            //int Dyg1 = Tim / 24;
            //int Tim2 = Tim % 24;

            //tbxTidD.Text = Dyg1.ToString();
            //tbxTidT.Text = Tim2.ToString();

            //Dyg - Vec
            //int Vec1 = Dyg / 7;
            //int Dyg2 = Dyg % 7;

            //tbxTidV.Text = Vec1.ToString();
            //tbxTidD.Text = Dyg2.ToString();

            //Vec - Mån
            //int Man1 = Vec / 4;
            //int Vec2 = Vec % 4;

            //tbxTidMa.Text = Man1.ToString();
            //tbxTidV.Text = Vec2.ToString();

            //Mån - År1
            int Ar1 = Man / 12;
            int Man2 = Man % 12;

            tbxTidA.Text = Ar1.ToString();
            tbxTidMa.Text = Man2.ToString();


        }

        private void BtnBeräkna_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbxTal3.Text);
            int b = --a;
            int c = ++b + a;

            lblSvarVL.Text = c.ToString();
        }
    }
}
