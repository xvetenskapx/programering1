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
    public partial class Kapitel3 : Form
    {
        public Kapitel3()
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

            //Sek


            //Min
            int Tim1 = Min / 60;
            int Min1 = Min % 60;

            //Tim


            //Dyg


            //Vec


            //Mån


            //År

            //Tbx
            tbxTidMi.Text = Min1.ToString();
            tbxTidT.Text = Tim1.ToString();

        }
    }
}
