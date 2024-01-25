using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double H, W, BMI;
            string comment;
            if (double.TryParse(textBox1.Text, out W) && (double.TryParse(textBox2.Text, out H)))
            {
                BMI = (W / Math.Pow(H, 2) * 1000);

                textBox3.Text = BMI.ToString();
                if (BMI < 18)
                {
                    textBox4.Text = "YOU ARE UNDERWEIGHT";
                }
                else if (BMI >= 18 && BMI < 26)
                {

                    textBox4.Text = "YOU ARE NORMAL";

                }
                else
                {
                    textBox4.Text = "YOU ARE OVERWEIGHT";
                }
            }
            else
            {
                MessageBox.Show("INVALID");

            }
        }
    }
}
