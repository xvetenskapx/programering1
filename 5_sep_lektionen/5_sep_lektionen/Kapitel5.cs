﻿using System;
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

        private void BtnKolla_Click(object sender, EventArgs e)
        {
            double Pengar = double.Parse(tbxMinaPengar.Text);
            double Pris = double.Parse(tbxVaransPris.Text);
            bool HarJagRåd = Pengar >= Pris;
            lblSvarR.Text = HarJagRåd.ToString();
        }

        private void BtnKor_Click(object sender, EventArgs e)
        {
            int Tal10 = int.Parse(tbxTal10.Text);
            int Tal20 = int.Parse(tbxTal20.Text);
            int Tal30 = int.Parse(tbxTal30.Text);
            bool Följd = Tal10 <= Tal20 && Tal20 <=Tal30;

            lblOrdningSvar.Text = "Talen Är: " + Följd.ToString() + " I Ordningen";
        }

        private void BtnSifflek_Click(object sender, EventArgs e)
        {
            double Osiffra = double.Parse(tbxSifflek.Text);
            double Siffra = (((Osiffra + 1) * 2) - 6) * 0.5 + 3 - Osiffra;
            lblSiffersvar.Text = Siffra.ToString();
        }

        private void BtnAvrunda_Click(object sender, EventArgs e)
        {
            double TusTal = double.Parse(tbxTusTal.Text);
            double EnTal = TusTal / 1000 + 0.5;
            int AvrundatEn = (int) EnTal;
            int AvrundatTus = AvrundatEn * 1000;
            lblAvrundningTusSvar.Text = AvrundatTus.ToString();
        }

        private void BtnBlanda_Click(object sender, EventArgs e)
        {
            int Taljare = int.Parse(tbxTaljare.Text);
            int Namnare = int.Parse(tbxNamnare.Text);
            int Hela = Taljare / Namnare;
            int TaljareKvar = Taljare % Namnare;

            lblSvarHela.Text = Hela.ToString();
            lblSvarTaljare.Text = TaljareKvar.ToString();
            lblSvarNamnare.Text = tbxNamnare.Text;
        }
    }
}
