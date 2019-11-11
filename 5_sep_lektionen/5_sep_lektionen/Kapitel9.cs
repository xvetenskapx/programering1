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
    public partial class Kapitel9 : Form
    {
        public Kapitel9()
        {
            InitializeComponent();
        }

        private void btnStarta_Click(object sender, EventArgs e)
        {
            int startvärde = int.Parse(tbxStartvärde.Text);
            int slutvärde = int.Parse(tbxSlutvärde.Text);
            while (startvärde < slutvärde + 1)
            {
                tbxUtdata.Text += startvärde + " " + "\r\n";
                startvärde++;
            }
        }

        private void btnVissa_Click(object sender, EventArgs e)
        {
            double korn = 1;
            int ruta = 1;
            while (ruta < 64+1)
            {
                tbxUtdata92.Text += "Ruta: " + ruta.ToString() + "\t" + "\t" + korn.ToString() + "\r\n";
                korn = korn * 2;
                ruta++;
            }
        }
    }
}
