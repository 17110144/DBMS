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
    public partial class QuanLyTaiKhoan : Form
    {
        //KHAI BÁO DÙNG CHUNG
        DangNhap_B cls_DangNhap = new DangNhap_B();
        //
        string ChucNang = null;
        public QuanLyTaiKhoan(string ChucNang, DangNhap_ThongTin DN)
        {
            InitializeComponent();
            cbQuyen.DataSource = cls_DangNhap.DanhSachQuyen();
            cbQuyen.DisplayMember = "Quyen";
            cbQuyen.ValueMember = "Quyen";
            this.ChucNang = ChucNang;
            if (this.ChucNang.Equals("F9"))
            {
                txtTaiKhoan.Focus();
                btHoanTat.Enabled = false;
            }
            if (this.ChucNang.Equals("F10"))
            {
                txtTaiKhoan.Text = DN.TaiKhoan;
                cbQuyen.SelectedValue = DN.Quyen;
                btHoanTat.Enabled = false;
                txtTaiKhoan.Enabled = false;
            }
        }
        //DỮ LIỆU TRUYỀN VỀ.
        public delegate void DuLieuTruyenVe(DangNhap_ThongTin DN);
        public DuLieuTruyenVe DuLieu;
        //THÊM TÀI KHOẢN MỚI.
        private void ThemTaiKhoan()
        {
            DangNhap_ThongTin DN = new DangNhap_ThongTin();
            DN.TaiKhoan = txtTaiKhoan.Text;
            DN.Quyen = cbQuyen.SelectedValue.ToString();
            try
            {
                if (!DN.TaiKhoan.Equals(""))
                {
                    cls_DangNhap.ThemTaiKhoan(DN);
                    MessageBox.Show("Bạn đã thêm tài khoản " + DN.TaiKhoan + "", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Hãy nhập tên tài khoản");
                    txtTaiKhoan.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới, có thể khóa chính bị trùng.", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTaiKhoan.ResetText();
            txtTaiKhoan.Focus();
            btHoanTat.Enabled = true;
            if (DuLieu != null)
            {
                DuLieu(DN);
            }
        }
        //CHỈNH SỬA TÀI KHOẢN.
        private void SuaTaiKhoan()
        {
            DangNhap_ThongTin DN = new DangNhap_ThongTin();
            DN.TaiKhoan = txtTaiKhoan.Text;
            DN.Quyen = cbQuyen.SelectedValue.ToString();
            try
            {
                cls_DangNhap.ChinhSuaQuyen(DN);
                MessageBox.Show("Bạn đã chỉnh sửa thông tin tài khoản " + DN.TaiKhoan + ".", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa, hãy kiểm tra lại,", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DuLieu != null)
            {
                DuLieu(DN);
            }
            this.Hide();
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ChucNang.Equals("F9"))
            {
                ThemTaiKhoan();
            }
            if (this.ChucNang.Equals("F10"))
            {
                SuaTaiKhoan();
            }
        }
    }
}
