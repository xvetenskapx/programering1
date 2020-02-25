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
            Stack<char> Ord132 = new Stack<char>();
            Stack<string> OmväntOrd132 = new Stack<string>();
            Ord132.Push(char.Parse(tbxOrd132.Text));
            while (Ord132.Count != 0)
            {
                lblSvarPalindrom.Text += Ord132;
                
            }
        }
    }
}
