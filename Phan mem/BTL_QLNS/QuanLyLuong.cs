using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QLNS.DTO;

namespace BTL_QLNS
{
    public partial class QuanLyLuong : Form
    {
        int r = -1;
        private Context db = new Context();
        public QuanLyLuong()
        {
            InitializeComponent();
            LoadDS();
            dpNgay.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void LoadDS()
        {

            var list = db.LUONGs.Select(x =>
            new
            {
                ID = x.ID,
                manv = x.ID_NV,
                tennv = db.NHANVIENs.FirstOrDefault(y => y.id_Nv == x.ID_NV).name_Nv,
                cu = x.LuongCu,
                moi = x.LuongMoi,
                thaydoi = (x.LuongMoi > x.LuongCu) ? "Tăng " + Math.Round((double)((x.LuongMoi - x.LuongCu) / x.LuongCu), 2) * 100 + " %" : "Giảm " + Math.Round((double)((x.LuongMoi - x.LuongCu) * -1 / x.LuongCu), 2) * 100 + " %",
                ngay = x.NgayThayDoi
            }
            ).ToList();
            BindingSource bd = new BindingSource();
            bd.DataSource = list;
            dgV.DataSource = bd;
        }
        private void F5()
        {
            LoadDS();
            txtManv.Text = "";
            txtTen.Text = "";
            txtCu.Text = "";
            txtMoi.Text = "";
            dpNgay.Value = DateTime.Now;
            btnthem.Enabled = true;
            btnthem.Text = "Thêm";
        }
        private void dgV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnthem.Text = "Hủy";
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                var id = r = int.Parse(dgV.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                var o = (db.LUONGs.FirstOrDefault(x => x.ID == id));
                if (o != null)
                {

                    NHANVIEN nv = db.NHANVIENs.FirstOrDefault(x => x.id_Nv == o.ID_NV);
                    txtTen.Text = nv != null ? nv.name_Nv : "NULL";
                    txtCu.Text = o.LuongCu.ToString();
                    txtMoi.Text = o.LuongMoi.ToString();
                    dpNgay.Value = (DateTime)o.NgayThayDoi;
                    txtManv.Text = o.ID_NV;
                }
                else
                    MessageBox.Show("ID không tồn tại hoặc đã bị xóa");
            }
            else
            {
                r = -1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r > -1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(txtManv.Text))
                    {
                        if (!string.IsNullOrEmpty(txtCu.Text))
                        {
                            if (!string.IsNullOrEmpty(txtMoi.Text))
                            {
                                if (float.Parse(txtCu.Text) <= 0 || float.Parse(txtMoi.Text) <= 0)
                                {
                                    MessageBox.Show("Lương không hợp lệ vui lòng nhập lại");
                                }
                                else
                                {

                                    LUONG l = db.LUONGs.FirstOrDefault(x => x.ID == r);

                                    l.ID_NV = txtManv.Text;
                                    l.NgayThayDoi = dpNgay.Value;
                                    l.LuongCu = double.Parse(txtCu.Text);
                                    l.LuongMoi = double.Parse(txtMoi.Text);


                                    var stt = db.SaveChanges();
                                    if (stt > 0)
                                    {
                                        NHANVIEN n = db.NHANVIENs.FirstOrDefault(x => x.id_Nv == l.ID_NV);
                                        n.luong_Nv = int.Parse(txtMoi.Text);
                                        MessageBox.Show("Sửa thành công! ");
                                        F5();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lỗi!");
                                    }
                                    r = -1;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập lương mới");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập lương cũ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn mã nhân viên");
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng");
                }
            }
            else
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r > -1)
            {
                db.LUONGs.Remove(db.LUONGs.FirstOrDefault(x => x.ID == r));
                var stt = db.SaveChanges();
                if (stt > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    F5();
                }
                else
                    MessageBox.Show("Xóa thất bại!");
                r = -1;
            }
            else
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (btnthem.Text == "Hủy")
            {
                F5();
            }
            else
                try
                {
                    if (!string.IsNullOrEmpty(txtManv.Text))
                    {
                        if (!string.IsNullOrEmpty(txtCu.Text))
                        {
                            if (!string.IsNullOrEmpty(txtMoi.Text))
                            {
                                if (float.Parse(txtCu.Text) <= 0 || float.Parse(txtMoi.Text) <= 0)
                                {
                                    MessageBox.Show("Lương không hợp lệ vui lòng nhập lại");
                                }
                                else
                                {
                                    LUONG l = new LUONG
                                    {
                                        ID_NV = txtManv.Text,
                                        NgayThayDoi = dpNgay.Value,
                                        LuongCu = double.Parse(txtCu.Text),
                                        LuongMoi = double.Parse(txtMoi.Text),
                                    };
                                    var stt = db.LUONGs.Add(l);
                                    db.SaveChanges();
                                    if (stt.ID > 0)
                                    {
                                        NHANVIEN n = db.NHANVIENs.FirstOrDefault(x => x.id_Nv == l.ID_NV);
                                        n.luong_Nv = int.Parse(txtMoi.Text);
                                        MessageBox.Show("Thêm thành công! ");
                                        F5();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lỗi!");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập lương mới");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập lương cũ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn mã nhân viên");
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng");
                }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            using (QuanLyNhanVien frm = new QuanLyNhanVien())
            {
                btnthem.Text = "Thêm";
                frm.ShowDialog();
                if (frm.idnv != null && !string.IsNullOrEmpty(frm.idnv))
                {
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnthem.Enabled = true;
                    var nv = db.NHANVIENs.FirstOrDefault(x => x.id_Nv == frm.idnv);
                    txtManv.Text = nv.id_Nv;
                    txtTen.Text = nv.name_Nv;
                    txtCu.Text = nv.luong_Nv.ToString();
                    txtMoi.Text = "0";
                }
            }
        }
    }
}
