using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Drawing.Font;

namespace WindowsForms_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double giaTri2;
        string phepToan = "";
        double giaTri1;
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Color

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mot.BackColor = colorDialog1.Color;
                hai.BackColor = colorDialog1.Color;
                ba.BackColor = colorDialog1.Color;
                bon.BackColor = colorDialog1.Color;
                nam.BackColor = colorDialog1.Color;
                sau.BackColor = colorDialog1.Color;
                bay.BackColor = colorDialog1.Color;
                tam.BackColor = colorDialog1.Color;
                chin.BackColor = colorDialog1.Color;
                khong.BackColor = colorDialog1.Color;
                cong.BackColor = colorDialog1.Color;
                tru.BackColor = colorDialog1.Color;
                nhan.BackColor = colorDialog1.Color;
                chia.BackColor = colorDialog1.Color;
                clear.BackColor = colorDialog1.Color;
                bang.BackColor = colorDialog1.Color;
            }
        }

        #endregion

        #region Font

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                mot.Font = fontDialog1.Font;
                hai.Font = fontDialog1.Font;
                ba.Font = fontDialog1.Font;
                bon.Font = fontDialog1.Font;
                nam.Font = fontDialog1.Font;
                sau.Font = fontDialog1.Font;
                bay.Font = fontDialog1.Font;
                tam.Font = fontDialog1.Font;
                chin.Font = fontDialog1.Font;
                khong.Font = fontDialog1.Font;
                cong.Font = fontDialog1.Font;
                tru.Font = fontDialog1.Font;
                nhan.Font = fontDialog1.Font;
                chia.Font = fontDialog1.Font;
                clear.Font = fontDialog1.Font;
                bang.Font = fontDialog1.Font;
            }
        }

        #endregion

        #region Hiển thị phép toán
        private void mot_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
            txtKetQua.Text += mot.Text;
        }

        private void hai_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += hai.Text;
            txtKetQua.Text += hai.Text;
        }

        private void ba_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += ba.Text;
            txtKetQua.Text += ba.Text;
        }

        private void bon_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += bon.Text;
            txtKetQua.Text += bon.Text;
        }

        private void nam_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += nam.Text;
            txtKetQua.Text += nam.Text;
        }

        private void sau_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += sau.Text;
            txtKetQua.Text += sau.Text;
        }

        private void bay_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += bay.Text;
            txtKetQua.Text += bay.Text;
        }

        private void tam_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += tam.Text;
            txtKetQua.Text += tam.Text;
        }

        private void chin_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += chin.Text;
            txtKetQua.Text += chin.Text;
        }

        private void khong_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += khong.Text;
            txtKetQua.Text += khong.Text;
        }

        private void cong_Click(object sender, EventArgs e)
        {
            giaTri1 = Convert.ToDouble(txtKetQua.Text);
            txtPhepToan.Text += cong.Text;
            phepToan = "+";
            txtKetQua.Clear();
            //giaTri2 = Convert.ToDouble(txtKetQua.Text);
            //if (phepToan == "+")
            //{
            //    txtKetQua.Text = Convert.ToString(giaTri1 + giaTri2);
            //}
        }

        private void tru_Click(object sender, EventArgs e)
        {
            giaTri1 = Convert.ToDouble(txtKetQua.Text);
            txtPhepToan.Text += tru.Text;
            phepToan = "-";
            txtKetQua.Clear();
            //giaTri2 = Convert.ToDouble(txtKetQua.Text);
            //if (phepToan == "-")
            //{
            //    txtKetQua.Text = Convert.ToString(giaTri1 - giaTri2);
            //}
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            giaTri1 = Convert.ToDouble(txtKetQua.Text);
            txtPhepToan.Text += nhan.Text;
            phepToan = "*";
            txtKetQua.Clear();
            //giaTri2 = Convert.ToDouble(txtKetQua.Text);
            //if (phepToan == "*")
            //{
            //    txtKetQua.Text = Convert.ToString(giaTri1 * giaTri2);
            //}
        }

        private void chia_Click(object sender, EventArgs e)
        {
            giaTri1 = Convert.ToDouble(txtKetQua.Text);
            txtPhepToan.Text += chia.Text;
            phepToan = "/";
            txtKetQua.Clear();
            //giaTri2 = Convert.ToDouble(txtKetQua.Text);
            //if (phepToan == "/")
            //{
            //    txtKetQua.Text = Convert.ToString(giaTri1 / giaTri2);
            //}
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtPhepToan.Clear();
            txtKetQua.Clear();
            giaTri1 = 0;
            giaTri2 = 0;
            phepToan = "";
        }

        
        #endregion

        private void bang_Click(object sender, EventArgs e)
        {
            giaTri2 = Convert.ToDouble(txtKetQua.Text);
            switch (phepToan)
            {
                case "+":
                    {
                        txtKetQua.Text = Convert.ToString(giaTri1 + giaTri2);
                        break;
                    }
                case "-":
                    {
                        txtKetQua.Text = Convert.ToString(giaTri1 - giaTri2);
                        break;
                    }
                case "*":
                    {
                        txtKetQua.Text = Convert.ToString(giaTri1 * giaTri2);
                        break;
                    }
                case "/":
                    {
                        txtKetQua.Text = Convert.ToString(giaTri1 / giaTri2);
                        break;
                    }
                default:
                    break;
            }
        }

        




    }
}
