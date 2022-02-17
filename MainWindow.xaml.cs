
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_UI_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool svc = false; // Switch control variable
        public char[] invalidFormat = { '+', '-', '*', '/', '%', '(', ')', 'E' };

        private readonly CalculatorFixture calc = new CalculatorFixture();

        /// <summary>
        ///  Makes a null return present "ERROR" to the user instead.
        /// </summary>
        private void NullToError()
        {
            if (calc.result == null && calc.dresult == null)
            {
                txtResult.Text = "ERROR";
            }

            if (calc.dresult == Convert.ToDouble("∞"))
            {
                txtResult.Text = "ERROR";
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "ERROR";
            }

            if (txtResult.Text == "NaN")
            {
                txtResult.Text = "ERROR";
            }
        }

        private void ErrorToZero()
        {
            if (txtResult.Text == "ERROR")
            {
                txtResult.Text = "0";
                txtHistory.Text = "0";
            }
        }

        // Event Handlers

        // Handler for all Number buttons
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {


                ErrorToZero();
                switch ((btn.Name))
                {
                    case "btnZero":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "0";
                        }
                        else
                        {
                            txtResult.Text += "0";
                        }
                        break;

                    case "btnOne":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "1";
                        }
                        else
                        {
                            txtResult.Text += "1";
                        }
                        break;

                    case "btnTwo":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "2";
                        }
                        else
                        {
                            txtResult.Text += "2";
                        }
                        break;

                    case "btnThree":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "3";
                        }
                        else
                        {
                            txtResult.Text += "3";
                        }
                        break;

                    case "btnFour":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "4";
                        }
                        else
                        {
                            txtResult.Text += "4";
                        }
                        break;

                    case "btnFive":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "5";
                        }
                        else
                        {
                            txtResult.Text += "5";
                        }
                        break;

                    case "btnSix":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "6";
                        }
                        else
                        {
                            txtResult.Text += "6";
                        }
                        break;

                    case "btnSeven":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "7";
                        }
                        else
                        {
                            txtResult.Text += "7";
                        }
                        break;

                    case "btnEight":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "8";
                        }
                        else
                        {
                            txtResult.Text += "8";
                        }
                        break;

                    case "btnNine":
                        if (txtResult.Text == "0")
                        {
                            txtResult.Text = "9";
                        }
                        else
                        {
                            txtResult.Text += "9";
                        }
                        break;
                }
            }
        }
       
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            if (txtResult.Text == "ERROR")
            {

            }
            else
            {
                if (txtResult.Text.Length >= 1)
                {
                    txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);

                    if (txtResult.Text == "")
                    {
                        txtResult.Text = "0";
                    }
                }
            }
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            calc.Clear();
            txtResult.Text = calc.GetDisplay();
        }

        private void BtnClearE_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            calc.Clear();
            txtHistory.Text = "";
            txtResult.Text = calc.GetDisplay();
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            if (txtResult.Text != "ERROR")
            {
                if (txtResult.Text == "0")
                {
                    txtResult.Text = "0.";
                }
                else if (txtResult.Text == "-0")
                {
                    txtResult.Text = "-0.";
                }
                else
                {
                    txtResult.Text += ".";
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            if (txtResult.Text == "0")
            {
                txtResult.Text = " + ";
            }
            else
            {
                txtResult.Text += " + ";
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            if (txtResult.Text == "0")
            {
                txtResult.Text = " - ";
            }
            else
                txtResult.Text += " - ";
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            txtResult.Text += " * ";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            txtResult.Text += " / ";
        }



        private void BtnOpenB_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            if (txtResult.Text == "0")
            {
                txtResult.Text = "(";
                svc = true;
            }
            else
            {
                txtResult.Text += "(";
            }
        }

        private void BtnCloseB_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            if (txtResult.Text == "0")
            {
                txtResult.Text = ")";
                svc = true;
            }
            else
            {
                txtResult.Text += ")";
            }
        }

        private void BtnSqr_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            if (!CheckFormat())
            {
                if (!txtResult.Text.Contains('.'))
                {
                    calc.result = CalculatorFixture.Sqr(Convert.ToInt32(txtResult.Text));
                    txtHistory.Text = txtResult.Text + "² = ";
                    txtResult.Text = Convert.ToString(calc.result);
                }
                else if (txtResult.Text.Contains('.'))
                {
                    calc.dresult = CalculatorFixture.Sqr(Convert.ToDouble(txtResult.Text));
                    txtHistory.Text = txtResult.Text + "² = ";
                    txtResult.Text = Convert.ToString(calc.dresult);
                }
                else
                {
                    calc.result = null;
                }
            }
            else
            {
                calc.result = null;
            }
            NullToError();
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            if (CheckFormat())
            {
                txtResult.Text = "ERROR";
            }
            else
            {
                calc.dresult = CalculatorFixture.Sqrt(Convert.ToDouble(txtResult.Text));
                txtHistory.Text = txtResult.Text + "√ = ";
                txtResult.Text = Convert.ToString(calc.dresult);
            }
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            if (txtResult.Text != "ERROR")
            {
                if (txtResult.Text.StartsWith("-"))
                {
                    txtResult.Text = txtResult.Text.Remove(0, 1);
                }

                else if (txtResult.Text == "0")
                {
                    txtResult.Text = "-";
                }

                else
                {
                    txtResult.Text = "-" + txtResult.Text;
                }
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            ErrorToZero();
            txtHistory.Text += txtResult.Text + " = ";
            if (txtResult.Text.Contains('.') || txtResult.Text.Contains('/'))
            {
                calc.dresult = CalculatorFixture.EvaluateD(txtResult.Text);
                txtResult.Text = Convert.ToString(calc.dresult);
                //txtHistory.Text += Convert.ToString(calc.dresult) + ", ";
            }
            else
            {
                calc.result = CalculatorFixture.EvaluateI(txtResult.Text);
                txtResult.Text = Convert.ToString(calc.result);
                //txtHistory.Text += Convert.ToString(calc.result) + ", ";
            }
            NullToError();
        }

        /// <summary>
        /// This method is used to check for any characters that will cause a formatException
        /// </summary>
        public bool CheckFormat()
        {
            bool invalidCharacters = false;

            for (int i = 0; i < invalidFormat.Length; i++)
            {
                if (!txtResult.Text.Contains(invalidFormat[i]))
                {
                    invalidCharacters = false;
                }
                else
                {
                    invalidCharacters = true;
                    break;
                }
            }

            if (invalidCharacters == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
