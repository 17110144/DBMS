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
    public partial class GiaoDienChinh : Form
    {
        private string TaiKhoan = null;
        private string MatKhau = null;
        private string Quyen = null;
        private bool TrangThai = false;
        public GiaoDienChinh(DangNhap_ThongTin DN)
        {
            InitializeComponent();
            txtQuyen.Text = DN.Quyen;
            txtTen.Text = DN.TaiKhoan;

            this.TaiKhoan = DN.TaiKhoan;
            this.MatKhau = DN.MatKhau;
            this.Quyen = DN.Quyen;
            this.TrangThai = DN.TrangThai;

            TrangChu TC = new TrangChu();
            TC.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(TC);
            TC.Show();
        }
        //DỮ LIỆU TRUYỀN VỀ.
        public delegate void DuLieuTruyenVe(DangNhap_ThongTin DN);
        public DuLieuTruyenVe DuLieu;

        private void btQuanLySinhVien_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien DSSV = new DanhSachSinhVien();
            DSSV.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(DSSV);
            DSSV.Show();
        }

        private void btQuanLyDiem_Click(object sender, EventArgs e)
        {
            DanhSachLopHoc DSLH = new DanhSachLopHoc();
            DSLH.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(DSLH);
            DSLH.Show();
        }

        private void btXetHocBong_Click(object sender, EventArgs e)
        {
            HocBong_DSSV HB_DSSV = new HocBong_DSSV();
            HB_DSSV.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(HB_DSSV);
            HB_DSSV.Show();
        }

        private void btXetRaTruong_Click(object sender, EventArgs e)
        {
            RaTruong_DSSV RT_DSSV = new RaTruong_DSSV();
            RT_DSSV.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(RT_DSSV);
            RT_DSSV.Show();
        }

        private void btKhoaHoc_Click(object sender, EventArgs e)
        {
            DanhSachKhoaHoc DSKH = new DanhSachKhoaHoc();
            DSKH.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(DSKH);
            DSKH.Show();
        }

        private void btMonHoc_Click(object sender, EventArgs e)
        {
            DanhSachMonHoc DSMH = new DanhSachMonHoc();
            DSMH.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(DSMH);
            DSMH.Show();
        }

        private void btHocKy_Click(object sender, EventArgs e)
        {
            DanhSachHocKy DSHK = new DanhSachHocKy();
            DSHK.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(DSHK);
            DSHK.Show();
        }

        private void btHeDaoTao_Click(object sender, EventArgs e)
        {
            DanhSachHeDaoTao DSHDT = new DanhSachHeDaoTao();
            DSHDT.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(DSHDT);
            DSHDT.Show();
        }

        private void btKhoa_Click(object sender, EventArgs e)
        {
            DanhSachKhoa DSK = new DanhSachKhoa();
            DSK.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(DSK);
            DSK.Show();
        }

        private void btNganhDaoTao_Click(object sender, EventArgs e)
        {
            DanhSachNganhDaoTao DSNDT = new DanhSachNganhDaoTao();
            DSNDT.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(DSNDT);
            DSNDT.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TrangChu TC = new TrangChu();
            TC.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(TC);
            TC.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhiDangXuat();
        }

        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            DangNhap_ThongTin DN = new DangNhap_ThongTin();
            DN.TaiKhoan = this.TaiKhoan;
            DN.MatKhau = this.MatKhau;
            DN.Quyen = this.Quyen;
            DN.TrangThai = this.TrangThai;
            A.GiaoDien.DoiMatKhau DMK = new A.GiaoDien.DoiMatKhau(DN);
            DMK.ShowDialog(this);
        }

        private void btQuanLuNguoiDung_Click(object sender, EventArgs e)
        {
            DanhSachTaiKhoan DSTK = new DanhSachTaiKhoan();
            DSTK.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(DSTK);
            DSTK.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu TC = new TrangChu();
            TC.TopLevel = false;
            HienThi.Controls.Clear();
            HienThi.Controls.Add(TC);
            TC.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap_ThongTin DN = new DangNhap_ThongTin();
            DN.TaiKhoan = this.TaiKhoan;
            DN.MatKhau = this.MatKhau;
            DN.Quyen = this.Quyen;
            DN.TrangThai = this.TrangThai;
            A.GiaoDien.DoiMatKhau DMK = new A.GiaoDien.DoiMatKhau(DN);
            DMK.ShowDialog(this);
        }

        //KHAI BÁO DÙNG CHUNG
        DangNhap_B cls_DangNhap = new DangNhap_B();
        //KHI ĐĂNG XUẤT
        public void KhiDangXuat()
        {
            DangNhap_ThongTin DN = new DangNhap_ThongTin();
            DN.TaiKhoan = txtTen.Text;
            DN.TrangThai = false;
            cls_DangNhap.UpDateTrangThai(DN);
            this.Close();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhiDangXuat();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
