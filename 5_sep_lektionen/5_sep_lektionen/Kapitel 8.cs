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
    public partial class Kapitel_8 : Form
    {
        //Medlemsvariabler
        int datornsTal;
        int antalGissningar;

        public Kapitel_8()
        {
            InitializeComponent();
            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);

            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0];
        }

        private void lbxStörstaTalet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStartaspelet_Click(object sender, EventArgs e)
        {
            //string störstaTal = lbxStörstaTalet.SelectedIndex
            int Störst = int.Parse(lbxStörstaTalet.SelectedItem.ToString());
            Random slump = new Random();
            datornsTal = slump.Next(1, Störst + 1);

            btnStartaspelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "??";

            antalGissningar = 0;
        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = tbxGissa.Text;
            int gissatTal = int.Parse(gissa);

            if (gissatTal == datornsTal)
            {
                lblResultat.Text = "Korrekt efter " + antalGissningar + " försök.";
                gbxSpelet.Enabled = false;
                btnSpelaIgen.Enabled = true;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + " försök\n");
            }

            else if (gissatTal < datornsTal)
                lblResultat.Text = "För lågt, Försök igen.";

            else
                lblResultat.Text = "För högt. Försök igen.";
        }

        private void btnSpelaIgen_Click(object sender, EventArgs e)
        {
            btnStartaspelet.Enabled = true;
            gbxSpeldata.Enabled = true;
            gbxSpelet.Enabled = false;
        }
    }
}
