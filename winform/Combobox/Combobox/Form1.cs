using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Combobox
{
	public partial class Form1 : Form
	{
		int a;
		List<int> dsUoc = new List<int>();
		List<int> dsUchan = new List<int>();
		List<int> dsUngto = new List<int>();

		public Form1()
		{
			InitializeComponent();
		}

		private void btnCapnhat_Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0)
			{
				MessageBox.Show("Không có dữ liệu để cập nhật", "Thông báo", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				textBox1.Focus();
			}
			else
			{
				//try
				//{
					comboBox1.Items.Add(textBox1.Text);
					MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK ,MessageBoxIcon.Information);
					textBox1.Clear();
				//}
				//catch
				//{
				//    MessageBox.Show("Số " + this.textBox1.Text + " đã tồn tại");
				//}
			}
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (textBox1.TextLength != 0)
			{
				if (!int.TryParse(textBox1.Text, out a))
				{
					MessageBox.Show("Lỗi nhập sai dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBox1.Focus();
				}
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			int x;
			x = Convert.ToInt32(comboBox1.SelectedItem);
			for (int i = 1; i <= x; i++)
			{
				if (x % i == 0)
				{
					listBox1.Items.Add(i);
					dsUoc.Add(i);
					if (i % 2 == 0)
					{
						dsUchan.Add(i);
					}
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
						dsUngto.Add(i);
					}
				}
			}
		}

		private void btnTong_Click(object sender, EventArgs e)
		{
			int tong;
			tong = dsUoc.Sum();
			MessageBox.Show("Tổng các ước số là: " + tong);
		}

		private void btnSl_uocchan_Click(object sender, EventArgs e)
		{
			int x;
			x = dsUchan.Count;
			MessageBox.Show("Số lượng ước số chẵn là: " + x);
		}

		private void btnSl_uoccnguyento_Click(object sender, EventArgs e)
		{
			int x;
			x = dsUngto.Count;
			MessageBox.Show("Số lượng ước nguyên tố là: " + x);
		}
	}
}
