using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace de_15
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Button bt = new Button();
		TextBox txt = new TextBox();

		private void button_Click(object sender, EventArgs e)
		{
			bt = sender as Button;
			txt.Text += bt.Text;
		}

		private void txtma_MouseClick(object sender, MouseEventArgs e)
		{
			txt = sender as TextBox;
		}

	}
}
