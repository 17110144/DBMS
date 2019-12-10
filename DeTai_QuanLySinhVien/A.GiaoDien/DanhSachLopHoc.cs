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
    public partial class DanhSachLopHoc : Form
    {
        //KHAI BÁO DÙNG CHUNG.
        //BẢNG LỚP HOC.
        Lop_B cls_Lop = new Lop_B();

        int DongChon = 0;
        string ChucNang = null;
        string MaLop = null;
        public DanhSachLopHoc()
        {
            InitializeComponent();
        }
        private void DanhSachLopHoc_Load(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
            tbDanhSachLopHoc.DataSource = cls_Lop.DanhSach_ThongTin_Lop();
        }
        //KHI KICH DUP CHUỘT CHỌN LỚP NHẬP ĐIỂM.
        private void NhapDiemChoLop()
        {
            ChucNang = "F1";
            BangDiem_ThongTin BD = new BangDiem_ThongTin();
            string MaLop = tbDanhSachLopHoc.Rows[DongChon].Cells[0].Value.ToString();
            A.GiaoDien.NhapDiem ND = new A.GiaoDien.NhapDiem(ChucNang, MaLop, BD);
            ND.ShowDialog(this);
            XacNhanXoa = "0";
            txtTimKiem.Focus();
        }
        private void KhiChonLopNhapDiem(object sender, MouseEventArgs e)
        {
            NhapDiemChoLop();
        }
        
        //KHI CHỌN LỚP HỌC.
        private void tbDanhSachLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XacNhanXoa = "1";
            DongChon = e.RowIndex;
            txtTimKiem.Focus();
        }
        //KHI CHỌN NHẬP ĐIỂM
        private void btNhapDiem_Click(object sender, EventArgs e)
        {
            NhapDiemChoLop();
        }
        //TÌM KIẾM VÀ PHÍM TẮT
        private void KhiTimKiem_PhimTat(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("112") && !e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123") && !e.KeyValue.ToString().Equals("13"))
            {
                txtTimKiem.BackColor = Color.White;
                Lop_ThongTin LOP = new Lop_ThongTin();
                LOP.MaLop = txtTimKiem.Text;
                tbDanhSachLopHoc.DataSource = cls_Lop.TimKiemLopHoc(LOP);
               
            }
            if (e.KeyValue.ToString().Equals("112"))
            {
                NhapDiemChoLop();
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemLopHoc();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaThongTinLopHoc();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaLopHoc();
            }
            if (e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.YellowGreen;
                txtTimKiem.Focus();
            }
        }
        //KÍCH CHỌN THÊM LỚP HỌC MỚI.
        private void ThemLopHoc()
        {
            ChucNang = "F9";
            Lop_ThongTin Lop = new Lop_ThongTin();
            A.GiaoDien.QuanLyLopHoc QLLH = new A.GiaoDien.QuanLyLopHoc(ChucNang, Lop);
            QLLH.DuLieu = new QuanLyLopHoc.DuLieuTruyenVe(LayDuLieu);
            QLLH.ShowDialog(this);
            txtTimKiem.Focus();
            XacNhanXoa = "0";
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            ThemLopHoc();
        }
        //LẤY DỮ LIỆU TRUYỀN VỀ.
        public void LayDuLieu(Lop_ThongTin Lop)
        {
            this.MaLop = Lop.MaLop;
            if (!MaLop.Equals(""))
            {
                tbDanhSachLopHoc.DataSource = cls_Lop.DanhSach_ThongTin_Lop();
            }
        }
        //KÍCH CHỌN SỬA THÔNG TIN LỚP HỌC.
        private void SuaThongTinLopHoc()
        {
            ChucNang = "F10";
            Lop_ThongTin Lop = new Lop_ThongTin();
            Lop.MaLop = tbDanhSachLopHoc.Rows[DongChon].Cells[0].Value.ToString();
            Lop.TenLop = tbDanhSachLopHoc.Rows[DongChon].Cells[1].Value.ToString();
            Lop.MaKhoaHoc = tbDanhSachLopHoc.Rows[DongChon].Cells[2].Value.ToString();
            Lop.MaHeDaoTao = tbDanhSachLopHoc.Rows[DongChon].Cells[3].Value.ToString();
            Lop.MaNganh = tbDanhSachLopHoc.Rows[DongChon].Cells[4].Value.ToString();
            A.GiaoDien.QuanLyLopHoc QLLH = new A.GiaoDien.QuanLyLopHoc(ChucNang, Lop);
            QLLH.DuLieu = new QuanLyLopHoc.DuLieuTruyenVe(LayDuLieu);
            QLLH.ShowDialog(this);
            txtTimKiem.Focus();
            XacNhanXoa = "0";
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaThongTinLopHoc();
        }
        string XacNhanXoa = "0";
        //XÓA LỚP HỌC
        private void XoaLopHoc()
        {
            if (XacNhanXoa.Equals("1"))
            {
                Lop_ThongTin Lop = new Lop_ThongTin();
                Lop.MaLop = tbDanhSachLopHoc.Rows[DongChon].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin lớp có mã " + Lop.MaLop + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cls_Lop.XoaLopHoc(Lop);
                        tbDanhSachLopHoc.DataSource = cls_Lop.DanhSach_ThongTin_Lop();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dữ liệu này, hãy kiểm tra kết nối!", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                XacNhanXoa = "0";
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn lớp muốn xóa.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTimKiem.Focus();
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            XoaLopHoc();
        }
    }
}
