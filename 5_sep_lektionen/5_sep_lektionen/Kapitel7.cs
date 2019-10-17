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

        private void BtnBeraknaPorto_Click(object sender, EventArgs e)
        {
            int brevet = int.Parse(tbxBrevetsVikt.Text);

                if (brevet <= 20)
            {
                lblPortoKostnad.Text = "Ett brev som väger " + brevet.ToString() + " kostar 5 kronor";
            }
                else if (brevet <= 100)
            {
                lblPortoKostnad.Text = "Ett brev som väger " + brevet.ToString() + " kostar 10 kronor";
            }
                else
            {
                lblPortoKostnad.Text = "Ett brev som väger " + brevet.ToString() + " kostar 20 kronor";
            }
        }

        private void BtnDVDPris_Click(object sender, EventArgs e)
        {
            double Skivor = double.Parse(tbxAntalSkivor.Text);
            double rabatt = 1;

            if (Skivor >= 10)
                rabatt = 0.90;

            else if (Skivor >= 100)
                rabatt = 0.85;

            double DVDKostnad = (Skivor * 9.90) * rabatt;
            lblDVDKostnad.Text = "Kostnaden för " + Skivor.ToString() + " Skivor är " + DVDKostnad.ToString() + " kronor";
        }

        private void BtnBatKostnad_Click(object sender, EventArgs e)
        {
            int AntalPersoner = int.Parse(tbxAntalPersoner.Text);
            switch (AntalPersoner)
            {
                case 1:
                    lblBatKostnad.Text = "Det kostar 70 kr";
                    break;

                case 2:
                    lblBatKostnad.Text = "Det kostar 120 kr";
                    break;

                case 3:
                    lblBatKostnad.Text = "Det kostar 150 kr";
                    break;

                default:
                    lblBatKostnad.Text = "Fel inmatning";
                    break;

            }

                
        }

        private void AntalPersoner(object sender, EventArgs e)
        {
            lblBatKostnad.Text = "";
        }

        private void BtnVeckoDag_Click(object sender, EventArgs e)
        {
            int VeckoDag = int.Parse(tbxVeckodagsNr.Text);
            switch (VeckoDag)
            {
                case 1:
                    lblVeckoDag.Text = "Måndag";
                    break;

                case 2:
                    lblVeckoDag.Text = "Tisdag";
                    break;

                case 3:
                    lblVeckoDag.Text = "Onsdag";
                    break;

                case 4:
                    lblVeckoDag.Text = "Torsdag";
                    break;

                case 5:
                    lblVeckoDag.Text = "Fredag";
                    break;

                case 6:
                    lblVeckoDag.Text = "lördag";
                    break;

                case 7:
                    lblVeckoDag.Text = "Söndag";
                    break;

                case 10:
                    lblVeckoDag.Text = "Sneaky";
                    break;

                default:
                    lblVeckoDag.Text = "Fel inmatning";
                    break;
            }
        }

        private void tbxVeckodagNr(object sender, EventArgs e)
        {
            lblVeckoDag.Text = "";
        }

        private void BtnKontrollera_Click(object sender, EventArgs e)
        {
            string Namn = tbxNamn.Text;
            string Losenord = tbxLosenord.Text;
            if (Namn.Equals("Andre") && Losenord.Equals("Password"))
            {
                lblInloggning.Text = "Hej André";
            }

            else
            {
                lblInloggning.Text = "Felaktigt namn eller lösenord";
            }
        }

        private void BtnJämnförNamn_Click(object sender, EventArgs e)
        {
            string Namn1 = tbxNamn1.Text;
            string Namn2 = tbxNamn2.Text;

            if (Namn1.CompareTo(Namn2) > 0)
            {
                lblNamnOrdning.Text = Namn2 + " " + Namn1;
            }

            else
            {
                lblNamnOrdning.Text = Namn1 + " " + Namn2;
            }
        }

        private void BtnStörstaTalet_Click(object sender, EventArgs e)
        {
            double TalE1 = double.Parse(tbxTalE177.Text);
            double TalE2 = double.Parse(tbxTalE277.Text);
            double max = TalE1 > TalE2 ? TalE1 : TalE2;
            lblTalOrdning77.Text = "Det Största Talet Är " + max.ToString();
        }

        private void BtnTalIOOrdning_Click(object sender, EventArgs e)
        {
            double TalO1
        }
    }
}
