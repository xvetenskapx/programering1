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
            int A,B,C,D,E = 0;
            string Tal = tbxTal.Text;
            char A1 = Tal[0];
            A = A1;
            int A2 = (A - 48) * 16;
            char B1 = Tal[1];
            B = B1;
            int B2 = (B - 48) * 8;
            char C1 = Tal[2];
            C = C1;
            int C2 = (C - 48) * 4;
            char D1 = Tal[3];
            D = D1;
            int D2 = (D - 48) * 2;
            char E1 = Tal[4];
            E = E1;
            int E2 = (E - 48) * 1;
            int SummaD = A2 + B2 + C2 + D2 + E2;
            lblTalbas.Text = SummaD.ToString();


        }
    }
}
