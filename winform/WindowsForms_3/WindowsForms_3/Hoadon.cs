using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_3
{
    public partial class Hoadon : Form
    {
        private string _message1;
        private string _message2;
        public Hoadon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Message1
        {
            get { return _message1; }
            set { _message1 = value; }
        }

        public string Message2
        {
            get { return _message2; }
            set { _message2 = value; }
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            label2.Text = "Khách hàng : " + _message1;
            label3.Text = "Số tiền thanh toán : " + _message2;
        }
    }
}
