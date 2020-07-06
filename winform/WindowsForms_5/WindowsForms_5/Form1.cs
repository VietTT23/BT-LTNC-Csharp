using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {   
            InitializeComponent();
        }

        List<string> dsLopCNTT;
        List<string> dsLopCT;
        List<string> dsLopCK;
        List<string> dsLopDT;
        List<string> dsLopKT;
        List<string> dsLopMT;
        List<string> dsLopTN;

        private void cbxKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            string khoa = Convert.ToString(cbxKhoa.SelectedItem);
            
            dsLopCNTT = new List<string>() { "60TH1", "60TH2", "60TH3", "60TH4", "60TH5", "60PM1", "60PM2" };
            dsLopCT = new List<string>() { "60CT1", "60CT2", "60CT3" };
            dsLopDT = new List<string>() { "60DT1", "60DT2", "60DT3" };
            dsLopKT = new List<string>() { "60KT1", "60KT2", "60KT3" };
            dsLopMT = new List<string>() { "60MT1", "60MT2", "60MT3" };
            dsLopTN = new List<string>() { "60TN1", "60TN2", "60TN3" };
            dsLopCK = new List<string>() { "60CK1", "60CK2", "60CK3" };

//Khoa Công trình
//Khoa Kỹ thuật tài nguyên nước
//Khoa CNTT
//Khoa Cơ khí
//Khoa Điện - Điện tử
//Khoa Kinh tế và Quản lý
//Khoa Hóa và Môi trường

            if (khoa == "Khoa CNTT")
            {
                cbxLop.DataSource = dsLopCNTT;
            }
            else if (khoa == "Khoa Công trình")
            {
                cbxLop.DataSource = dsLopCT;
            }
            else if (khoa == "Khoa Kỹ thuật tài nguyên nước")
            {
                cbxLop.DataSource = dsLopTN;
            }
            else if (khoa == "Khoa Cơ khí")
            {
                cbxLop.DataSource = dsLopCK;
            }
            else if (khoa == "Khoa Điện - Điện tử")
            {
                cbxLop.DataSource = dsLopDT;
            }
            else if (khoa == "Khoa Kinh tế và Quản lý")
            {
                cbxLop.DataSource = dsLopKT;
            }
            else if (khoa == "Khoa Hóa và Môi trường")
            {
                cbxLop.DataSource = dsLopMT;
            }

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string gioiTinh;

            if (rbtNam.Checked == true)
            {
                gioiTinh = rbtNam.Text;
            }
            else
            {
                gioiTinh = rbtNu.Text;
            }

            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[dataGridView1.Columns["ColumnMaSV"].Index].Value = txtMaSV.Text;
            row.Cells[dataGridView1.Columns["ColumnHoTen"].Index].Value = txtHoTen.Text;
            row.Cells[dataGridView1.Columns["ColumnNgaySinh"].Index].Value = datetimeNgaySinh.Text;
            row.Cells[dataGridView1.Columns["ColumnGioiTinh"].Index].Value = gioiTinh;
            row.Cells[dataGridView1.Columns["ColumnQueQuan"].Index].Value = cbxQueQuan.Text;
            row.Cells[dataGridView1.Columns["ColumnLop"].Index].Value = cbxLop.Text;
            row.Cells[dataGridView1.Columns["ColumnKhoa"].Index].Value = cbxKhoa.Text;
            dataGridView1.Rows.Add(row);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            
            dataGridView1.ReadOnly = false;
                
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
    }
}
