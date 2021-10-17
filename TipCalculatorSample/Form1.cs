using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculatorSample
{
    public partial class Form1 : Form
    {
        // Declaring Variables for obtaining values from the form and for
        // the calculation purposes.
        string val;
        int nop, tipPerc;
        float billVal, tipPP, totalPP;
        

        
        public Form1()
        {
            InitializeComponent();
        }


        // This method blanks out the 'Bill' text box when user wants to enter
        // a value other than the default value. Here, default value is 0.00.
        private void txtBill_Enter(object sender, EventArgs e)
        {
            if (txtBill.Text == "0.00")
            {
                txtBill.Text = "";
                txtBill.ForeColor = Color.Black;
            }
        }


        // This method checks if user has given invalid input in the 'Bill' text box
        // on leaving the text box.
        private void textBill_Leave(object sender, EventArgs e)
        {
            if (txtBill.Text == "")
            {
                // If user does not enter anything, set default value in textbox.
                txtBill.Text = "0.00";
                txtBill.ForeColor = Color.Silver;
            }
            else
            {
                try
                {
                    billVal = float.Parse(txtBill.Text);
                    if (billVal < 0)
                    {
                        // Error message is shown in case of negative input.
                        MessageBox.Show("Negative Bill Value not Allowed");
                        txtBill.Text = "0.00";
                        txtBill.ForeColor = Color.Silver;
                    }
                    else
                    {
                        txtBill.Text = billVal.ToString("0.00");
                        txtBill.ForeColor = Color.Black;
                    }
                }
                catch(FormatException)
                {
                    // Message is shown in case of invalid input
                    // and default value is set in the text box.
                    MessageBox.Show("Please enter valid Bill Amount");
                    txtBill.Text = "0.00";
                    txtBill.ForeColor = Color.Silver;
                }
                catch (Exception exp)
                {
                    // All exceptions other than FormatExceptions are handled
                    // using this code segment.
                    MessageBox.Show("Exception Handled " + exp);
                    txtBill.Text = "0.00";
                    txtBill.ForeColor = Color.Silver;
                }
            }
        }

        // This method blanks out the 'Tip%' text box when user wants to enter
        // a value other than the default value. Here, default value is 0%.
        private void txtTip_Enter(object sender, EventArgs e)
        {
            if (txtTipPercent.Text == "0%")
            {
                txtTipPercent.Text = "";
                txtTipPercent.ForeColor = Color.Black;
            }
        }


        // This method checks if user has given invalid input in the 'Tip%' text box
        // on leaving the textbox.
        private void txtTipPercent_Leave(object sender, EventArgs e)
        {
            if (txtTipPercent.Text == "")
            {
                // If user does not enter anything, set default value in textbox.
                txtTipPercent.Text = "0%";
                txtTipPercent.ForeColor = Color.Silver;
            }
            try
            {
                val = txtTipPercent.Text;
                if (val[val.Length - 1] == '%')
                {
                    val = val.Substring(0, val.Length - 1);
                    tipPerc = Int16.Parse(val);
                    if((tipPerc < 0) || (tipPerc > 100))
                    {
                        // Checking if the value entered in the 'Tip%' text box
                        // is within valid range [0%-100%].
                        MessageBox.Show("Please enter value within valid range");
                        txtTipPercent.Text = "0%";
                        txtTipPercent.ForeColor = Color.Silver;
                    }
                }
                else if ((val[val.Length - 1] < '0') || (val[val.Length - 1] > '9'))
                {
                    // Checking if anything other than '%' symbol is at the end of input text.
                    throw new Exception("Invalid input");
                }
                else
                {
                    tipPerc = Int16.Parse(val);
                    if((tipPerc >= 0) && (tipPerc <= 100))
                    {
                        // Converting valid numeric input to standard input form of the text box.
                        txtTipPercent.Text = tipPerc.ToString() + '%';
                        txtTipPercent.ForeColor = Color.Black;
                    }
                    else
                    {
                        // Handling invalid input.
                        MessageBox.Show("Please enter within valid range");
                        txtTipPercent.Text = "0%";
                        txtTipPercent.ForeColor = Color.Silver;
                    }
                }

            }
            catch (FormatException)
            {
                // Handling invalid input with '%' sign.
                MessageBox.Show("Please enter the valid Tip%");
                txtTipPercent.Text = "0";
                txtTipPercent.ForeColor = Color.Silver;
            }
            catch (Exception exp)
            {
                // All exceptions other than FormatExceptions are handled
                // using this code segment.
                MessageBox.Show("Exception Handled " + exp);
                txtTipPercent.Text = "0%";
                txtTipPercent.ForeColor = Color.Silver;
            }

        }


        // This method blanks out the 'Number of People' text box when user wants to enter
        // a value other than the default value. Here, default value is 0.
        private void txtNOP_Enter(object sender, EventArgs e)
        {
            if (txtNumOfPeo.Text == "0")
            {
                txtNumOfPeo.Text = "";
                txtNumOfPeo.ForeColor = Color.Black;
            }
        }


        // This method checks if user has entered anything invalid in the
        // 'Number of People' text box on leaving the text box.
        private void txtNOP_Leave(object sender, EventArgs e)
        {
            if (txtNumOfPeo.Text == "")
            {
                // If user does not enter anything, set default value in textbox.
                txtNumOfPeo.Text = "0";
                txtNumOfPeo.ForeColor = Color.Silver;
            }
            try
            {
                nop = Int32.Parse(txtNumOfPeo.Text);
                if (nop < 0)
                {
                    // Error message is shown in case of negative input
                    // and default value is set in the text box.
                    MessageBox.Show("Negative Number of People not allowed");
                    txtNumOfPeo.Text = "0";
                    txtNumOfPeo.ForeColor = Color.Silver;
                }
            }
            catch (FormatException)
            {
                // Error message is shown in case of invalid input
                // and default value is set in the text box.
                MessageBox.Show("Please enter the valid Number of People");
                txtNumOfPeo.Text = "0";
                txtNumOfPeo.ForeColor = Color.Silver;
            }
            catch (Exception exp)
            {
                // All exceptions other than FormatExceptions are handled
                // using this code segment.
                MessageBox.Show("Exception Handled " + exp);
                txtNumOfPeo.Text = "0";
                txtNumOfPeo.ForeColor = Color.Silver;
            }
        }

        // This method maintains the functioning of 'Tip%' increment button '+'.
        private void btnTipInc_Click(object sender, EventArgs e)
        {
            try
            {
                val = txtTipPercent.Text;
                val = val.Substring(0, val.Length - 1);
                tipPerc = Int16.Parse(val);
                if ((tipPerc >= 0) && (tipPerc < 100))
                {
                    // Code segment to increase tip pecentage by 1 unit
                    // if resultant value is in the range [0%-100%].
                    tipPerc = tipPerc + 1;
                }
                txtTipPercent.Text = tipPerc.ToString() + "%";
                txtTipPercent.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                // Error message is shown in case of invalid input
                // and default value is set in the text box.
                MessageBox.Show("Please enter the valid Tip%");
                txtTipPercent.Text = "0";
                txtTipPercent.ForeColor = Color.Silver;
            }
            catch (Exception exp)
            {
                // All exceptions other than FormatExceptions are handled
                // using this code segment.
                Console.WriteLine("Exception Caught!" + exp);
            }
        }


        // This method maintains the functioning of 'Tip%' decrement button '-'.
        private void btnTipDec_Click(object sender, EventArgs e)
        {
            try
            {
                val = txtTipPercent.Text;
                val = val.Substring(0, val.Length - 1);
                tipPerc = Int16.Parse(val);
                if ((tipPerc > 0) && (tipPerc <= 100))
                {
                    // Code segment to decrease tip pecentage by 1 unit
                    // if resultant value is in the range [0%-100%].
                    tipPerc = tipPerc - 1;
                }
                txtTipPercent.Text = tipPerc.ToString() + "%";
                txtTipPercent.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                // Error message is shown in case of invalid input
                // and default value is set in the text box.
                MessageBox.Show("Please enter the valid Tip%");
                txtTipPercent.Text = "0";
                txtTipPercent.ForeColor = Color.Silver;
            }
            catch (Exception exp)
            {
                // All exceptions other than FormatExceptions are handled
                // using this code segment.
                Console.WriteLine("Exception Caught!" + exp);
            }
        }


        // This method maintains the functioning of 'Number of People'
        // increment button '+'.
        private void btnNOPInc_Click(object sender, EventArgs e)
        {
            try
            {
                nop = Int32.Parse(txtNumOfPeo.Text);
                if (nop >= 0)
                {
                    // Code segment to increase the number of people
                    // by 1 unit if resultant value is non-negative.
                    nop = nop + 1;
                }
                txtNumOfPeo.Text = nop.ToString();
                txtNumOfPeo.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                // Error message is shown in case of invalid input
                // and default value is set in the text box.
                MessageBox.Show("Please enter the valid Number of People");
                txtNumOfPeo.Text = "0";
                txtNumOfPeo.ForeColor = Color.Silver;
            }
        }


        // This method maintains the functioning of 'Number of People'
        // decrement button '-'.
        private void btnNOPDec_Click(object sender, EventArgs e)
        {
            try
            {
                nop = Int32.Parse(txtNumOfPeo.Text);
                if (nop > 0)
                {
                    // Code segment to decrease the number of people
                    // by 1 unit if resultant value non-negative.
                    nop = nop - 1;
                }
                txtNumOfPeo.Text = nop.ToString();
                txtNumOfPeo.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                // Error message is shown in case of invalid input
                // and default value is set in the text box.
                MessageBox.Show("Please enter the valid Number of People");
                txtNumOfPeo.Text = "0";
                txtNumOfPeo.ForeColor = Color.Silver;
            }
        }


        // This method defines the functionality of 'Calculate' button.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Extracting user inputs from the form.
                billVal = float.Parse(txtBill.Text);

                val = txtTipPercent.Text;
                tipPerc = Int16.Parse(val.Substring(0, val.Length - 1));

                nop = Int32.Parse(txtNumOfPeo.Text);

                if (billVal == 0)
                {
                    // If entered bill value is 0, then set 'tip per person'
                    // and 'total per person' to 0.
                    tipPP = 0;
                    totalPP = 0;
                }
                else if (nop == 0)
                {
                    // If 'number of people' is 0, then display error message.
                    MessageBox.Show("Number of People cannot be zero.");
                }
                else
                {
                    // Calculating 'tip per person' and 'total per person'.
                    tipPP = tipPerc * 0.01f * billVal / nop;
                    totalPP = (billVal / nop) + tipPP;
                }

                // Adding '$' sign before the values with 2 decimal point precision.
                lblTipPP.Text = "$" + tipPP.ToString("0.00");
                lblTotalPP.Text = "$" + totalPP.ToString("0.00");
            }
            catch(FormatException)
            {
                // Error message is shown in case of any invalid input
                // and default values are set in the text boxes.
                MessageBox.Show("Please enter the valid details");
                txtBill.Text = "0.00";
                txtBill.ForeColor = Color.Silver;
                txtTipPercent.Text = "0%";
                txtTipPercent.ForeColor = Color.Silver;
                txtNumOfPeo.Text = "0";
                txtNumOfPeo.ForeColor = Color.Silver;
            }
            catch(Exception exp)
            {
                // All exceptions other than FormatExceptions are handled
                // using this code segment.
                MessageBox.Show("Exception Handled " + exp);
            }
        }
    }
}
