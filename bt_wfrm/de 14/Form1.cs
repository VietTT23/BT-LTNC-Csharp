using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using de_14.DataAccess;
using de_14.Query;

namespace de_14
{
	public partial class Form1 : Form
	{
		SV ctpn = new SV();
		string gt; //= new RadioButton();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'de_14DataSet.SV' table. You can move, or remove it, as needed.
			this.sVTableAdapter.Fill(this.de_14DataSet.SV);
			binding();

		}

		public void binding()
		{
			if (rbntnam.Checked)
			{
				gt = rbntnam.Text;
			}
			else
			{
				gt = rbntnu.Text;
			}
			txtma.DataBindings.Clear();
			txtma.DataBindings.Add("text", dataGridView1.DataSource, "MaSV");
			txtten.DataBindings.Clear();
			txtten.DataBindings.Add("text", dataGridView1.DataSource, "TenSV");
			cbquequan.DataBindings.Clear();
			cbquequan.DataBindings.Add("text", dataGridView1.DataSource, "QueQuan");
			//gt.DataBindings.Clear();
			//gt.DataBindings.Add("text", dataGridView1.DataSource, "GioiTinh");
		}

		private void bntthem_Click(object sender, EventArgs e)
		{
			
			if (this.txtma.TextLength == 0)
			{
				MessageBox.Show("Mã không được để trống");
				this.txtma.Focus();
			}
			else if (this.txtten.TextLength == 0)
			{
				MessageBox.Show("Tên không được để trống");
				this.txtten.Focus();
			}
			else
			{
				try
				{
					ctpn.Insertsv(txtma.Text, txtten.Text, gt, cbquequan.SelectedItem.ToString());
					MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Form1_Load(sender, e);
				}
				catch
				{
				    MessageBox.Show("Mã dự án " + this.txtma.Text + " đã tồn tại");
				}
			}
			
		}

		private void bntxoa_Click(object sender, EventArgs e)
		{
			ctpn.Deletesv(txtma.Text);
			Form1_Load(sender, e);
		}

		private void bntsua_Click(object sender, EventArgs e)
		{
			if (this.txtma.TextLength == 0)
			{
				MessageBox.Show("Mã không được để trống");
				this.txtma.Focus();
			}
			else if (this.txtten.TextLength == 0)
			{
				MessageBox.Show("Tên không được để trống");
				this.txtten.Focus();
			}
			else
			{
				try
				{
					ctpn.Updatesv(txtma.Text, txtten.Text, gt, cbquequan.SelectedItem.ToString());
					MessageBox.Show("Đã sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Form1_Load(sender, e);
				}
				catch
				{
					MessageBox.Show("Mã dự án " + this.txtma.Text + " đã tồn tại");
				}
			}
		}


	}
}
