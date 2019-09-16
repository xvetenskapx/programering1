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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Bas = double.Parse(tbxBas.Text);
            double Hojd = double.Parse(tbxHojd.Text);
            double Area = Bas * Hojd / 2;
            lblAreasvar.Text = Area.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
