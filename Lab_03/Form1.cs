using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            Class1.myCount(textBox_a.Text, textBox_b.Text, "+", textBox_result);
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            Class1.myCount(textBox_a.Text, textBox_b.Text, "-", textBox_result);
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            Class1.myCount(textBox_a.Text, textBox_b.Text, "*", textBox_result);
        }

        private void button_Division_Click(object sender, EventArgs e)
        {
            Class1.myCount(textBox_a.Text, textBox_b.Text, "/", textBox_result);
        }

        private void button_Pow_Click(object sender, EventArgs e)
        {
            Class1.myCount(textBox_a.Text, textBox_b.Text, "x^y", textBox_result);
        }

        private void button_Log_Click(object sender, EventArgs e)
        {
            Class1.myCount1(textBox_a.Text, textBox_b.Text, "Log", textBox_result);
        }

        private void button_Sqrt_Click(object sender, EventArgs e)
        {
            Class1.myCount1(textBox_a.Text, textBox_b.Text, "Sqrt", textBox_result);
        }

        private void button_1x_Click(object sender, EventArgs e)
        {
            Class1.myCount1(textBox_a.Text, textBox_b.Text, "1/x", textBox_result);
        }

        private void button_n_Click(object sender, EventArgs e)
        {
            Class1.myCount1(textBox_a.Text, textBox_b.Text, "n!", textBox_result);
        }
    }
}
