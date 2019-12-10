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
    public partial class DanhSachMonHoc : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //MÔN HỌC
        MonHoc_B cls_MonHoc = new MonHoc_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaMonHoc = null;
        public DanhSachMonHoc()
        {
            InitializeComponent();
        }
        //SAU KHI KHỞI TẠO
        private void DanhSachMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                tbDanhSachMonHoc.DataSource = cls_MonHoc.DanhSachMonHocToanTruong();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(MonHoc_ThongTin MonHoc)
        {
            this.MaMonHoc = MonHoc.MaMonHoc;
            if (!this.MaMonHoc.Equals(""))
            {
                try
                {
                    tbDanhSachMonHoc.DataSource = cls_MonHoc.DanhSachMonHocToanTruong();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemMonHoc()
        {
            ChucNang = "F9";
            MonHoc_ThongTin MonHoc = new MonHoc_ThongTin();
            A.GiaoDien.MonHoc MH = new A.GiaoDien.MonHoc(ChucNang, MonHoc);
            MH.DuLieu = new MonHoc.DuLieuTruyenVe(LayDuLieu);
            MH.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            ThemMonHoc();
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaMonHoc()
        {
            ChucNang = "F10";
            MonHoc_ThongTin MonHoc = new MonHoc_ThongTin();
            MonHoc.MaMonHoc = tbDanhSachMonHoc.Rows[DongChon].Cells[0].Value.ToString();
            MonHoc.TenMonHoc = tbDanhSachMonHoc.Rows[DongChon].Cells[1].Value.ToString();
            MonHoc.SoTinChi = int.Parse(tbDanhSachMonHoc.Rows[DongChon].Cells[2].Value.ToString());
            A.GiaoDien.MonHoc MH = new A.GiaoDien.MonHoc(ChucNang, MonHoc);
            MH.DuLieu = new MonHoc.DuLieuTruyenVe(LayDuLieu);
            MH.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaMonHoc();
            txtTimKiem.Focus();
        }
        private void tbDanhSachMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //XÓA MÔN HỌC
        private void XoaMonHoc()
        {
            if (XacNhanXoa == 1)
            {
                MonHoc_ThongTin MonHoc = new MonHoc_ThongTin();
                MonHoc.MaMonHoc = tbDanhSachMonHoc.Rows[DongChon].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin môn học " + MonHoc.MaMonHoc + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cls_MonHoc.XoaMonHoc(MonHoc);
                        tbDanhSachMonHoc.DataSource = cls_MonHoc.DanhSachMonHocToanTruong();
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
            XoaMonHoc();
            txtTimKiem.Focus();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                MonHoc_ThongTin MH = new MonHoc_ThongTin();
                MH.MaMonHoc = txtTimKiem.Text;
                tbDanhSachMonHoc.DataSource = cls_MonHoc.TimMonHoc(MH);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemMonHoc();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaMonHoc();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaMonHoc();
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
            SuaMonHoc();
            txtTimKiem.Focus();
        }


    }
}
