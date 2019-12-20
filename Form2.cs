// Theodora Tataru 
// C00231174
// Basic Calculator
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// clear memory and negative sign
namespace Lab5
{
    public partial class Form2 : Form
    {
        private String memory1 = "";
        private String memory2 = "";
        private double total = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (B0.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B0.Text;
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (B1.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B1.Text;
            }

        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (B2.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B2.Text;
            }

        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (B3.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B3.Text;
            }

        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (B4.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B4.Text;
            }

        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (B5.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B5.Text;
            }

        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (B6.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B6.Text;
            }

        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (B7.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B7.Text;
            }

        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (B8.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B8.Text;
            }

        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (B9.Enabled)
            {
                richTextBox1.Text = richTextBox1.Text + B9.Text;
            }

        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
            Decimal.Enabled = false;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (Plus.Enabled && noOperators() && !isTextBoxEmpty())
            {
                richTextBox1.Text = richTextBox1.Text + Plus.Text;
                Decimal.Enabled = true;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (Minus.Enabled && noOperators() && !isTextBoxEmpty())
            {
                richTextBox1.Text = richTextBox1.Text + Minus.Text;
                Decimal.Enabled = true;
            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (Multiplication.Enabled && noOperators() && !isTextBoxEmpty())
            {
                richTextBox1.Text = richTextBox1.Text + '*';
                Decimal.Enabled = true;
            }

        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (Division.Enabled && noOperators() && !isTextBoxEmpty())
            {
                richTextBox1.Text = richTextBox1.Text + Division.Text;
                Decimal.Enabled = true;
            }

        }

        private void Modular_Click(object sender, EventArgs e)
        {
            if (Modular.Enabled && noOperators() && !isTextBoxEmpty())
            {
                richTextBox1.Text = richTextBox1.Text + Modular.Text;
                Decimal.Enabled = true;
            }

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                String[] numbers = richTextBox1.Text.Substring(1, richTextBox1.Text.Length - 1).Split(getOperator());
                numbers[0] = richTextBox1.Text[0] + numbers[0];
                if (numbers.Length == 2)
                {
                    if (numbers[0].Any(x => char.IsDigit(x)) && numbers[1].Any(x => char.IsDigit(x)))
                    {
                        if (getOperator() == '*' && numbers[1] != "")
                        {
                            total = Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1]);
                            checkDecimal();
                        }
                        else if (getOperator() == '/' && numbers[1] != "")
                        {
                            total = Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1]);
                            checkDecimal();
                        }
                        else if (getOperator() == '-' && numbers[1] != "")
                        {
                            total = Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1]);
                            checkDecimal();
                        }
                        else if (getOperator() == '+' && numbers[1] != "")
                        {
                            total = Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1]);
                            checkDecimal();
                        }
                        else if (getOperator() == '%' && numbers[1] != "")
                        {
                            total = Convert.ToDouble(numbers[0]) % Convert.ToDouble(numbers[1]);
                            checkDecimal();
                        }
                        Decimal.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {
                richTextBox1.Text = "The calculation cannot be done!";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Decimal.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            else if (richTextBox1.Text.Length == 1)
                richTextBox1.Text = "";
            else
                richTextBox1.Text = "";
        }

        private void M1_Click(object sender, EventArgs e)
        {
            if (M1.Enabled && noOperators() && memory1.Length == 0)
            {
                memory1 = richTextBox1.Text;
            }
            else if(M1.Enabled && memory1.Length >= 1)
            {
                richTextBox1.Text += memory1;
            }
        }

        private void M2_Click(object sender, EventArgs e)
        {
            if (M2.Enabled && noOperators() && memory2.Length == 0)
            {
                memory2 = richTextBox1.Text;
            }
            else if (M1.Enabled && memory2.Length >= 1)
            {
                richTextBox1.Text += memory2;
            }
        }
        
        private bool noOperators()
        {
            String theString = richTextBox1.Text;
                for (int i = 1; i < theString.Length; i++)
                {
                    if (theString[i] == '*' || theString[i] == '-' || theString[i] == '+' || theString[i] == '/' || theString[i] == '%')
                        return false;
                }
            return true;
        }

        private char getOperator()
        {
            char sign = ' ';
            String theString = richTextBox1.Text;
            for (int i = 1; i < theString.Length; i++)
            {
                if (theString[i] == '*' || theString[i] == '-' || theString[i] == '+' || theString[i] == '/' || theString[i] == '%')
                {
                    sign = theString[i];
                }
            }
            return sign;
        }
        private void checkDecimal()
        {
            String result = total.ToString("0.00");
            String[] decimalResult = result.Split('.');
            if (decimalResult.Length == 2)
            {
                if (decimalResult[1].Equals("00"))
                {
                    richTextBox1.Text = decimalResult[0];
                }
                else
                {
                    richTextBox1.Text = result;
                }
            }
            else if (Double.IsInfinity(Convert.ToDouble(result)))
            {
                richTextBox1.Text = "Not possible! Press C!";
            }
        }
        private Boolean isTextBoxEmpty()
        {
            if (richTextBox1.Text.Equals(""))
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
