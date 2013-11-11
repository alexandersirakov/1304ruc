using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1;
        double number2;
        double result;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] text = textBox1.Text.Split();

            if (text.Contains("+") || text.Contains("-") || text.Contains("*") || text.Contains("/"))
            {
                if (text[1] == "+")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 + number2;
                    textBox1.Text = result.ToString() + " + ";

                }

                if (text[1] == "-")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 - number2;
                    textBox1.Text = result.ToString() + " + ";
                }

                if (text[1] == "*")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 * number2;
                    textBox1.Text = result.ToString() + " + ";
                }

                if (text[1] == "/")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 / number2;
                    textBox1.Text = result.ToString() + " + ";
                }
            }
            else
            {
                textBox1.Text += " + ";
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            string[] text = textBox1.Text.Split();

            if (text.Contains("+") || text.Contains("-") || text.Contains("*") || text.Contains("/"))
            {
                if (text[1] == "+")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 + number2;
                    textBox1.Text = result.ToString() + " - ";

                }

                if (text[1] == "-")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 - number2;
                    textBox1.Text = result.ToString() + " - ";
                }

                if (text[1] == "*")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 * number2;
                    textBox1.Text = result.ToString() + " - ";
                }

                if (text[1] == "/")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 / number2;
                    textBox1.Text = result.ToString() + " - ";
                }
            }
            else
            {
                textBox1.Text += " - ";
            }           
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string[] text = textBox1.Text.Split();

            if (text.Contains("+") || text.Contains("-") || text.Contains("*") || text.Contains("/"))
            {
                if (text[1] == "+")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 + number2;
                    textBox1.Text = result.ToString() + " * ";

                }

                if (text[1] == "-")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 - number2;
                    textBox1.Text = result.ToString() + " * ";
                }

                if (text[1] == "*")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 * number2;
                    textBox1.Text = result.ToString() + " * ";
                }

                if (text[1] == "/")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 / number2;
                    textBox1.Text = result.ToString() + " * ";
                }
            }
            else
            {
                textBox1.Text += " * ";
            } 
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string[] text = textBox1.Text.Split();

            if (text.Contains("+") || text.Contains("-") || text.Contains("*") || text.Contains("/"))
            {
                if (text[1] == "+")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 + number2;
                    textBox1.Text = result.ToString() + " / ";

                }

                if (text[1] == "-")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 - number2;
                    textBox1.Text = result.ToString() + " / ";
                }

                if (text[1] == "*")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 * number2;
                    textBox1.Text = result.ToString() + " / ";
                }

                if (text[1] == "/")
                {
                    number1 = double.Parse(text[0]);
                    number2 = double.Parse(text[2]);
                    result = number1 / number2;
                    textBox1.Text = result.ToString() + " / ";
                }
            }
            else
            {
                textBox1.Text += " / ";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string[] text = textBox1.Text.Split();

            if (text[1] == "+")
            {
                number1 = double.Parse(text[0]);
                number2 = double.Parse(text[2]);
                result = number1 + number2;
                textBox1.Text = result.ToString();
            }

            if (text[1] == "-")
            {
                number1 = double.Parse(text[0]);
                number2 = double.Parse(text[2]);
                result = number1 - number2;
                textBox1.Text = result.ToString();
            }

            if (text[1] == "*")
            {
                number1 = double.Parse(text[0]);
                number2 = double.Parse(text[2]);
                result = number1 * number2;
                textBox1.Text = result.ToString();
            }

            if (text[1] == "/")
            {
                number1 = double.Parse(text[0]);
                number2 = double.Parse(text[2]);
                result = number1 / number2;
                textBox1.Text = result.ToString();
            }

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textBox1.Text);
            result = Math.Sqrt(number1);
            textBox1.Text = result.ToString();
            number1 = 0;
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textBox1.Text);
            result = Math.Pow(number1,2);
            textBox1.Text = result.ToString();
            number1 = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(",")))
            {
                textBox1.Text += ",";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0"; 
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textBox1.Text);
            number1 = -(number1);
            textBox1.Text = number1.ToString();
        }
    }
}
