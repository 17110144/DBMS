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
    public partial class QuanLyKhoa : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG KHOA
        Khoa_B cls_Khoa = new Khoa_B();
        //
        string ChucNang = null;
        public QuanLyKhoa(string ChucNang, Khoa_ThongTin K)
        {
            InitializeComponent();
            this.ChucNang = ChucNang;
            if (this.ChucNang.Equals("F9"))
            {
                txtMaKhoa.Focus();
                btHoanTat.Enabled = false;
            }
            if (this.ChucNang.Equals("F10"))
            {
                txtMaKhoa.Text = K.MaKhoa;
                txtTenKhoa.Text = K.TenKhoa;
                btHoanTat.Enabled = false;
                txtMaKhoa.Enabled = false;
                txtTenKhoa.Focus();
            }
        }
        //
        private void QuanLyKhoa_Load(object sender, EventArgs e)
        {
            txtMaKhoa.Focus();
        }
        //DỮ LIỆU TRUYỀN VỀ.
        public delegate void DuLieuTruyenVe(Khoa_ThongTin K);
        public DuLieuTruyenVe DuLieu;
        //THÊM KHOA MỚI.
        private void ThemKhoa()
        {
            Khoa_ThongTin K = new Khoa_ThongTin();
            K.MaKhoa = txtMaKhoa.Text;
            K.TenKhoa = txtTenKhoa.Text;
            try
            {
                if (!K.MaKhoa.Equals(""))
                {
                    cls_Khoa.ThemKhoa(K);
                    MessageBox.Show("Bạn đã thêm khoa có mã " + K.MaKhoa + "", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Hãy nhập mã khoa.");
                    txtMaKhoa.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới, có thể khóa chính bị trùng.", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMaKhoa.ResetText();
            txtMaKhoa.Focus();
            txtTenKhoa.ResetText();
            btHoanTat.Enabled = true;
            if (DuLieu != null)
            {
                DuLieu(K);
            }
        }
        //CHỈNH SỬA KHOA.
        private void SuaKhoa()
        {
            Khoa_ThongTin K = new Khoa_ThongTin();
            K.MaKhoa = txtMaKhoa.Text;
            K.TenKhoa = txtTenKhoa.Text;
            try
            {
                cls_Khoa.SuaKhoa(K);
                MessageBox.Show("Bạn đã chỉnh sửa thông tin khoa " + K.MaKhoa + ".", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa, hãy kiểm tra lại,", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DuLieu != null)
            {
                DuLieu(K);
            }
            this.Hide();
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ChucNang.Equals("F9"))
            {
                ThemKhoa();
            }
            if (this.ChucNang.Equals("F10"))
            {
                SuaKhoa();
            }
        }
    }
}
