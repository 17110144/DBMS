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
    public partial class DanhSachKhoaHoc : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG KHÓA HỌC
        KhoaHoc_B cls_KhoaHoc = new KhoaHoc_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaKhoaHoc = null;
        public DanhSachKhoaHoc()
        {
            InitializeComponent();
            try
            {
                tbKhoaHoc.DataSource = cls_KhoaHoc.DanhSach_ThongTin_KhoaHoc();
            }
            catch { }
        }

        public void LayDuLieu(KhoaHoc_ThongTin KhoaHoc)
        {
            this.MaKhoaHoc = KhoaHoc.MaKhoaHoc;
            if (!this.MaKhoaHoc.Equals(""))
            {
                try
                {
                    tbKhoaHoc.DataSource = cls_KhoaHoc.DanhSach_ThongTin_KhoaHoc();
                }
                catch { }
            }
        }
        //KHI CLICK BUTTON THÊM
        private void ThemKhoaHoc()
        {
            ChucNang = "F9";
            KhoaHoc_ThongTin KhoaHoc = new KhoaHoc_ThongTin();
            A.GiaoDien.KhoaHoc DSKH = new A.GiaoDien.KhoaHoc(ChucNang, KhoaHoc);
            DSKH.DuLieu = new KhoaHoc.DuLieuTruyenVe(LayDuLieu);
            DSKH.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            ThemKhoaHoc();
        }
        //KHI CLICK BUTTON SỬA
        private void SuaKhoaHoc()
        {
            ChucNang = "F10";
            KhoaHoc_ThongTin KhoaHoc = new KhoaHoc_ThongTin();
            KhoaHoc.MaKhoaHoc = tbKhoaHoc.Rows[DongChon].Cells[0].Value.ToString();
            KhoaHoc.NgayBatDau = DateTime.Parse(tbKhoaHoc.Rows[DongChon].Cells[1].Value.ToString());
            KhoaHoc.NgayKetThuc = DateTime.Parse(tbKhoaHoc.Rows[DongChon].Cells[2].Value.ToString());
            A.GiaoDien.KhoaHoc DSKH = new A.GiaoDien.KhoaHoc(ChucNang, KhoaHoc);
            DSKH.DuLieu = new KhoaHoc.DuLieuTruyenVe(LayDuLieu);
            DSKH.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaKhoaHoc();
        }

        private void tbKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //XÓA KHÓA HỌC
        private void XoaKhoaHoc()
        {
            if (XacNhanXoa == 1)
            {
                KhoaHoc_ThongTin KhoaHoc = new KhoaHoc_ThongTin();
                KhoaHoc.MaKhoaHoc = tbKhoaHoc.Rows[DongChon].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin khóa học " + KhoaHoc.MaKhoaHoc + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        cls_KhoaHoc.XoaKhoaHoc(KhoaHoc);
                        tbKhoaHoc.DataSource = cls_KhoaHoc.DanhSach_ThongTin_KhoaHoc();
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
        private void btXoa_Click(object sender, EventArgs e)
        {
            XoaKhoaHoc();
        }
        //BẮT SỰ KIỆN PHÍM TẮT - VÀ TÌM KIẾM.
        private void KhiAnOTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                KhoaHoc_ThongTin KH = new KhoaHoc_ThongTin();
                KH.MaKhoaHoc = txtTimKiem.Text;
                tbKhoaHoc.DataSource = cls_KhoaHoc.TimKiemKhoaHoc(KH);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemKhoaHoc();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaKhoaHoc();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaKhoaHoc();
            }
            if (e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.YellowGreen;
                txtTimKiem.Focus();
            }
        }

        private void DanhSachKhoaHoc_Load(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
        }

        private void KhiKichDupChuot(object sender, MouseEventArgs e)
        {
            SuaKhoaHoc();
        }


    }
}
