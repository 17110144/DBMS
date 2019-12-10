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
    public partial class QuanLyHocKy : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG HỌC KỲ.
        HocKy_B cls_HocKy = new HocKy_B();
        //
        string ChucNang = null;
        public QuanLyHocKy(string ChucNang, HocKy_ThongTin HK)
        {
            InitializeComponent();
            this.ChucNang = ChucNang;
            if (this.ChucNang.Equals("F9"))
            {
                txtMaHocKy.Focus();
                btHoanTat.Enabled = false;
            }
            if (this.ChucNang.Equals("F10"))
            {
                txtMaHocKy.Text = HK.MaHocKy;
                txtTenHocKy.Text = HK.TenHocKy;
                btHoanTat.Enabled = false;
                txtMaHocKy.Enabled = false;
                txtTenHocKy.Focus();
            }
        }
        //DỮ LIỆU TRUYỀN VỀ.
        public delegate void DuLieuTruyenVe(HocKy_ThongTin HK);
        public DuLieuTruyenVe DuLieu;
        //THÊM HỌC KỲ MỚI.
        private void ThemHocKy()
        {
            HocKy_ThongTin HK = new HocKy_ThongTin();
            HK.MaHocKy = txtMaHocKy.Text;
            HK.TenHocKy = txtTenHocKy.Text;
            try
            {
                if (!HK.MaHocKy.Equals(""))
                {
                    cls_HocKy.ThemHocKy(HK);
                    MessageBox.Show("Bạn đã thêm học kỳ " + HK.MaHocKy + "", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Hãy nhập mã học kỳ");
                    txtMaHocKy.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới, có thể khóa chính bị trùng.", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMaHocKy.ResetText();
            txtMaHocKy.Focus();
            txtTenHocKy.ResetText();
            btHoanTat.Enabled = true;
            if (DuLieu != null)
            {
                DuLieu(HK);
            }
        }
        //CHỈNH SỬA HỌC KỲ.
        private void SuaHocKy()
        {
            HocKy_ThongTin HK = new HocKy_ThongTin();
            HK.MaHocKy = txtMaHocKy.Text;
            HK.TenHocKy = txtTenHocKy.Text;
            try
            {
                cls_HocKy.SuaHocKy(HK);
                MessageBox.Show("Bạn đã chỉnh sửa thông tin học kỳ " + HK.MaHocKy + ".", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa, hãy kiểm tra lại,", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DuLieu != null)
            {
                DuLieu(HK);
            }
            this.Hide();
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void QuanLyHocKy_Load(object sender, EventArgs e)
        {
            txtMaHocKy.Focus();
        }
        //KHI CLICK XÁC NHẬN
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ChucNang.Equals("F9"))
            {
                ThemHocKy();
            }
            if (this.ChucNang.Equals("F10"))
            {
                SuaHocKy();
            }
        }
    }
}
