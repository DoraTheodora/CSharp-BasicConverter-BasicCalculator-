// Theodora Tataru 
// C00231174
// Converter
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                InchToFeet();
            }
            if (radioButton2.Checked == true)
            {
                EuroToPounds();
            }
            if (radioButton3.Checked == true)
            {
                CtoT();
            }
        }

        private void InchToFeet()
        {
            double tryDouble;
            if(double.TryParse(textBox1.Text, out tryDouble))
            {
                double value = Double.Parse(textBox1.Text);
                double result = value / 12;
                textBox2.Text = result.ToString();
            }
            else
            {
                textBox1.Text = "Insert a number.";
            }
        }
        private void EuroToPounds()
        {
            double tryDouble;
            if (double.TryParse(textBox1.Text, out tryDouble))
            {
                double value = Double.Parse(textBox1.Text);
                double result = value * 0.79;
                textBox2.Text = result.ToString();
            }
            else
            {
                textBox1.Text = "Insert a number.";
            }
        }
        private void CtoT()
        {
            double tryDouble;
            if (double.TryParse(textBox1.Text, out tryDouble))
                {
                    double value = Double.Parse(textBox1.Text);
                    double result = (value * 9/5)+32;
                    textBox2.Text = result.ToString();
            }
            else
            {
                textBox1.Text = "Insert a number.";
            }
        }
    }
}
