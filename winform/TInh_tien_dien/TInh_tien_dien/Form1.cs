using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TInh_tien_dien.LopData;

namespace TInh_tien_dien
{
	public partial class Form1 : Form
	{
		baocao bc = new baocao();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'tinhtiendienDataSet.baocao' table. You can move, or remove it, as needed.
			this.baocaoTableAdapter.Fill(this.tinhtiendienDataSet.baocao);
			binding();

		}

		public void binding()
		{
			txtten.DataBindings.Clear();
			txtten.DataBindings.Add("text", dgvbaocao.DataSource, "ten");
			cbxphong.DataBindings.Clear();
			cbxphong.DataBindings.Add("text", dgvbaocao.DataSource, "phong");
			txtthang.DataBindings.Clear();
			txtthang.DataBindings.Add("text", dgvbaocao.DataSource, "thang");
			txttieuthu.DataBindings.Clear();
			txttieuthu.DataBindings.Add("text", dgvbaocao.DataSource, "tieuthu");
			txtthanhtien.DataBindings.Clear();
			txtthanhtien.DataBindings.Add("text", dgvbaocao.DataSource, "thanhtien");
		}

		private void btntinhtien_Click(object sender, EventArgs e)
		{
			int socu, somoi, tongtien;
			socu = Convert.ToInt32(txtsocu.Text);
			somoi = Convert.ToInt32(txtsomoi.Text);
			tongtien = 3000 * (somoi - socu);
			txttieuthu.Text = (somoi - socu).ToString();
			txtthanhtien.Text = tongtien.ToString();
		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			bc.insertBaoCao(txtten.Text, cbxphong.Text, txtthang.Text, txttieuthu.Text, txtthanhtien.Text, "0");
			Form1_Load(sender, e);
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			bc.DeleteBaoCao(txtten.Text);
			Form1_Load(sender, e);
		}
	}
}
