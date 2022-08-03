using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dividing text box 1 and text box 2 to get the division of both values entered 
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);
            double sum = txt1 / txt2;
            textBox3.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adding text box 1 and text box 2 to get the sum of both values entered 
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);
            double sum = txt1 + txt2;
            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //subtracting text box 1 and text box 2 to get the subtraction of both values entered 
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);
            double sum = txt1 - txt2;
            textBox3.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //multiplying text box 1 and text box 2 to get the multiplication of both values entered 
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);
            double sum = txt1 * txt2;
            textBox3.Text = sum.ToString();
        }
    }
}
