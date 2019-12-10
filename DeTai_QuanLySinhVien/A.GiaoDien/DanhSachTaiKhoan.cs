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
    public partial class DanhSachTaiKhoan : Form
    {
        //KHAI BÁO DÙNG CHUNG
        DangNhap_B cls_DangNhap = new DangNhap_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string TaiKhoan = null;
        public DanhSachTaiKhoan()
        {
            InitializeComponent();
        }
        //SAU KHI KOWIR TẠO
        private void DanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                tbDanhSachTaiKhoan.DataSource = cls_DangNhap.DanhSachTaiKhoan();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(DangNhap_ThongTin DN)
        {
            this.TaiKhoan = DN.TaiKhoan;
            if (!this.TaiKhoan.Equals(""))
            {
                try
                {
                    tbDanhSachTaiKhoan.DataSource = cls_DangNhap.DanhSachTaiKhoan();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemTaiKhoan()
        {
            ChucNang = "F9";
            DangNhap_ThongTin DangNhap = new DangNhap_ThongTin(); 
            A.GiaoDien.QuanLyTaiKhoan QLTK = new A.GiaoDien.QuanLyTaiKhoan(ChucNang, DangNhap);
            QLTK.DuLieu = new QuanLyTaiKhoan.DuLieuTruyenVe(LayDuLieu);
            QLTK.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan();
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaTaiKhoan()
        {
            ChucNang = "F10";
            DangNhap_ThongTin DangNhap = new DangNhap_ThongTin();
            DangNhap.TaiKhoan = tbDanhSachTaiKhoan.Rows[DongChon].Cells[0].Value.ToString();
            DangNhap.Quyen = tbDanhSachTaiKhoan.Rows[DongChon].Cells[1].Value.ToString();
             A.GiaoDien.QuanLyTaiKhoan QLTK = new A.GiaoDien.QuanLyTaiKhoan(ChucNang, DangNhap);
            QLTK.DuLieu = new QuanLyTaiKhoan.DuLieuTruyenVe(LayDuLieu);
            QLTK.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        //KÍCH SỬA
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaTaiKhoan();
        }
        //KÍCH VÀO BẢNG
        private void tbDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //XÓA TÀI KHOẢN
        private void XoaTaiKhoan()
        {
            if (XacNhanXoa == 1)
            {
                DangNhap_ThongTin DangNhap = new DangNhap_ThongTin();
                DangNhap.TaiKhoan = tbDanhSachTaiKhoan.Rows[DongChon].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin tài khoản " + DangNhap.TaiKhoan + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cls_DangNhap.XoaTaiKhoan(DangNhap);
                        tbDanhSachTaiKhoan.DataSource = cls_DangNhap.DanhSachTaiKhoan();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dữ liệu này, hãy kiểm tra lại.!", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                XacNhanXoa = 0;
                txtTimKiem.Focus();
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn khóa học muốn xóa.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTimKiem.Focus();
            }
        }
        //
        private void btXoa_Click(object sender, EventArgs e)
        {
            XoaTaiKhoan();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                DangNhap_ThongTin DN = new DangNhap_ThongTin();
                DN.TaiKhoan = txtTimKiem.Text;
                tbDanhSachTaiKhoan.DataSource = cls_DangNhap.TimKiemTaiKhoan(DN);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemTaiKhoan();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaTaiKhoan();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaTaiKhoan();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.YellowGreen;
                txtTimKiem.Focus();
            }
            txtTimKiem.Focus();
        }

        private void KichDup(object sender, MouseEventArgs e)
        {
            SuaTaiKhoan();
            txtTimKiem.Focus();
        }


    }
}
