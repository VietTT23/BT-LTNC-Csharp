using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Nhập sai dữ liệu");
                textBox1.Focus();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (n >= 0 && n <= 1000)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trong khoảng từ 0 đến 1000");
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int count;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
            }

            for (int i = 0; i < n; i++)
            {
                if ((int)(Math.Sqrt(i)) == Math.Sqrt(i))
                {
                    label3.Text = Convert.ToString(i);
                }
            }
        }
    }
}
