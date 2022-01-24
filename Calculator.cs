using System;
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
        bool historyIsClicked = false;
        double[] historyVals = new double[6] { 0,0,0,0,0,0 };

        public Calculator()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
            Size = new Size(313, 440);
        }

        public void Set_History(double first, string second, string operation)
        {
            string output = "";
            double outputVal = 0;
            switch (operation)
            {
                case "+":
                    outputVal = (first + double.Parse(second));
                    output = first + " + " + second + " = " + outputVal;
                    break;

                case "-":
                    outputVal = (first - double.Parse(second));
                    output = first + " - " + second + " = " + outputVal;
                    break;

                case "*":
                    outputVal = (first * double.Parse(second));
                    output = first + " x " + second + " = " + outputVal;
                    break;

                case "/":
                    outputVal = (first / double.Parse(second));
                    output = first + " / " + second + " = " + outputVal;
                    break;

                case "1/":
                    outputVal = (1 / double.Parse(second));
                    output = "1/" + second + " = " + outputVal;
                    break;

                case "^":
                    outputVal = (Math.Pow(first, double.Parse(second)));
                    output = first + " ^ " + second + " = " + outputVal;
                    break;

                case "^2":
                    outputVal = (Math.Pow(double.Parse(second), 2));
                    output =  second + "^2" + " = " + outputVal;
                    break;

                case "sqrt":
                    outputVal = (Math.Sqrt(double.Parse(second)));
                    output = "sqrt( " + second + " ) = " + outputVal;
                    break;
            }

            if(histValBtn1.Text == "")
            {
                histValBtn1.Text = output;
                historyVals[0] = outputVal;
            }
            else if (histValBtn1.Text != "" && histValBtn2.Text == "")
            {
                histValBtn2.Text = histValBtn1.Text;
                histValBtn1.Text = output;
                historyVals[1] = historyVals[0];
                historyVals[0] = outputVal;
            }
            else if (histValBtn1.Text != "" && histValBtn2.Text != "" && histValBtn3.Text == "")
            {
                histValBtn3.Text = histValBtn2.Text;
                histValBtn2.Text = histValBtn1.Text;
                histValBtn1.Text = output;
                historyVals[2] = historyVals[1];
                historyVals[1] = historyVals[0];
                historyVals[0] = outputVal;
            }
            else if (histValBtn1.Text != "" && histValBtn2.Text != "" && histValBtn3.Text != "" && histValBtn4.Text == "")
            {
                histValBtn4.Text = histValBtn3.Text;
                histValBtn3.Text = histValBtn2.Text;
                histValBtn2.Text = histValBtn1.Text;
                histValBtn1.Text = output;
                historyVals[3] = historyVals[2];
                historyVals[2] = historyVals[1];
                historyVals[1] = historyVals[0];
                historyVals[0] = outputVal;
            }
            else if (histValBtn1.Text != "" && histValBtn2.Text != "" && histValBtn3.Text != "" && histValBtn4.Text != "" && histValBtn5.Text == "")
            {
                histValBtn5.Text = histValBtn4.Text;
                histValBtn4.Text = histValBtn3.Text;
                histValBtn3.Text = histValBtn2.Text;
                histValBtn2.Text = histValBtn1.Text;
                histValBtn1.Text = output;
                historyVals[4] = historyVals[3];
                historyVals[3] = historyVals[2];
                historyVals[2] = historyVals[1];
                historyVals[1] = historyVals[0];
                historyVals[0] = outputVal;
            }
            else if (histValBtn1.Text != "" && histValBtn2.Text != "" && histValBtn3.Text != "" && histValBtn4.Text != "" && histValBtn5.Text != "" && histValBtn6.Text == "")
            {
                histValBtn6.Text = histValBtn5.Text;
                histValBtn5.Text = histValBtn4.Text;
                histValBtn4.Text = histValBtn3.Text;
                histValBtn3.Text = histValBtn2.Text;
                histValBtn2.Text = histValBtn1.Text;
                histValBtn1.Text = output;
                historyVals[5] = historyVals[4];
                historyVals[4] = historyVals[3];
                historyVals[3] = historyVals[2];
                historyVals[2] = historyVals[1];
                historyVals[1] = historyVals[0];
                historyVals[0] = outputVal;
            }
            else
            {
                histValBtn6.Text = histValBtn5.Text;
                histValBtn5.Text = histValBtn4.Text;
                histValBtn4.Text = histValBtn3.Text;
                histValBtn3.Text = histValBtn2.Text;
                histValBtn2.Text = histValBtn1.Text;
                histValBtn1.Text = output;
                historyVals[5] = historyVals[4];
                historyVals[4] = historyVals[3];
                historyVals[3] = historyVals[2];
                historyVals[2] = historyVals[1];
                historyVals[1] = historyVals[0];
                historyVals[0] = outputVal;
            }
        }

        void Calculator_KeyPress(object sernder, KeyPressEventArgs e)
        {
            switch (e.KeyChar)//(int)e.KeyChar)
            {
                case '0':
                    btn0.PerformClick();
                    break;

                case '1':
                    btn1.PerformClick();
                    break;

                case '2':
                    btn2.PerformClick();
                    break;

                case '3':
                    btn3.PerformClick();
                    break;

                case '4':
                    btn4.PerformClick();
                    break;

                case '5':
                    btn5.PerformClick();
                    break;

                case '6':
                    btn6.PerformClick();
                    break;

                case '7':
                    btn7.PerformClick();
                    break;

                case '8':
                    btn8.PerformClick();
                    break;

                case '9':
                    btn9.PerformClick();
                    break;

                case '+':
                    plusBtn.PerformClick();
                    break;

                case '-':
                    subBtn.PerformClick();
                    break;

                case '*':
                    mulBtn.PerformClick();
                    break;

                case '/':
                    divBtn.PerformClick();
                    break;

                case '=':
                    eqlBtn.PerformClick();
                    break;

                case '^':
                    pwrBtn.PerformClick();
                    break;

                case '.':
                    dcmBtn.PerformClick();
                    break;

                default:
                        //MessageBox.Show("Form.KeyPress: '" +
                        //               e.KeyChar.ToString() + "' consumed.");
                        //e.Handled = true;
                        break;
            }
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
        #region Number Buttons
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
        #endregion

        #region Operator Buttons
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
        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            if (double.Parse(resultBox.Text) >= 0)
            {
                Set_History(output, resultBox.Text, "sqrt");
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
            Set_History(output, resultBox.Text, "^2");
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
                Set_History(output, resultBox.Text, "1/");
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
        #endregion

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
                    Set_History(output, resultBox.Text, "+");
                    resultBox.Text = (output + double.Parse(resultBox.Text)).ToString();
                    lastValueLbl.Text = output.ToString();
                    isOperationPerformed = false;

                    break;

                case "-":
                    Set_History(output, resultBox.Text, "-");
                    resultBox.Text = (output - double.Parse(resultBox.Text)).ToString();
                    lastValueLbl.Text = output.ToString();
                    isOperationPerformed = false;
                    break;

                case "*":
                    Set_History(output, resultBox.Text, "*");
                    resultBox.Text = (output * double.Parse(resultBox.Text)).ToString();
                    lastValueLbl.Text = output.ToString();
                    isOperationPerformed = false;
                    break;

                case "/":
                    if (resultBox.Text != "0")
                    {
                        Set_History(output, resultBox.Text, "/");
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

                case "^":
                    Set_History(output, resultBox.Text, "^");
                    resultBox.Text = Math.Pow(output, double.Parse(resultBox.Text)).ToString();
                    lastValueLbl.Text = output.ToString();
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

        #region C CE D Buttons
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
        #endregion

        private void histBtn_Click(object sender, EventArgs e)
        {
            if (!historyIsClicked)
            {
                Size = new Size(486, 440);
                historyIsClicked = true;
            }
            else
            {
                Size = new Size(313, 440);
                historyIsClicked = false;
            }
             
            
        }

        private void histValBtn1_Click(object sender, EventArgs e)
        {
            resultBox.Text = historyVals[0].ToString();
            if (pressedEql)
            {
                output = 0;
                pressedEql = false;
                return;
            }
        }

        private void histValBtn2_Click(object sender, EventArgs e)
        {
            resultBox.Text = historyVals[1].ToString();
            if (pressedEql)
            {
                output = 0;
                pressedEql = false;
                return;
            }
        }

        private void histValBtn3_Click(object sender, EventArgs e)
        {
            resultBox.Text = historyVals[2].ToString();
            if (pressedEql)
            {
                output = 0;
                pressedEql = false;
                return;
            }
        }

        private void histValBtn4_Click(object sender, EventArgs e)
        {
            resultBox.Text = historyVals[3].ToString();
            if (pressedEql)
            {
                output = 0;
                pressedEql = false;
                return;
            }
        }

        private void histValBtn5_Click(object sender, EventArgs e)
        {
            resultBox.Text = historyVals[4].ToString();
            if (pressedEql)
            {
                output = 0;
                pressedEql = false;
                return;
            }
        }

        private void histValBtn6_Click(object sender, EventArgs e)
        {
            resultBox.Text = historyVals[5].ToString();
            if (pressedEql)
            {
                output = 0;
                pressedEql = false;
                return;
            }
        }
    }

}
