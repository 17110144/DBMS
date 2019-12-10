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
    public partial class DanhSachHocKy : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //HỌC KỲ
        HocKy_B cls_HocKy = new HocKy_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaHocKy = null;
        public DanhSachHocKy()
        {
            InitializeComponent();
        }
        //SAU KHI KHỞI TẠO.
        private void DanhSachHocKy_Load(object sender, EventArgs e)
        {
            try
            {
                tbDanhSachHocKy.DataSource = cls_HocKy.viewDanhSachThongTinHocKy();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(HocKy_ThongTin HocKy)
        {
            this.MaHocKy = HocKy.MaHocKy;
            if (!this.MaHocKy.Equals(""))
            {
                try
                {
                    tbDanhSachHocKy.DataSource = cls_HocKy.viewDanhSachThongTinHocKy();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemHocKy()
        {
            ChucNang = "F9";
            HocKy_ThongTin HocKy = new HocKy_ThongTin(); 
            A.GiaoDien.QuanLyHocKy QLHK = new A.GiaoDien.QuanLyHocKy(ChucNang, HocKy);
            QLHK.DuLieu = new QuanLyHocKy.DuLieuTruyenVe(LayDuLieu);
            QLHK.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemHocKy();
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaHocKy()
        {
            ChucNang = "F10";
            HocKy_ThongTin HocKy = new HocKy_ThongTin(); 
            HocKy.MaHocKy = tbDanhSachHocKy.Rows[DongChon].Cells[0].Value.ToString();
            HocKy.TenHocKy = tbDanhSachHocKy.Rows[DongChon].Cells[1].Value.ToString();
            A.GiaoDien.QuanLyHocKy QLHK = new A.GiaoDien.QuanLyHocKy(ChucNang, HocKy);
            QLHK.DuLieu = new QuanLyHocKy.DuLieuTruyenVe(LayDuLieu);
            QLHK.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        private void tbDanhSachHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaHocKy();
        }
        //XÓA HỌC KỲ
        private void XoaHocKy()
        {
            if (XacNhanXoa == 1)
            {
                HocKy_ThongTin HocKy = new HocKy_ThongTin();
                HocKy.MaHocKy = tbDanhSachHocKy.Rows[DongChon].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin học kỳ " + HocKy.MaHocKy + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cls_HocKy.XoaHocKy(HocKy);
                        tbDanhSachHocKy.DataSource = cls_HocKy.viewDanhSachThongTinHocKy();
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
            XoaHocKy();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                HocKy_ThongTin HK = new HocKy_ThongTin();
                HK.MaHocKy = txtTimKiem.Text;
                tbDanhSachHocKy.DataSource = cls_HocKy.TimKiemHocKy(HK);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemHocKy();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaHocKy();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaHocKy();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.YellowGreen;
                txtTimKiem.Focus();
            }
            txtTimKiem.Focus();
        }

        private void KichDupChuot(object sender, MouseEventArgs e)
        {
            SuaHocKy();
            txtTimKiem.Focus();
        }


    }
}
