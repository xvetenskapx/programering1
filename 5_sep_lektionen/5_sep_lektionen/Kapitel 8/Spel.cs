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
    public partial class Spel : Form
    {
        public Spel()
        {
            InitializeComponent();
        }

        private void btnGissatalet_Click(object sender, EventArgs e)
        {
            Kapitel_8 GissaTalet = new Kapitel_8();
            GissaTalet.Show();
        }

        private void btnstensaxpåse_Click(object sender, EventArgs e)
        {
            StenSaxPase StenSaxPåse = new StenSaxPase();
            StenSaxPåse.Show();
        }
    }
}
