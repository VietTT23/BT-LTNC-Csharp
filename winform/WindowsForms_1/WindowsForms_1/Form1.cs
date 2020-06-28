using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("Sai dữ liệu!");
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out b))
            {
                MessageBox.Show("Sai dữ liệu!");
                textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(a + b);
            label4.Text = Convert.ToString(a - b);
            label5.Text = Convert.ToString(a * b);
            try
            {
                label6.Text = Convert.ToString(a / b);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Lỗi chia 0");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
