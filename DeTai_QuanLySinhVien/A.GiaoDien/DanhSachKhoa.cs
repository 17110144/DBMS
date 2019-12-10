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
    public partial class DanhSachKhoa : Form
    {
        //KHAI BÁO DÙNG CHUNG
        Khoa_B cls_Khoa = new Khoa_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaKhoa = null;
        public DanhSachKhoa()
        {
            InitializeComponent();
        }
        //SAU KHI KHỞI TẠO
        private void DanhSachKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                tbKhoa.DataSource = cls_Khoa.DanhSachKhoa();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(Khoa_ThongTin K)
        {
            this.MaKhoa = K.MaKhoa;
            if (!this.MaKhoa.Equals(""))
            {
                try
                {
                    tbKhoa.DataSource = cls_Khoa.DanhSachKhoa();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemKhoa()
        {
            ChucNang = "F9";
            Khoa_ThongTin Khoa = new Khoa_ThongTin();
            A.GiaoDien.QuanLyKhoa QLHK = new A.GiaoDien.QuanLyKhoa(ChucNang, Khoa);
            QLHK.DuLieu = new QuanLyKhoa.DuLieuTruyenVe(LayDuLieu);
            QLHK.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemKhoa();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaKhoa()
        {
            ChucNang = "F10";
            Khoa_ThongTin Khoa = new Khoa_ThongTin();
            Khoa.MaKhoa = tbKhoa.Rows[DongChon].Cells[0].Value.ToString();
            Khoa.TenKhoa = tbKhoa.Rows[DongChon].Cells[1].Value.ToString();
            A.GiaoDien.QuanLyKhoa QLHK = new A.GiaoDien.QuanLyKhoa(ChucNang, Khoa);
            QLHK.DuLieu = new QuanLyKhoa.DuLieuTruyenVe(LayDuLieu);
            QLHK.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        private void tbKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //XÓA KHÓA
        private void XoaKhoa()
        {
            if (XacNhanXoa == 1)
            {
                Khoa_ThongTin Khoa = new Khoa_ThongTin();
                Khoa.MaKhoa = tbKhoa.Rows[DongChon].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin khoa có mã " + Khoa.MaKhoa + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                    cls_Khoa.XoaKhoa(Khoa);
                    tbKhoa.DataSource = cls_Khoa.DanhSachKhoa();
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
            XoaKhoa();
            txtTimKiem.Focus();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                Khoa_ThongTin K = new Khoa_ThongTin();
                K.MaKhoa = txtTimKiem.Text;
                tbKhoa.DataSource = cls_Khoa.TimKiemKhoa(K);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemKhoa();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaKhoa();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaKhoa();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.YellowGreen;
                txtTimKiem.Focus();
            }
            txtTimKiem.Focus();
        }

        private void KhiKichDupChuot(object sender, MouseEventArgs e)
        {
            SuaKhoa();
            txtTimKiem.Focus();
            XacNhanXoa = 0;
        }
        //KÍCH SỬA
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaKhoa();
        }


    }
}
