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
        public static int[] Färg = new int[3];
        public KärleksVeckan()
        {
            InitializeComponent();
        }

        private void KärleksVeckan_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
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
            Färg färg = new Färg(this.pbxVäljfärg);
            färg.Show();


        }

        public void bytFärg(Color c)
        {
            pbxVäljfärg.BackColor = c;
        }

        private void btnVäljFärg_Click(object sender, EventArgs e)
        {

        }


        void RitaHjärtaÖver(string Tecken)
        {

            for (int i = 0; i < 11; i++)
            {
                lblHjärtaUtskrift.Text += "  ";
                if (i == 3)
                {
                    lblHjärtaUtskrift.Text += " " + Tecken;
                }
            }

            lblHjärtaUtskrift.Text += Tecken + "\r\n";
            for (int i = 0; i < 6; i++)
            {
                lblHjärtaUtskrift.Text += "  ";
                switch (i)
                {
                    case 1:
                        lblHjärtaUtskrift.Text += "  " + Tecken;
                        break;

                    case 2:
                        lblHjärtaUtskrift.Text += "  " + Tecken;
                        break;

                    case 3:
                        lblHjärtaUtskrift.Text += "  ";
                        break;
                    case 4:
                        lblHjärtaUtskrift.Text += "  " + Tecken;
                        break;
                    case 5:
                        lblHjärtaUtskrift.Text += "  " + Tecken;
                        break;
                    default:
                        break;
                }
            }
            lblHjärtaUtskrift.Text += "\r\n";

            for (int i = 0; i < 5; i++)
            {
                lblHjärtaUtskrift.Text += "  ";
                switch (i)
                {
                    case 1:
                        lblHjärtaUtskrift.Text += Tecken;
                        break;

                    case 2:
                        lblHjärtaUtskrift.Text += "  " + "  " + "  " + Tecken;
                        break;
                    case 3:
                        lblHjärtaUtskrift.Text += "  " + Tecken;
                        break;
                    case 4:
                        lblHjärtaUtskrift.Text += "  " + "  " + "  " + Tecken;
                        break;
                    default:
                        break;
                }
            }
            lblHjärtaUtskrift.Text += "\r\n";

            int y = 0;
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        lblHjärtaUtskrift.Text += Tecken;
                        break;

                    case 1:
                        while (y < 7)
                        {
                            lblHjärtaUtskrift.Text += "  ";
                            y++;
                        }
                        lblHjärtaUtskrift.Text += " " + Tecken;
                        y = 0;
                        break;

                    case 2:
                        while (y < 7)
                        {
                            lblHjärtaUtskrift.Text += "  ";
                            y++;
                        }
                        lblHjärtaUtskrift.Text += " " + Tecken;
                        break;

                    default:
                        break;
                }
            }
            lblHjärtaUtskrift.Text += "\r\n";
        }

        private void btnRita_Click(object sender, EventArgs e)
        {
            int Storlek = int.Parse(tbxStorlek.Text);
            lblHjärtaUtskrift.Text = "";
            TextÄndring(Storlek);
            FärgÄndring(Färg);
            string Tecken = tbxTecken.Text;
            RitaHjärtaÖver(Tecken);
            Klass(Tecken);
            
            namn1(tbxNamn1.Text);
            namn2(tbxNamn2.Text);
        }

        void Klass(string Tecken)
        {
            int t = 4;
            int n = 32;
            int i = 8;
            int y = 32;
            int h = 0;
            while (0 < i)
            {

                for (int i1 = 0; i1 < h; i1++)
                {
                    lblHjärtaUtskrift.Text += "  ";
                }

                lblHjärtaUtskrift.Text += Tecken;

                while (0 < y)
                {
                    lblHjärtaUtskrift.Text += "  ";
                    y = y - 2;
                }

                lblHjärtaUtskrift.Text += Tecken + "\r\n";
                i--;
                y = n - t;
                t = t + 4;
                h++;
            }
            for (int i1 = 0; i1 < 8; i1++)
            {
                lblHjärtaUtskrift.Text += "  ";
            }
            lblHjärtaUtskrift.Text += " " + Tecken;
            lblHjärtaUtskrift.Text += "\r\n";
        }

        void FärgÄndring (int[] Färg)
        {
            //lblHjärtaUtskrift.ForeColor = Color.FromArgb(Färg[0], Färg[1], Färg[2]);
            lblHjärtaUtskrift.ForeColor = pbxVäljfärg.BackColor;
        }

        void TextÄndring (int Storlek)
        {
            Font font = new Font("Times New Roman", Storlek);
            lblHjärtaUtskrift.Font = font;
            lblNamn1Utskrift.Font = font;
            lblNamn2Utskrift.Font = font;
        }

        void namn1 (string namn)
        {
            lblNamn1Utskrift.Width = lblHjärtaUtskrift.Width;
            int Hight = lblHjärtaUtskrift.Size.Height;
            int X = lblHjärtaUtskrift.Location.X;
            Point Position = new Point(X, Hight + 150);
            lblNamn1Utskrift.Location = Position;
            lblNamn1Utskrift.Text = namn;
        }

        void namn2 (string namn)
        {
            lblNamn2Utskrift.Width = lblHjärtaUtskrift.Width;
            int Hight = lblHjärtaUtskrift.Location.Y;
            int X = lblHjärtaUtskrift.Location.X;
            Point Position = new Point(X, Hight - 150);
            lblNamn2Utskrift.Location = Position;
            lblNamn2Utskrift.Text = namn;
        }

        private void lblHjärtaUtskrift_Click(object sender, EventArgs e)
        {

        }
    }
}

