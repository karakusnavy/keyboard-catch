using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMyDearly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string mtn = "";
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                mtn += e.KeyChar.ToString();
                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        mtn += e.KeyChar.ToString();
                        e.Handled = true;
                        break;
                }
            }
            else if (e.KeyChar == (char)Keys.Escape)
            mtn += " {{ESC}} ";
            else if (e.KeyChar == (char)Keys.Space)
            mtn += " ";
            else if (e.KeyChar == (char)Keys.Return)
            mtn += " {{Enter}} ";
            else if (e.KeyChar == (char)Keys.Tab)
            mtn += " {{Tab}} ";
            else if (e.KeyChar == (char)Keys.Back)
            mtn += "  (1SİL)  ";
            else
            mtn += e.KeyChar.ToString();
            textBox1.Text = mtn;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
