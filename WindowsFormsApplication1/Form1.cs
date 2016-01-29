using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private char sign = ')';
        string input1 = "";
        string input2 = "";
        int decimalCount = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sign == ')')
            {
                input1 += this.b8.Text;
                display.Text += this.b8.Text;
            }
            else
            {
                input2 += this.b8.Text;
                display.Text += this.b8.Text;
            }
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            input2 = display.Text;
            var x = double.Parse(input1, new NumberFormatInfo() { NumberDecimalSeparator = "." });
            var y = double.Parse(input2, new NumberFormatInfo() { NumberDecimalSeparator = "." });

            double ans = 0;
            if (sign == '+')
                ans = x + y;
            if (sign == '-')
                ans = x - y;
            if (sign == '*')
                ans = x * y;
            if (sign == '/')
                ans = x / y;
           
            display.Text = ans.ToString();

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if(sign==')')
            {
                display.Text += this.b1.Text;
            }
            else
            {
                display.Text += this.b1.Text;
            }
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            sign = '+';
            input1 = display.Text;
            display.Text = "";
            decimalCount = 0;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if(display.Text!="")
            {
                if (sign == ')')
                {
                    display.Text += this.b0.Text;
                }
                else
                {
                    display.Text += this.b0.Text;
                }
            }
        }

        private void bDec_Click(object sender, EventArgs e)
        {
            if (decimalCount == 0)
            {
                display.Text += this.bDec.Text;
                decimalCount=1;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (sign == ')')
            {
                display.Text += this.b2.Text;
            }
            else
            {
                display.Text += this.b2.Text;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (sign == ')')
            {
                display.Text += this.b3.Text;
            }
            else
            {
                display.Text += this.b3.Text;
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (sign == ')')
            {
                display.Text += this.b5.Text;
            }
            else
            {
                display.Text += this.b4.Text;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (sign == ')')
            {
                display.Text += this.b5.Text;
            }
            else
            {
                display.Text += this.b5.Text;
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (sign == ')')
            {
                display.Text += this.b6.Text;
            }
            else
            {
                display.Text += this.b6.Text;
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (sign == ')')
            {
                display.Text += this.b7.Text;
            }
            else
            {
                display.Text += this.b7.Text;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (sign == ')')
            {
                display.Text += this.b9.Text;
            }
            else
            {
                display.Text += this.b9.Text;
            }
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            sign = '-';
            input1 = display.Text;
            display.Text = "";
            decimalCount = 0;
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            sign = '/';
            input1 = display.Text;
            display.Text = "";
            decimalCount = 0;
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            sign = '*';
            input1 = display.Text;
            display.Text = "";
            decimalCount = 0;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            input1 = "";
            input2 = "";
            display.Text = "";
            decimalCount = 0;
            sign = ')';
        }

        private void bFac_Click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                if (display.Text[0] != '-')
                {
                    string input = "-";
                    input += display.Text;
                    display.Text = input;
                }

                else
                    if (display.Text[0] == '-')
                    {
                        string input = display.Text.Remove(0, 1);
                        display.Text = input;
                    }
            }
        }

        private void display_KeyDown(object sender, KeyPressEventArgs e)
        {
            int a = e.KeyChar;
            if (e.KeyChar == '.' && decimalCount == 0)
            {
                decimalCount = 1;
            }
            else
            if (a < 48 || a > 57)
            {
                e.KeyChar = '\0';
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                if (display.Text[display.Text.Length - 1] == '.')
                {
                    decimalCount = 0;
                }
                string input = display.Text.Remove(display.Text.Length - 1, 1);
                display.Text = input;
            }
        }
    }
}
