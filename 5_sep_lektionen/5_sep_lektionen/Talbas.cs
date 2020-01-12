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
            int TextLength = tbxOctatalet2.Text.Length;
            int i = 0;
            string OctaTal = tbxOctatalet2.Text;
            double[] Array = new double[tbxOctatalet2.Text.Length];
            while ( i < TextLength )
            {
                Array[i] = OctaTal[--TextLength]-48;
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
            int TextLength = tbxDecimaltalet1.Text.Length * 2 + 1;
            double Deci = int.Parse(tbxDecimaltalet1.Text);
            double[] Octa = new double[TextLength];
            //int[] kvärde = new int[8];
            int n = 0;
            while (Deci>0)
            {
                Octa[n] = Deci - Math.Pow(8, TextLength - ++n);
                if (Octa[n]<0)
                {
                    Octa[n] = 0;
                    Deci = int.Parse(tbxDecimaltalet1.Text);
                    tbxOctantalet1.Text += "0";
                }
                else
                {

                    Octa[n] = Deci;
                    Octa[n] = Deci - 7 * Math.Pow(8, TextLength - n);

                    if (Octa[n] > 0)
                        tbxOctantalet1.Text += "7";
                    
                    else
                    {
                        Octa[n] = Deci;
                        Octa[n] = Deci - 6 * Math.Pow(8, TextLength - n);


                        if (Octa[n] > 0)
                            tbxOctantalet1.Text += "6";

                        else
                        {
                            Octa[n] = Deci;
                            Octa[n] = Deci - 5 * Math.Pow(8, TextLength - n);


                            if (Octa[n] > 0)
                                tbxOctantalet1.Text += "5";

                            else
                            {
                                Octa[n] = Deci;
                                Octa[n] = Deci - 4 * Math.Pow(8, TextLength - n);


                                if (Octa[n] > 0)
                                    tbxOctantalet1.Text += "4";


                                else
                                {
                                    Octa[n] = Deci;
                                    Octa[n] = Deci - 3 * Math.Pow(8, TextLength - n); 

                                    if (Octa[n]>0)
                                        tbxOctantalet1.Text += "3";


                                    else
                                    {
                                        Octa[n] = Deci;
                                        Octa[n] = Deci - 2 * Math.Pow(8, TextLength - n);

                                        if (Octa[n]>0)
                                        {
                                            tbxOctantalet1.Text += "2";
                                        }


                                        else
                                        {
                                            Octa[n] = Deci;
                                            Octa[n] = Deci - 1 * Math.Pow(8, TextLength - n);

                                            if (Octa[n]==0)
                                            {
                                                tbxOctantalet1.Text += "0";
                                            }

                                            else
                                            {
                                                tbxOctantalet1.Text += "1";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //tbxOctantalet1.Text += Deci;
                    Deci = Octa[n];
                }
                n++;
            }


        }

        private void btnDeciBi_Click(object sender, EventArgs e)
        {

        }

        private void btnBiDeci_Click(object sender, EventArgs e)
        {
            int TextLength = tbxBinäratalet4.Text.Length;
            double[] Deci = new double[TextLength];
            int Bi = int.Parse(tbxBinäratalet4.Text);
            string Binary = tbxBinäratalet4.Text;

            int n = 0;

            while (n < TextLength)
            {
                Deci[n] = Binary[--TextLength] - 48;
                if (Deci[n] >= 2)       break;
            }


            if (TextLength == 0)
            {
                double tot = 0;
                TextLength = tbxBinäratalet4.Text.Length;
                for (int i = 0; i < tbxBinäratalet4.Text.Length; i++)
                {
                    Deci[i] *= Math.Pow(2, --TextLength);
                    tot += Deci[i];
                }

                //n = 0;
                //while (n<tbxBinäratalet4.Text.Length)
                //{
                //    tot += Deci[n];
                //    n++;
                //}
                tbxDecimaltalet4.Text = tot.ToString();
            }
            else
            {
                tbxDecimaltalet4.Text = "Fel inmatning";
            }

        }

        private void tbxBinäratalet4_TextChanged(object sender, EventArgs e)
        {
            tbxDecimaltalet4.Clear();
        }
    }
}
