using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dinh_dang
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			label3.Text = textBox1.Text;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			label3.Font = new Font(label3.Font.Name, label3.Font.Size, label3.Font.Style ^ FontStyle.Bold);
			textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Bold);
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			label3.Font = new Font(label3.Font.Name, label3.Font.Size, label3.Font.Style ^ FontStyle.Italic);
			textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Italic);
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			label3.Font = new Font(label3.Font.Name, label3.Font.Size, label3.Font.Style ^ FontStyle.Underline);
			textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Underline);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void rbt_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rbt = new RadioButton();
			if (((RadioButton)sender).Checked == true)
			{
				label3.ForeColor = ((RadioButton)sender).ForeColor;
				textBox1.ForeColor = ((RadioButton)sender).ForeColor;
			}
			rbt = (RadioButton)sender;
		}
	}
}
