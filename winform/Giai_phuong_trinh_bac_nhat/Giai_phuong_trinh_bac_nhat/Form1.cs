using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Giai_phuong_trinh_bac_nhat
{
	public partial class Form1 : Form
	{
		double a, b, x;
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//btnGiai.Enabled = false;
			//btnXoa.Enabled = false;
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			a = Convert.ToDouble(txtA.Text);
			b = Convert.ToDouble(txtB.Text);

			if (a == 0)
			{
				txtNghiem.Text = "PT có vô số nghiệm!";
			}
			else
			{
				x = (-b) / a;
				txtNghiem.Text = "x = " + x;
			}

			btnXoa.Enabled = true;
			btnGiai.Enabled = false;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			txtA.Clear();
			txtB.Clear();
			txtNghiem.Clear();
			txtA.Focus();
			btnXoa.Enabled = false;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult r;
			r = MessageBox.Show("Mày có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (r == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void txtA_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(txtA.Text, out a))
			{
				MessageBox.Show("Lỗi nhập sai dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtA.Focus();
			}
		}

		private void txtB_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(txtA.Text, out b))
			{
				MessageBox.Show("Lỗi nhập sai dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtB.Focus();
			}
		}
	}
}
