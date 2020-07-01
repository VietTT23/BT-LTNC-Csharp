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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Color

        private void đỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.BackColor = Color.Red;
            hai.BackColor = Color.Red;
            ba.BackColor = Color.Red;
            bon.BackColor = Color.Red;
            nam.BackColor = Color.Red;
            sau.BackColor = Color.Red;
            bay.BackColor = Color.Red;
            tam.BackColor = Color.Red;
            chin.BackColor = Color.Red;
            khong.BackColor = Color.Red;
            cong.BackColor = Color.Red;
            tru.BackColor = Color.Red;
            nhan.BackColor = Color.Red;
            chia.BackColor = Color.Red;
            clear.BackColor = Color.Red;
            bang.BackColor = Color.Red;
        }

        private void vàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.BackColor = Color.Yellow;
            hai.BackColor = Color.Yellow;
            ba.BackColor = Color.Yellow;
            bon.BackColor = Color.Yellow;
            nam.BackColor = Color.Yellow;
            sau.BackColor = Color.Yellow;
            bay.BackColor = Color.Yellow;
            tam.BackColor = Color.Yellow;
            chin.BackColor = Color.Yellow;
            khong.BackColor = Color.Yellow;
            cong.BackColor = Color.Yellow;
            tru.BackColor = Color.Yellow;
            nhan.BackColor = Color.Yellow;
            chia.BackColor = Color.Yellow;
            clear.BackColor = Color.Yellow;
            bang.BackColor = Color.Yellow;
        }

        private void camToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.BackColor = Color.Orange;
            hai.BackColor = Color.Orange;
            ba.BackColor = Color.Orange;
            bon.BackColor = Color.Orange;
            nam.BackColor = Color.Orange;
            sau.BackColor = Color.Orange;
            bay.BackColor = Color.Orange;
            tam.BackColor = Color.Orange;
            chin.BackColor = Color.Orange;
            khong.BackColor = Color.Orange;
            cong.BackColor = Color.Orange;
            tru.BackColor = Color.Orange;
            nhan.BackColor = Color.Orange;
            chia.BackColor = Color.Orange;
            clear.BackColor = Color.Orange;
            bang.BackColor = Color.Orange;
        }

        private void lụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.BackColor = Color.Green;
            hai.BackColor = Color.Green;
            ba.BackColor = Color.Green;
            bon.BackColor = Color.Green;
            nam.BackColor = Color.Green;
            sau.BackColor = Color.Green;
            bay.BackColor = Color.Green;
            tam.BackColor = Color.Green;
            chin.BackColor = Color.Green;
            khong.BackColor = Color.Green;
            cong.BackColor = Color.Green;
            tru.BackColor = Color.Green;
            nhan.BackColor = Color.Green;
            chia.BackColor = Color.Green;
            clear.BackColor = Color.Green;
            bang.BackColor = Color.Green;
        }

        private void lamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.BackColor = Color.Blue;
            hai.BackColor = Color.Blue;
            ba.BackColor = Color.Blue;
            bon.BackColor = Color.Blue;
            nam.BackColor = Color.Blue;
            sau.BackColor = Color.Blue;
            bay.BackColor = Color.Blue;
            tam.BackColor = Color.Blue;
            chin.BackColor = Color.Blue;
            khong.BackColor = Color.Blue;
            cong.BackColor = Color.Blue;
            tru.BackColor = Color.Blue;
            nhan.BackColor = Color.Blue;
            chia.BackColor = Color.Blue;
            clear.BackColor = Color.Blue;
            bang.BackColor = Color.Blue;
        }

        private void tràmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.BackColor = Color.Indigo;
            hai.BackColor = Color.Indigo;
            ba.BackColor = Color.Indigo;
            bon.BackColor = Color.Indigo;
            nam.BackColor = Color.Indigo;
            sau.BackColor = Color.Indigo;
            bay.BackColor = Color.Indigo;
            tam.BackColor = Color.Indigo;
            chin.BackColor = Color.Indigo;
            khong.BackColor = Color.Indigo;
            cong.BackColor = Color.Indigo;
            tru.BackColor = Color.Indigo;
            nhan.BackColor = Color.Indigo;
            chia.BackColor = Color.Indigo;
            clear.BackColor = Color.Indigo;
            bang.BackColor = Color.Indigo;
        }

        private void tímToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.BackColor = Color.Purple;
            hai.BackColor = Color.Purple;
            ba.BackColor = Color.Purple;
            bon.BackColor = Color.Purple;
            nam.BackColor = Color.Purple;
            sau.BackColor = Color.Purple;
            bay.BackColor = Color.Purple;
            tam.BackColor = Color.Purple;
            chin.BackColor = Color.Purple;
            khong.BackColor = Color.Purple;
            cong.BackColor = Color.Purple;
            tru.BackColor = Color.Purple;
            nhan.BackColor = Color.Purple;
            chia.BackColor = Color.Purple;
            clear.BackColor = Color.Purple;
            bang.BackColor = Color.Purple;
        }

        #endregion

        #region Font

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.Font = new Font("Arial", mot.Font.Size);
            hai.Font = new Font("Arial", hai.Font.Size);
            ba.Font = new Font("Arial", ba.Font.Size);
            bon.Font = new Font("Arial", bon.Font.Size);
            nam.Font = new Font("Arial", nam.Font.Size);
            sau.Font = new Font("Arial", sau.Font.Size);
            bay.Font = new Font("Arial", bay.Font.Size);
            tam.Font = new Font("Arial", tam.Font.Size);
            chin.Font = new Font("Arial", chin.Font.Size);
            khong.Font = new Font("Arial", khong.Font.Size);
            cong.Font = new Font("Arial", cong.Font.Size);
            tru.Font = new Font("Arial", tru.Font.Size);
            nhan.Font = new Font("Arial", nhan.Font.Size);
            chia.Font = new Font("Arial", chia.Font.Size);
            clear.Font = new Font("Arial", clear.Font.Size);
            bang.Font = new Font("Arial", bang.Font.Size);
        }

        private void helveticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.Font = new Font("Impact", mot.Font.Size);
            hai.Font = new Font("Impact", hai.Font.Size);
            ba.Font = new Font("Impact", ba.Font.Size);
            bon.Font = new Font("Impact", bon.Font.Size);
            nam.Font = new Font("Impact", nam.Font.Size);
            sau.Font = new Font("Impact", sau.Font.Size);
            bay.Font = new Font("Impact", bay.Font.Size);
            tam.Font = new Font("Impact", tam.Font.Size);
            chin.Font = new Font("Impact", chin.Font.Size);
            khong.Font = new Font("Impact", khong.Font.Size);
            cong.Font = new Font("Impact", cong.Font.Size);
            tru.Font = new Font("Impact", tru.Font.Size);
            nhan.Font = new Font("Impact", nhan.Font.Size);
            chia.Font = new Font("Impact", chia.Font.Size);
            clear.Font = new Font("Impact", clear.Font.Size);
            bang.Font = new Font("Impact", bang.Font.Size);
        }

        private void timeNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mot.Font = new Font("Times New Roman", mot.Font.Size);
            hai.Font = new Font("Times New Roman", hai.Font.Size);
            ba.Font = new Font("Times New Roman", ba.Font.Size);
            bon.Font = new Font("Times New Roman", bon.Font.Size);
            nam.Font = new Font("Times New Roman", nam.Font.Size);
            sau.Font = new Font("Times New Roman", sau.Font.Size);
            bay.Font = new Font("Times New Roman", bay.Font.Size);
            tam.Font = new Font("Times New Roman", tam.Font.Size);
            chin.Font = new Font("Times New Roman", chin.Font.Size);
            khong.Font = new Font("Times New Roman", khong.Font.Size);
            cong.Font = new Font("Times New Roman", cong.Font.Size);
            tru.Font = new Font("Times New Roman", tru.Font.Size);
            nhan.Font = new Font("Times New Roman", nhan.Font.Size);
            chia.Font = new Font("Times New Roman", chia.Font.Size);
            clear.Font = new Font("Times New Roman", clear.Font.Size);
            bang.Font = new Font("Times New Roman", bang.Font.Size);
        }
        #endregion

        #region Hiển thị phép toán
        private void mot_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void hai_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += hai.Text;
        }

        private void ba_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += ba.Text;
        }

        private void bon_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += bon.Text;
        }

        private void nam_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += nam.Text;
        }

        private void sau_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += sau.Text;
        }

        private void bay_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += bay.Text;
        }

        private void tam_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += tam.Text;
        }

        private void chin_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += chin.Text;
        }

        private void khong_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += khong.Text;
        }

        //private void cong_Click(object sender, EventArgs e)
        //{
        //    txtPhepToan.Text += cong.Text;
        //}

        //private void tru_Click(object sender, EventArgs e)
        //{
        //    txtPhepToan.Text += tru.Text;
        //}

        //private void nhan_Click(object sender, EventArgs e)
        //{
        //    txtPhepToan.Text += nhan.Text;
        //}

        //private void chia_Click(object sender, EventArgs e)
        //{
        //    txtPhepToan.Text += chia.Text;
        //}

        //private void clear_Click(object sender, EventArgs e)
        //{
        //    txtPhepToan.Text += clear.Text;
        //}

        //private void bang_Click(object sender, EventArgs e)
        //{
        //    txtPhepToan.Text += bang.Text;
        //}
        #endregion




    }
}
