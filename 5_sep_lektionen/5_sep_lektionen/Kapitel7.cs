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
    public partial class Kapitel_7 : Form
    {
        public Kapitel_7()
        {
            InitializeComponent();
        }

        private void BtnKolla71_Click(object sender, EventArgs e)
        {
            string t = tbxTal71.Text;
            double tal = double.Parse(t);
            if (tal>0)
            {
                lblResultat71.Text = "Ja";
            }
            else if (tal==0)
            {
                lblResultat71.Text = "Lika Stort";
            }
            else
            {
                lblResultat71.Text = "Nej";
            }
        }

        private void TbxTal71_TextChanged(object sender, EventArgs e)
        {
            lblResultat71.Text = "";
        }

        private void BtnBensinBerakna_Click(object sender, EventArgs e)
        {
            double BensinKvar = double.Parse(tbxLBensin.Text);
            double BensinPris = double.Parse(tbxBPris.Text);
            if (BensinKvar > 10)
            {
                lblBensinSvar.Text = "Fortsätt Köra Vidare";
            }
            else
            {
                double BensinSaknas = 50 - BensinKvar;
                double BensinKostnad = BensinPris * BensinSaknas;
                lblBensinSvar.Text = "Tanka " + BensinSaknas.ToString() + " Liter. Det Kostar " + BensinKostnad.ToString() + " kr.";
            }
        }

        private void LblBensinSvar_TextChanged(object sender, EventArgs e)
        {
            lblBensinSvar.Text = "";
        }

        private void BtnPuddelKolla_Click(object sender, EventArgs e)
        {
            double Hojd = double.Parse(tbxPudelHojd.Text)
            if (Hojd>28 && Hojd<35)
            {
                lblPudelSvar.Text = "Det Är En Dvärgpudel"
            }
            else
            {
                lblPudelSvar.Text = "Det Är Inte En Dvärgpudel"
            }
        }

        private void LblPudelSvar_TextChanged(object sender, EventArgs e)
        {
            lblPudelSvar.Text = ""
        }
    }
}
