using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace de_13
{
    public partial class Form1 : Form
    {
        double a, b, c, delta, x1, x2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            if (a == 0)
            {
                x1 = -c / b;
                label5.Text = "x1 = x2 = " + Convert.ToString(x1);
            }
            else
            {
                delta = (b * b - 4 * a * c);
                if (delta < 0)
                {
                    label5.Text = "Phương trình vô nghiệm!";
                }
                else
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    label5.Text = "x1 = " + x1 + "x2 = " + x2;
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("Lỗi nhập sai dự liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Lỗi nhập sai dự liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out c))
            {
                MessageBox.Show("Lỗi nhập sai dự liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
        }
    }
}
