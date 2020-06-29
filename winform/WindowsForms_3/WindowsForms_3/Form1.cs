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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int caoVoi, tayTrang, chupHinh, layCao, hanRang = 90000, slRang;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Tính tổng tiền

            int sum = (caoVoi + tayTrang + chupHinh + layCao + (hanRang * slRang));
            slRang = Convert.ToInt32(numericUpDown1.Value);
            textBox2.Text = "" + sum;

            #endregion

            #region Hóa đơn

            Hoadon hd = new Hoadon();
            hd.Message1 = textBox1.Text;
            hd.Message2 = textBox2.Text;
            hd.Show();

            #endregion
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                caoVoi = 100000;
            }
            else
            {
                caoVoi = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                tayTrang = 1200000;
            }
            else
            {
                tayTrang = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                chupHinh = 150000;
            }
            else
            {
                chupHinh = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                layCao = 100000;
            }
            else
            {
                layCao = 0;
            }
        }
    }
}
