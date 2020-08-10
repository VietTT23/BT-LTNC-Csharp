using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frm_Quoc_gia
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Properties.Resources.VietNam;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Properties.Resources.USA;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Properties.Resources.Italia;
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Properties.Resources.Pinoy;
		}
	}
}
