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
    public partial class StenSaxPase : Form
    {
        int nrDatorVinster;
        int nrSpelarVinster;
        public StenSaxPase()
        {
            InitializeComponent();
        }

        private void StenSaxPase_Load(object sender, EventArgs e)
        {

        }

        private void btnSpela_Click(object sender, EventArgs e)
        {
            gbxStenSaxPåse.Enabled = true;
            btnSpela.Enabled = false;
            lblDatornsVal.Text = "";
            lblResultat.Text = "";
            nrSpelarVinster = 0;
            nrDatorVinster = 0;
        }

        private void pbxSten_Click(object sender, EventArgs e)
        {
            //skapar ett slumptal i intervallet 1 till 3
            Random slump = new Random();
            int datornsTal = slump.Next(1, 4);

            //översätt slumptalet till Sten, Sax eller Påse
            string Datornsval = "";
            switch (datornsTal)
            {
                case 1:
                    Datornsval = "Sten";
                    break;
                case 2:
                    Datornsval = "Sax";
                    break;
                case 3:
                    Datornsval = "Påse";
                    break;
            }

            //skriv datorns val till etiketen som visar datorns val.
            lblDatornsVal.Text = Datornsval;

            if (Datornsval.Equals("sax"))
                nrSpelarVinster++;
            else if (Datornsval.Equals("Påse"))
                nrDatorVinster++;

            lblResultat.Text = "Dator: " + nrDatorVinster + " Spelare: " + nrSpelarVinster;

            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("Dator: " + nrDatorVinster + " Spelare: " + nrSpelarVinster + "\r\n");
            }
        }

        private void pbxSax_Click(object sender, EventArgs e)
        {
            //skapar ett slumptal i intervallet 1 till 3
            Random slump = new Random();
            int datornsTal = slump.Next(1, 4);

            //översätt slumptalet till Sten, Sax eller Påse
            string Datornsval = "";
            switch (datornsTal)
            {
                case 1:
                    Datornsval = "Sten";
                    break;
                case 2:
                    Datornsval = "Sax";
                    break;
                case 3:
                    Datornsval = "Påse";
                    break;
            }

            //skriv datorns val till etiketen som visar datorns val.
            lblDatornsVal.Text = Datornsval;

            if (Datornsval.Equals("Påse"))
                nrSpelarVinster++;
            else if (Datornsval.Equals("Sten"))
                nrDatorVinster++;

            lblResultat.Text = "Dator: " + nrDatorVinster + " Spelare: " + nrSpelarVinster;

            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("Dator: " + nrDatorVinster + " Spelare: " + nrSpelarVinster + "\r\n");
            }
        }

        private void pbxPåse_Click(object sender, EventArgs e)
        {
            //skapar ett slumptal i intervallet 1 till 3
            Random slump = new Random();
            int datornsTal = slump.Next(1, 4);

            //översätt slumptalet till Sten, Sax eller Påse
            string Datornsval = "";
            switch (datornsTal)
            {
                case 1:
                    Datornsval = "Sten";
                    break;
                case 2:
                    Datornsval = "Sax";
                    break;
                case 3:
                    Datornsval = "Påse";
                    break;
            }

            //skriv datorns val till etiketen som visar datorns val.
            lblDatornsVal.Text = Datornsval;

            if (Datornsval.Equals("Sten"))
                nrSpelarVinster++;
            else if (Datornsval.Equals("Sax"))
                nrDatorVinster++;

            lblResultat.Text = "Dator: " + nrDatorVinster + " Spelare: " + nrSpelarVinster;

            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("Dator: " + nrDatorVinster + " Spelare: " + nrSpelarVinster + "\r\n");
            }
        }
    }
}
