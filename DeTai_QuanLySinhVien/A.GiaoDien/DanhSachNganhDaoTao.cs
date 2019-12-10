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
    public partial class DanhSachNganhDaoTao : Form
    {
        //KHAI BÁO DÙNG CHUNG
        NganhDaoTao_B cls_NganhDaoTao = new NganhDaoTao_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaNganh = null;
        public DanhSachNganhDaoTao()
        {
            InitializeComponent();
        }
        //SAU KHI KHỞI TẠO
        private void DanhSachNganhDaoTao_Load(object sender, EventArgs e)
        {
            try
            {
                tbNganhDaoTao.DataSource = cls_NganhDaoTao.DanhSachThongTinNganhDaoTao();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(NganhDaoTao_ThongTin NDT)
        {
            this.MaNganh = NDT.MaNganh;
            if (!this.MaNganh.Equals(""))
            {
                try
                {
                    tbNganhDaoTao.DataSource = cls_NganhDaoTao.DanhSachThongTinNganhDaoTao();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemNganhDaoTao()
        {
            ChucNang = "F9";
            NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
            A.GiaoDien.QuanLyNganhDaoTao QLNDT = new A.GiaoDien.QuanLyNganhDaoTao(ChucNang, NDT);
            QLNDT.DuLieu = new QuanLyNganhDaoTao.DuLieuTruyenVe(LayDuLieu);
            QLNDT.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        //
        private void btThem_Click(object sender, EventArgs e)
        {
            ThemNganhDaoTao();
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaNganhDaoTao()
        {
            ChucNang = "F10";
            NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
            NDT.MaNganh = tbNganhDaoTao.Rows[DongChon].Cells[0].Value.ToString();
            NDT.TenNganh = tbNganhDaoTao.Rows[DongChon].Cells[1].Value.ToString();
            NDT.MaKhoa = tbNganhDaoTao.Rows[DongChon].Cells[2].Value.ToString();
            A.GiaoDien.QuanLyNganhDaoTao QLNDT = new A.GiaoDien.QuanLyNganhDaoTao(ChucNang, NDT);
            QLNDT.DuLieu = new QuanLyNganhDaoTao.DuLieuTruyenVe(LayDuLieu);
            QLNDT.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }

        private void tbNganhDaoTao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaNganhDaoTao();
        }
        //XÓA NGÀNH ĐÀO TẠO.
        private void XoaNganhDaoTao()
        {
            if (XacNhanXoa == 1)
            {
                NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
                NDT.MaNganh = tbNganhDaoTao.Rows[DongChon].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin ngành " + NDT.MaNganh + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cls_NganhDaoTao.XoaNganhDaoTao(NDT);
                        tbNganhDaoTao.DataSource = cls_NganhDaoTao.DanhSachThongTinNganhDaoTao();
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
            XoaNganhDaoTao();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
                NDT.MaNganh = txtTimKiem.Text;
                tbNganhDaoTao.DataSource = cls_NganhDaoTao.TimKiemThongTinNganhDaoTao(NDT);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemNganhDaoTao();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaNganhDaoTao();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaNganhDaoTao();
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
            SuaNganhDaoTao();
            txtTimKiem.Focus();
        }


    }
}
