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
    public partial class QuanLyNganhDaoTao : Form
    {
        //KHAI BÁO DUNG CHUNG
        //BẢNG KHOA
        Khoa_B cls_Khoa = new Khoa_B();
        //BẢNG NGÀNH ĐÀO TẠO
        NganhDaoTao_B cls_NganhDaoTao = new NganhDaoTao_B();
        //
        string ChucNang = null;
        public QuanLyNganhDaoTao(string ChucNang, NganhDaoTao_ThongTin NDT)
        {
            InitializeComponent();
            this.ChucNang = ChucNang;
            if (this.ChucNang.Equals("F9"))
            {
                txtMaNganh.Focus();
                btHoanTat.Enabled = false;
            }
            if (this.ChucNang.Equals("F10"))
            {
                txtMaNganh.Text = NDT.MaNganh;
                txtTenNganh.Text = NDT.TenNganh;
                cbTenKhoa.SelectedValue = NDT.MaKhoa;
                btHoanTat.Enabled = false;
                txtMaNganh.Enabled = false;
                txtTenNganh.Focus();
            }
        }

        private void QuanLyNganhDaoTao_Load(object sender, EventArgs e)
        {
            //LOAD O COMBOBOX
            cbTenKhoa.DataSource = cls_Khoa.DanhSachKhoa();
            cbTenKhoa.DisplayMember = "TenKhoa";
            cbTenKhoa.ValueMember = "MaKhoa";

            txtMaNganh.Focus();
        }
        //DỮ LIỆU TRUYỀN VỀ.
        public delegate void DuLieuTruyenVe(NganhDaoTao_ThongTin NDT);
        public DuLieuTruyenVe DuLieu;
        //THÊM NGÀNH ĐÀO TẠO MỚI.
        private void ThemNganhDaoTao()
        {
            NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
            NDT.MaNganh = txtMaNganh.Text;
            NDT.TenNganh = txtTenNganh.Text;
            NDT.MaKhoa = cbTenKhoa.SelectedValue.ToString();
            try
            {
                if (!NDT.MaNganh.Equals(""))
                {
                    cls_NganhDaoTao.ThemNganhDaoTao(NDT);
                    MessageBox.Show("Bạn đã thêm ngành đào tạo có mã " + NDT.MaNganh + "", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Hãy nhập mã ngành.");
                    txtMaNganh.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới, có thể khóa chính bị trùng.", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMaNganh.ResetText();
            txtMaNganh.Focus();
            txtTenNganh.ResetText();
            btHoanTat.Enabled = true;
            if (DuLieu != null)
            {
                DuLieu(NDT);
            }
        }
        //CHỈNH SỬA KHOA.
        private void SuaNganhDaoTao()
        {
            NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
            NDT.MaNganh = txtMaNganh.Text;
            NDT.TenNganh = txtTenNganh.Text;
            NDT.MaKhoa = cbTenKhoa.SelectedValue.ToString();
            try
            {
                cls_NganhDaoTao.SuaNganhDaoTao(NDT);
                MessageBox.Show("Bạn đã chỉnh sửa thông tin ngành đào tạo " + NDT.MaNganh + ".", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa, hãy kiểm tra lại,", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DuLieu != null)
            {
                DuLieu(NDT);
            }
            this.Hide();
        }
        //
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ChucNang.Equals("F9"))
            {
                ThemNganhDaoTao();
            }
            if (this.ChucNang.Equals("F10"))
            {
                SuaNganhDaoTao();
            }
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
