using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phep_tinh
{
	public partial class Form1 : Form
	{
		double a, b, c;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//string cal;
			a = Convert.ToDouble(textBox1.Text);
			b = Convert.ToDouble(textBox2.Text);
			if (radioButton1.Checked == true)
			{
				c = a + b;
				textBox3.Text = c.ToString();
			}
			else if (radioButton2.Checked == true)
			{
				c = a - b;
				textBox3.Text = c.ToString();
			}
			else if (radioButton3.Checked == true)
			{
				c = a * b;
				textBox3.Text = c.ToString();
			}
			else 
			{
				c = a / b;
				textBox3.Text = c.ToString();
			}
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (!double.TryParse(textBox1.Text, out a))
			{
				MessageBox.Show("Lỗi nhập sai dữ liệu");
				textBox1.Focus();
			}
		}

		private void textBox2_Leave(object sender, EventArgs e)
		{
			if (!double.TryParse(textBox2.Text, out b))
			{
				MessageBox.Show("Lỗi nhập sai dữ liệu");
				textBox2.Focus();
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
			{
				MessageBox.Show("Vui lòng nhập số");
				radioButton1.Checked = false;
				//textBox1.Focus();
			}
			else
			{
				a = Convert.ToDouble(textBox1.Text);
				b = Convert.ToDouble(textBox2.Text);
				c = a + b;
				textBox3.Text = c.ToString();
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
			{
				MessageBox.Show("Vui lòng nhập số");
				radioButton2.Checked = false;
				//textBox1.Focus();
			}
			else
			{
				a = Convert.ToDouble(textBox1.Text);
				b = Convert.ToDouble(textBox2.Text);
				c = a - b;
				textBox3.Text = c.ToString();
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
			{
				MessageBox.Show("Vui lòng nhập số");
				radioButton3.Checked = false;
				//textBox1.Focus();
			}
			else
			{
				a = Convert.ToDouble(textBox1.Text);
				b = Convert.ToDouble(textBox2.Text);
				c = a * b;
				textBox3.Text = c.ToString();
			}
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
			{
				MessageBox.Show("Vui lòng nhập số");
				radioButton4.Checked = false;
				//textBox1.Focus();
			}
			else
			{
				a = Convert.ToDouble(textBox1.Text);
				b = Convert.ToDouble(textBox2.Text);
				c = a / b;
				textBox3.Text = c.ToString();
			}
		}

	}
}
