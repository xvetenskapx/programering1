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
    public partial class Kapitle10 : Form
    {
        public Kapitle10()
        {
            InitializeComponent();
        }

        double Tempomvandling(double Grader, int textlength)
        {
            if (textlength==0)
            {
                double Celsius = (Grader - 32) / 1.8;
                return Celsius;
            }
            else
            {
                double Farenhiet = (Grader * 1.8) + 32;
                return Farenhiet;
            }
        }

        private void btnTempomvandling_Click(object sender, EventArgs e)
        {
            int textlength = tbxCelsius.Text.Length;

            if (textlength==0)
            {
                double Grader = double.Parse(tbxFarenhiet.Text);
                tbxCelsius.Clear();
                tbxCelsius.Text = Tempomvandling(Grader, textlength).ToString();
            }
            else
            {
                double Grader = double.Parse(tbxCelsius.Text);
                tbxFarenhiet.Clear();
                tbxFarenhiet.Text = Tempomvandling(Grader, textlength).ToString();
            }
        }

        private void tbxFarenhiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCelsius_TextChanged(object sender, EventArgs e)
        {

        }

        double CirkelArea(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        private void btnBeräkna101_Click(object sender, EventArgs e)
        {
            lblAreasvar.Text = CirkelArea(double.Parse(tbxRadie.Text)).ToString();
        }

        private int Minstatal(int Tal1, int Tal2)
        {
            if (Tal1 < Tal2)
            {
                return Tal1;
            }
            else
            {
                return Tal2;
            }
        }

        private void btnMinst102_Click(object sender, EventArgs e)
        {

            tbxMinstaTal.Text = Minstatal(int.Parse(tbxTal1102.Text), int.Parse(tbxTal2102.Text)).ToString();
        }

        double VolymCylinder(double Radie, double höjd)
        {
            double volym = CirkelArea(Radie) * höjd;
            return volym;
        }

        private void btnBeräkna102_Click(object sender, EventArgs e)
        {
            tbxVolym.Text = VolymCylinder(double.Parse(tbxRadie102.Text), double.Parse(tbxHöjd.Text)).ToString();
        }

        void Vändom2Tal(ref int a, ref int b)
        {
            int c = b;
            b = a;
            a = c;
        }

        private void btnBytPlats_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbxTal1105.Text);
            int b = int.Parse(tbxTal2105.Text);
            Vändom2Tal(ref a, ref b);
            tbxTal1OM105.Text = a.ToString();
            tbxTal2OM105.Text = b.ToString();
        }
    }
}
