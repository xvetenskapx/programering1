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
    public partial class KärleksVeckan : Form
    {
        public static int tal = 1;
        public KärleksVeckan()
        {
            InitializeComponent();
        }

        private void KärleksVeckan_Load(object sender, EventArgs e)
        {

        }


        public static void ändraText(string s)
        {
            //tbxNamn1.Text = s;
        }

        private void pbxVäljfärg_Click(object sender, EventArgs e)
        {

        }

        private void pbxVäljfärg_DoubleClick(object sender, EventArgs e)
        {
            Färg färg = new Färg();
            färg.Show();
        }
    }
}
