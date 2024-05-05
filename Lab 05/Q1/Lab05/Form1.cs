// Form1.cs
using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = 0;

                if (sender == btnAdd)
                    result = num1 + num2;
                else if (sender == btnSubtract)
                    result = num1 - num2;
                else if (sender == btnMultiply)
                    result = num1 * num2;
                else if (sender == btnDivide)
                {
                    if (num2 == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    result = num1 / num2;
                }
                else
                    throw new NotSupportedException("Unsupported operation.");

                lblResult.Text = "Result: " + result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values only.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
