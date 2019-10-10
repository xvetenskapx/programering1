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
            double Hojd = double.Parse(tbxPudelHojd.Text);
            if (Hojd > 28 && Hojd < 35) 
            {
                lblPudelSvar.Text = "Det Är En Dvärgpudel";
            }
            else
            {
                lblPudelSvar.Text = "Det Är Inte En Dvärgpudel";
            }
        }

        private void LblPudelSvar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxPudelHojd_TextChanged(object sender, EventArgs e)
        {
            lblPudelSvar.Text = "";
        }

        private void BtnBeräkna72_Click(object sender, EventArgs e)
        {
            int Alder = int.Parse(tbxAlder.Text);
            //if (Alder>15&&Alder<65)
            //{
            //    lblKostnad72.Text = "Du åker för 20 kr";
            //}
            //else
            //{
            //    lblKostnad72.Text = "Du åker för 10 kr";
            //}

            if (Alder < 15 || Alder > 65)
            {
                lblKostnad72.Text = "Du åker för 10 kr";
            }
            
            else
            {
                lblKostnad72.Text = "Du åker för 20 kr";
            }

        }

        private void BtnBeräknaUttag_Click(object sender, EventArgs e)
        {
            double Pengar = double.Parse(tbxDinaPengar.Text);
            double Kostnad = double.Parse(tbxKostand.Text);
            if (Pengar > Kostnad)
            {
                double Rest = Pengar - Kostnad;
                lblSvarPengarKvar.Text = "Du kommer få tillbaka " + Rest.ToString() + " kr";
            }
            else
            {
                double Rest = Kostnad - Pengar;
                int Hundratal = (int)(Rest / 100);
                int uttag = (Hundratal + 1) * 100;
                double kvar = (double)uttag + Pengar - Kostnad;
                lblSvarPengarKvar.Text = "Ta ut " + uttag.ToString() + " kronor." + " Efter köpet återstå " + kvar.ToString() + " kronor.";
            }
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            Random tarnigng = new Random();
            int Resulat = tarnigng.Next(1, 7);
            if (Resulat == 6)
                MessageBox.Show("Grattis", "En sexa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lblAntalPrickar.Text = Resulat.ToString();
        }
    }
}
