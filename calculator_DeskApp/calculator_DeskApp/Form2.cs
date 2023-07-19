using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_DeskApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int num1;
        private int num2;
        private char opt;


        private void btn_equal_Click(object sender, EventArgs e)

        {
            num2 = int.Parse(richTextBox1.Text);
            
            switch (opt)
            {
                case '+':
                    richTextBox1.Text = (num1 + num2).ToString();
                break;
                case '-':
                    richTextBox1.Text = (num1 - num2).ToString();
                break;
                case '/':
                    richTextBox1.Text = (num1 / num2).ToString();
                break;
                case '*':
                    richTextBox1.Text = (num1 * num2).ToString();
                break;
                case '%':
                    richTextBox1.Text = (num1 % num2).ToString();
                break;
            }

            opt = '=';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if(opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "9";
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            num1 = num2 = 0;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "6";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(richTextBox1.Text);
            opt = '+';
            richTextBox1.Text = "";


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "3";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(richTextBox1.Text);
            opt = '-';
            richTextBox1.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (opt == '=')
            {
                richTextBox1.Text = "";
                opt = '.';
            }
            richTextBox1.Text += "0";
        }

        private void btn_moduls_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(richTextBox1.Text);
            opt = '%';
            richTextBox1.Text = "";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(richTextBox1.Text);
            opt = '/';
            richTextBox1.Text = "";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(richTextBox1.Text);
            opt = '*';
            richTextBox1.Text = "";
        }
    }
}
