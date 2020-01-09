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

        private void tbxOctaDeci_Click(object sender, EventArgs e)
        {               // Ruta 2
            int A = tbxOctatalet2.Text.Length;
            int i = 0;
            string B = tbxOctatalet2.Text;
            double[] Array = new double[A];
            while ( i < tbxOctatalet2.Text.Length )
            {
                Array[i] = B[--A]-48;
                if (Array[i] >= 8)
                    i = tbxOctatalet2.Text.Length + 1;
                i++;
            }
            if (i > tbxOctatalet2.Text.Length)
                tbxDeciamltalet2.Text = "Fel inmatning, ej >= 8";
            else
            {
                i = 0;
                double tot = 0;
                while (i < tbxOctatalet2.Text.Length)
                {
                    Array[i] *= Math.Pow(8, i);
                    tot += Array[i];
                    i++;

                }
                tbxDeciamltalet2.Text = tot.ToString();
            }
        }

        private void btnDeciOcta_Click(object sender, EventArgs e)
        {
            int text = tbxDecimaltalet1.Text.Length * 2;
            double Deci = int.Parse(tbxDecimaltalet1.Text);
            double[] Octa = new double[text];
            int[] kvärde = new int[8];
            int n = 0;
            while (Deci>0)
            {
                Octa[n] = Deci - Math.Pow(8, text - n);
                if (Octa[n]<1)
                {
                    Octa[n] = 0;
                }
                else
                {

                    Octa[n] = Deci;
                    Octa[n] = Deci - 7 * Math.Pow(8, text - n);

                    if (Octa[n] > 1)
                        tbxOctantalet1.Text += "7";
                    
                    else
                    {
                        Octa[n] = Deci;
                        Octa[n] = Deci - 6 * Math.Pow(8, text - n);


                        if (Octa[n] > 1)
                            tbxOctantalet1.Text += "6";

                        else
                        {
                            Octa[n] = Deci;
                            Octa[n] = Deci - 5 * Math.Pow(8, text - n);


                            if (Octa[n] > 1)
                                tbxOctantalet1.Text += "5";

                            else
                            {
                                Octa[n] = Deci;
                                Octa[n] = Deci - 4 * Math.Pow(8, text - n);


                                if (Octa[n] > 1)
                                    tbxOctantalet1.Text += "4";


                                else
                                {
                                    Octa[n] = Deci;
                                    Octa[n] = Deci - 3 * Math.Pow(8, text - n); 

                                    if (Octa[n]>1)
                                        tbxOctantalet1.Text += "3";


                                    else
                                    {
                                        Octa[n] = Deci;
                                        Octa[n] = Deci - 2 * Math.Pow(8, text - n);

                                        if (Octa[n]>1)
                                        {
                                            tbxOctantalet1.Text += "2";
                                        }


                                        else
                                        {
                                            Octa[n] = Deci;
                                            Octa[n] = Deci - 1 * Math.Pow(8, text - n);
                                            tbxOctantalet1.Text += "1";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //tbxOctantalet1.Text += Deci;
                }
                Deci = Octa[n];
                n++;
            }


        }
    }
}
