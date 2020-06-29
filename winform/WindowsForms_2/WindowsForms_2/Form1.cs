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
            #region Kiểm tra dữ liệu nhập vào

            if (!int.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Nhập sai dữ liệu");
                //textBox1.Focus();
            }

            #endregion
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            #region Kiểm tra điều kiện 0 <= n <= 1000

            if (n < 0 || n > 1000)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trong khoảng từ 0 đến 1000");
                textBox1.Focus();
            }

            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            #region Hiển thị các số nguyên tố < n

            for (int i = 2; i < n; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    textBox2.Text += " " + i + ", ";
                }
            }

            #endregion

            #region Hiển thị các số chính phương < n

            for (int i = 0; i < n; i++)
            {
                if ((int)(Math.Sqrt(i)) == Math.Sqrt(i))
                {
                    textBox3.Text += " " + i + ", ";
                }
            }

            #endregion

            #region Hiển thị các số hoàn chỉnh < n
            
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    textBox4.Text += " " + i + ", ";
                }
            }

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
