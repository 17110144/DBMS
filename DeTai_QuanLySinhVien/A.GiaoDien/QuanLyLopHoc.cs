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
    public partial class QuanLyLopHoc : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG HÊ ĐÀO TẠO
        HeDaoTao_B cls_HDT = new HeDaoTao_B();
        //BẢNG KHÓA HOC
        KhoaHoc_B cls_KH = new KhoaHoc_B();
        //BẢNG NGÀNH ĐÀO TẠO
        NganhDaoTao_B cls_NDT = new NganhDaoTao_B();
        //BẢNG LỚP
        Lop_B cls_LOP = new Lop_B();
        string ChucNang = null;
        public QuanLyLopHoc(string ChucNang, Lop_ThongTin Lop)
        {
            InitializeComponent();
            cbHeDaoTao.DataSource = cls_HDT.viewDanhSachTenHeDaoTao();
            cbHeDaoTao.DisplayMember = "TenHe";
            cbHeDaoTao.ValueMember = "MaHe";
            cbKhoaHoc.DataSource = cls_KH.viewDanhSachTenKhoaHoc();  
            cbKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
            cbTenNganh.DataSource = cls_NDT.viewDanhSachTenNganhDaoTao();
            cbTenNganh.DisplayMember = "TenNganh";
            cbTenNganh.ValueMember = "MaNganh";
            this.ChucNang = ChucNang;
            if (ChucNang.Equals("F9"))
            {
                txtMaLop.Focus();
                btHoanTat.Enabled = false;
            }
            if (ChucNang.Equals("F10"))
            {
                txtMaLop.Text = Lop.MaLop;
                txtTenLop.Text = Lop.TenLop;
                cbKhoaHoc.Text = Lop.MaKhoaHoc;
                cbHeDaoTao.Text = Lop.MaHeDaoTao;
                cbTenNganh.Text = Lop.MaNganh;
                btHoanTat.Enabled = false;
                txtMaLop.Enabled = false;
                txtTenLop.Focus();
            }
        }
        //DỮ LIỆU TRUYỀN VỀ.
        public delegate void DuLieuTruyenVe(Lop_ThongTin Lop);
        public DuLieuTruyenVe DuLieu;
        //
        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {

        }
        //THÊM LỚP HỌC MỚI.
        private void ThemMoiLopHoc()
        {
            Lop_ThongTin LOP = new Lop_ThongTin();
            LOP.MaLop = txtMaLop.Text;
            LOP.TenLop = txtTenLop.Text;
            LOP.MaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();
            LOP.MaHeDaoTao = cbHeDaoTao.SelectedValue.ToString();
            LOP.MaNganh = cbTenNganh.SelectedValue.ToString();
            try
            {
                cls_LOP.ThemLopHocMoi(LOP);
                MessageBox.Show("Bạn đã thêm lớp học " + LOP.TenLop + " với mã " + LOP.MaLop + " vào hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtMaLop.ResetText();
                txtTenLop.ResetText();
                txtMaLop.Focus();
                btHoanTat.Enabled = true;
                if (DuLieu != null)
                {
                    DuLieu(LOP);
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới, hãy xem xét lại!.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //SỬA THÔNG TIN LỚP HỌC.
        private void SuaThongTinLopHoc()
        {
            Lop_ThongTin LOP = new Lop_ThongTin();
            LOP.MaLop = txtMaLop.Text;
            LOP.TenLop = txtTenLop.Text;
            LOP.MaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();
            LOP.MaHeDaoTao = cbHeDaoTao.SelectedValue.ToString();
            LOP.MaNganh = cbTenNganh.SelectedValue.ToString();
            try
            {
                cls_LOP.SuaThongTinLopHoc(LOP);
                MessageBox.Show("Bạn sửa thông tin lớp học có mã " + LOP.MaLop + " trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (DuLieu != null)
                {
                    DuLieu(LOP);
                }
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa, hãy xem xét lại!.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //KHI ẤN NÚT XÁC NHẬN
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (ChucNang.Equals("F9"))
            {
                ThemMoiLopHoc();
            }
            if (ChucNang.Equals("F10"))
            {
                SuaThongTinLopHoc();
            }
                
        }
        //TẮT.
        private void btHoanTat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //PHÍM TẮT ENTER DÙNG KHI SỬA MÔN HỌC.
        private void KhiAnEnTerOTenLop(object sender, KeyEventArgs e)
        {
            if (ChucNang.Equals("F10"))
            {
                if (e.KeyValue.ToString() == "13")
                {
                    SuaThongTinLopHoc();
                }
            }
        }

        private void TimKiemNganhDaoTao(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
                NDT.TenNganh = cbTenNganh.Text;
                cbTenNganh.DataSource = cls_NDT.TimKiemNganhDaoTao(NDT);
                cbTenNganh.DisplayMember = "TenNganh";
                cbTenNganh.ValueMember = "MaNganh";
            }
        }       
    }
}
