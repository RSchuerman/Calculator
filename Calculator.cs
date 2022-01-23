﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double output = 0;
        string operation = "";
        bool isOperationPerformed = false;
        bool pressedEql = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void dcmBtn_Click(object sender, EventArgs e)
        {
            if(!resultBox.Text.Contains("."))
                resultBox.Text += '.';
        }

        private void posNegBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = (double.Parse(resultBox.Text) * -1).ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || isOperationPerformed || pressedEql)
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '0';
            pressedEql = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0" || isOperationPerformed || pressedEql) && !resultBox.Text.Contains("."))
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '1';
            pressedEql = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0" || isOperationPerformed || pressedEql) && !resultBox.Text.Contains("."))
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '2';
            pressedEql = false;
        }
       
        private void btn3_Click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0" || isOperationPerformed || pressedEql) && !resultBox.Text.Contains("."))
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '3';
            pressedEql = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0" || isOperationPerformed || pressedEql) && !resultBox.Text.Contains("."))
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '4';
            pressedEql = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0" || isOperationPerformed || pressedEql) && !resultBox.Text.Contains("."))
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '5';
            pressedEql = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0" || isOperationPerformed || pressedEql) && !resultBox.Text.Contains("."))
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '6';
            pressedEql = false;
        }
       
        private void btn7_Click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0" || isOperationPerformed || pressedEql) && !resultBox.Text.Contains("."))
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '7';
            pressedEql = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0" || isOperationPerformed || pressedEql) && !resultBox.Text.Contains("."))
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '8';
            pressedEql = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0" || isOperationPerformed || pressedEql) && !resultBox.Text.Contains("."))
                resultBox.Clear();
            isOperationPerformed = false;
            resultBox.Text = resultBox.Text + '9';
            pressedEql = false;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if (output != 0)
            {
                eqlBtn.PerformClick();
                operation = "+";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }
            else
            {
                operation = "+";
                output = double.Parse(resultBox.Text);
                resultBox.Text = "0";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }  
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (output != 0)
            {
                eqlBtn.PerformClick();
                operation = "-";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }
            else
            {
                operation = "-";
                output = double.Parse(resultBox.Text);
                resultBox.Text = "0";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            if (output != 0)
            {
                eqlBtn.PerformClick();
                operation = "*";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }
            else
            {
                operation = "*";
                output = double.Parse(resultBox.Text);
                resultBox.Text = "0";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (output != 0)
            {
                eqlBtn.PerformClick();
                operation = "/";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }
            else
            {
                operation = "/";
                output = double.Parse(resultBox.Text);
                resultBox.Text = "0";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }
        }
      
        private void eqlBtn_Click(object sender, EventArgs e)
        {
            if (pressedEql)
            {
                resultBox.Text = "0";
                pressedEql = false;
                return;
            }
            switch(operation)
            {
                case "+":
                    
                    resultBox.Text = (output + double.Parse(resultBox.Text)).ToString();
                    lastValueLbl.Text = output.ToString();
                    isOperationPerformed = false;

                    break;

                case "-":
                    resultBox.Text = (output - double.Parse(resultBox.Text)).ToString();
                    lastValueLbl.Text = output.ToString();
                    isOperationPerformed = false;
                    break;

                case "*":
                    resultBox.Text = (output * double.Parse(resultBox.Text)).ToString();
                    lastValueLbl.Text = output.ToString();
                    isOperationPerformed = false;
                    break;

                case "/":
                    if (resultBox.Text != "0")
                    {
                        resultBox.Text = (output / double.Parse(resultBox.Text)).ToString();
                        lastValueLbl.Text = output.ToString();
                    } else
                    {
                        lastValueLbl.Text = "Cannot Divide by 0";
                        resultBox.Text = "0";
                        output = 0;
                    }
                    isOperationPerformed = false;
                    break;

                case "sqrt":
                    lastValueLbl.Text = "sqrt(" + resultBox.Text + ")";
                    resultBox.Text = (Math.Sqrt(double.Parse(resultBox.Text))).ToString();
                    isOperationPerformed = false;
                    break;

                case "^2":
                    lastValueLbl.Text = resultBox.Text + "^2";
                    resultBox.Text = (Math.Pow(double.Parse(resultBox.Text), 2)).ToString();
                    isOperationPerformed = false;
                    break;

                case "^":
                    resultBox.Text = Math.Pow(output, double.Parse(resultBox.Text)).ToString();
                    lastValueLbl.Text = output.ToString();
                    isOperationPerformed = false;
                    break;

                case "1/":
                    if (resultBox.Text != "0")
                    {
                        resultBox.Text = (output / double.Parse(resultBox.Text)).ToString();
                        lastValueLbl.Text = output.ToString();
                    }
                    else
                    {
                        lastValueLbl.Text = "Cannot Divide by 0";
                        resultBox.Text = "0";
                        output = 0;
                    }
                    isOperationPerformed = false;
                    break;

                default:
                    break;
            }
            output = double.Parse(resultBox.Text);
            lastValueLbl.Text = "";
            operation = "";
            pressedEql = true;
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            if (double.Parse(resultBox.Text) >= 0)
            {
                lastValueLbl.Text = "sqrt(" + resultBox.Text + ")";
                resultBox.Text = (Math.Sqrt(double.Parse(resultBox.Text))).ToString();
                output = double.Parse(resultBox.Text);
            }
            else
            {
                lastValueLbl.Text = "Imaginary Number";
                resultBox.Text = "0";
                output = 0;
            }
            isOperationPerformed = false;
        }

        private void sqrBtn_Click(object sender, EventArgs e)
        {
            lastValueLbl.Text = resultBox.Text + "^2";
            resultBox.Text = (Math.Pow(double.Parse(resultBox.Text), 2)).ToString();
            output = double.Parse(resultBox.Text);
            isOperationPerformed = false;
        }

        private void pwrBtn_Click(object sender, EventArgs e)
        {
            if (output != 0)
            {
                eqlBtn.PerformClick();
                operation = "^";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }
            else
            {
                operation = "^";
                output = double.Parse(resultBox.Text);
                resultBox.Text = "0";
                isOperationPerformed = true;
                lastValueLbl.Text = output + " " + operation;
            }
        }
        
        private void recBtn_Click(object sender, EventArgs e)
        {
            if (double.Parse(resultBox.Text) != 0)
            {
                lastValueLbl.Text = "1/" + resultBox.Text;
                resultBox.Text = (1 / (double.Parse(resultBox.Text))).ToString();
                output = double.Parse(resultBox.Text);
                isOperationPerformed = false;
            }
            else
            {
                lastValueLbl.Text = "Cannot Divide by 0";
                resultBox.Text = "0";
                output = 0;
            }
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            output = 0;
            lastValueLbl.Text = "";
            operation = "";
            isOperationPerformed = false;
        }

        private void dBtn_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 1)
            {
                if (resultBox.Text != "0")
                {
                    resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1, 1);
                }
            }
            else
                resultBox.Text = "0";
        }

    }
}
