using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using D.ThongTin;
using B.ThaoTac;

namespace A.GiaoDien
{
    public partial class KhoaHoc : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //KHÓA HỌC
        KhoaHoc_B cls_KhoaHoc = new KhoaHoc_B();
        string ChucNang = null;
        public KhoaHoc(string ChucNang, KhoaHoc_ThongTin KhoaHoc)
        {
            InitializeComponent();
            this.ChucNang = ChucNang;
            if (this.ChucNang.Equals("F9"))
            {
                txtMaKhoaHoc.Focus();
                btHoanTat.Enabled = false;
            }
            if (this.ChucNang.Equals("F10"))
            {
                txtMaKhoaHoc.Text = KhoaHoc.MaKhoaHoc;
                txtNgayBatDau.Value = KhoaHoc.NgayBatDau;
                txtNgayKetThuc.Value = KhoaHoc.NgayKetThuc;
                btHoanTat.Enabled = false;
                txtMaKhoaHoc.Enabled = false;
            }
        }
        //DỮ LIỆU TRUYỀN VỀ.
        public delegate void DuLieuTruyenVe(KhoaHoc_ThongTin KhoaHoc);
        public DuLieuTruyenVe DuLieu;
        //THÊM KHÓA HỌC MỚI.
        private void ThemKhoaHoc()
        {
            KhoaHoc_ThongTin KH = new KhoaHoc_ThongTin();
            KH.MaKhoaHoc = txtMaKhoaHoc.Text;
            KH.NgayBatDau = txtNgayBatDau.Value;
            KH.NgayKetThuc = txtNgayKetThuc.Value;
            try
            {
                if (!KH.MaKhoaHoc.Equals(""))
                {
                    cls_KhoaHoc.ThemKhoaHoc(KH);
                    MessageBox.Show("Bạn đã thêm khóa học " + KH.MaKhoaHoc + "", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Hãy nhập mã khóa học");
                    txtMaKhoaHoc.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới, có thể khóa chính bị trùng.", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMaKhoaHoc.ResetText();
            txtMaKhoaHoc.Focus();
            btHoanTat.Enabled = true;
            if (DuLieu != null)
            {
                DuLieu(KH);
            }
        }
        //CHỈNH SỬA KHÓA HỌC.
        private void ChinhSuaKhoaHoc()
        {
            KhoaHoc_ThongTin KH = new KhoaHoc_ThongTin();
            KH.MaKhoaHoc = txtMaKhoaHoc.Text;
            KH.NgayBatDau = txtNgayBatDau.Value;
            KH.NgayKetThuc = txtNgayKetThuc.Value;
            try
            {
                cls_KhoaHoc.ChinhSuaKhoaHoc(KH);
                MessageBox.Show("Bạn đã chỉnh sửa thông tin khóa học "+KH.MaKhoaHoc+".", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa, hãy kiểm tra lại,", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DuLieu != null)
            {
                DuLieu(KH);
            }
            this.Hide();
        }
        //KHI CLICK XÁC NHẬN.
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ChucNang.Equals("F9"))
            {
                ThemKhoaHoc();
            }
            if (this.ChucNang.Equals("F10"))
            {
                ChinhSuaKhoaHoc();
            }
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
