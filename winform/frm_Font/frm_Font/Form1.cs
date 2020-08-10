using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frm_Font
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Font = new Font(radioButton2.Text, textBox1.Font.Size);
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Font = new Font(radioButton1.Text, textBox1.Font.Size);
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Font = new Font(radioButton3.Text, textBox1.Font.Size);
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Font = new Font(radioButton4.Text, textBox1.Font.Size);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
