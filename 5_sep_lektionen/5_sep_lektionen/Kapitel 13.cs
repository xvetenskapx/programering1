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
    public partial class Kapitel_13 : Form
    {
        Stack<string> stadStack = new Stack<string>();

        public Kapitel_13()
        {
            InitializeComponent();
        }



        private void btnPush_Click(object sender, EventArgs e)
        {
            stadStack.Push(tbxStad.Text);
            tbxStadIn.Text += tbxStad.Text + "\r\n";
            tbxStad.Text = "";
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            while (stadStack.Count != 0)
            {
                string stad = stadStack.Pop();
                tbxStadUt.AppendText(stad + "\r\n");
            }
        }

        private void btnKontrollera132_Click(object sender, EventArgs e)
        {
            lblSvarPalindrom.Text = "";
            if (Palindrom(tbxOrd132.Text)
            {

            }



        }

        bool Palindrom(String Ord)
        {
            char y;
            int i = 0;
            string S1 = Ord;
            int t = S1.Length;
            Stack<char> Ord132 = new Stack<char>();
            Stack<char> OmväntOrd132 = new Stack<char>();
            Stack<char> Ord132Reserv = new Stack<char>();
            while (t - 1 >= i)
            {
                y = S1[i];
                Ord132.Push(y);
                Ord132Reserv.Push(y);
                i++;
            }
            i = 0;
            t = Ord132.Count - 1;
            while (t >= i)
            {
                OmväntOrd132.Push(Ord132.Pop());
                i++;
            }

            i = 0;
            t = Ord132Reserv.Count - 1;
            while (t >= i)
            {
                if (Ord132Reserv.Peek() == OmväntOrd132.Peek())
                {
                    Ord132Reserv.Pop();
                    OmväntOrd132.Pop();
                    i++;
                }
                else
                {
                    i = S1.Length + 1;
                }
            }
            if (S1.Length.Equals(i))
            {
                return true;
                //lblSvarPalindrom.Text = "Det är ett Palindrom";
            }
            else
            {
                return false;
                //lblSvarPalindrom.Text = "Det är ett inte Palindrom";
            }
        }
    }
}
