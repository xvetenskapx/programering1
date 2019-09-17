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
    public partial class Talbas : Form
    {
        public Talbas()
        {
            InitializeComponent();
        }

        private void BtnBeräkna_Click(object sender, EventArgs e)
        {
            string Tal = tbxTal.Text;
            char A = Tal[0];
            int A1 = A;
            int A2 = (A1 - 48) * 16;
            char B = Tal[1];
            int B1 = B;
            int B2 = (B1 - 48) * 8;
            char C = Tal[2];
            int C1 = C;
            int C2 = (C1 - 48) * 4;
            char D = Tal[3];
            int D1 = D;
            int D2 = (D1 - 48) * 2;
            char E = Tal[4];
            int E1 = E;
            int E2 = (E1 - 48) * 1;
            int SummaD = A2 + B2 + C2 + D2 + E2;
            //try
            //{
            //    int A,B,C,D,E = int.Parse(tbxTal.Text);
            //}
            //catch
            //{

            //}

            //string A3 = A2.ToString();
            lblTalbas.Text = SummaD.ToString();

            //char B = Tal[1];
            //char C = Tal[0];
            //char D = Tal[1];
            //char F = Tal[1];

            //char A2 = (char)A;


            //string Fornamn = tbxFornamn.Text;
            //string Efternamn = tbxEfternamn.Text;
            //char Finitial = Fornamn[0];
            //char Einitial = Efternamn[0];
            //string initialer = Fornamn + " " + Efternamn + " har initialerna " + Finitial.ToString() + "." + Einitial + ".";
            //lblInitialer.Text = initialer;
            //    string bokstav= tbxTal.Text;
            //    for (int i = 0; i < bokstav.Length; i++)
            //    {
            //        //for (int l = i) ;
            //        {

            //        }
            //    }
            //    //tbxTal.Text = l;
        }
    }
}
