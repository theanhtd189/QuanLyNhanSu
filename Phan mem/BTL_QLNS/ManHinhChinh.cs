using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_QLNS
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }
        private void frm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien frmnv = new QuanLyNhanVien();
            this.Hide();
            frmnv.ShowDialog();
            this.Show();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            QuanLyPhongBan frmpb = new QuanLyPhongBan();
            this.Hide();
            frmpb.ShowDialog();
            this.Show();
        }

        private void btnDuan_Click(object sender, EventArgs e)
        {
            QuanLyDuAn frmda = new QuanLyDuAn();
            this.Hide();
            frmda.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyLuong frm = new QuanLyLuong();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
