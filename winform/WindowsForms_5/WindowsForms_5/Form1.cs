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
        public List<ThongTinSinhVien> TTSV { get; set; }
        public Form1()
        {
            //TTSV = GetTTSV();
            InitializeComponent();
        }

        private List<ThongTinSinhVien> GetTTSV()
        {
            var DSSV = new List<ThongTinSinhVien>();
            DSSV.Add(new ThongTinSinhVien()
            {
                MaSV = Convert.ToInt32(txtMaSV.Text),
                HoTen = txtHoTen.Text,
                NgaySinh = datetimeNgaySinh.Text,
                //GioiTinh
                QueQuan = cbxQueQuan.Text,
                Khoa = cbxKhoa.Text,
                Lop = cbxLop.Text
            });
            return DSSV;
        }

        //private List<ThongTinSinhVien> GetTTS()
        //{
        //    var DSSV = new List<ThongTinSinhVien>();
        //    DSSV.Add(new ThongTinSinhVien()
        //    {
        //        MaSV = Convert.ToInt32(txtMaSV.Text),
        //        HoTen = txtHoTen.Text,
        //        NgaySinh = datetimeNgaySinh.Text,
        //        //GioiTinh
        //        QueQuan = cbxQueQuan.Text,
        //        Khoa = cbxKhoa.Text,
        //        Lop = cbxLop.Text
        //    });
        //    return DSSV;
        //}

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

        private void button1_Click(object sender, EventArgs e)
        {
            var ttsv = this.TTSV;
            dataGridView1.DataSource = ttsv;
        }
    }
}
