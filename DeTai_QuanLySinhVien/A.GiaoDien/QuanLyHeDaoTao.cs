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
    public partial class QuanLyHeDaoTao : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG HỆ ĐÀO TAO
        HeDaoTao_B cls_HeDaoTao = new HeDaoTao_B();
        //
        string ChucNang = null;
        public QuanLyHeDaoTao(string ChucNang, HeDaoTao_ThongTin HDT)
        {
            InitializeComponent();
            this.ChucNang = ChucNang;
            if (this.ChucNang.Equals("F9"))
            {
                txtMaHeDaoTao.Focus();
                btHoanTat.Enabled = false;
            }
            if (this.ChucNang.Equals("F10"))
            {
                txtMaHeDaoTao.Text = HDT.MaHe;
                txtTenHeDaoTao.Text = HDT.TenHe;
                btHoanTat.Enabled = false;
                txtMaHeDaoTao.Enabled = false;
                txtTenHeDaoTao.Focus();
            }
        }
        //DỮ LIỆU TRUYỀN VỀ.
        public delegate void DuLieuTruyenVe(HeDaoTao_ThongTin HDT);
        public DuLieuTruyenVe DuLieu;
        //THÊM 
        private void ThemHeDaoTao()
        {
            HeDaoTao_ThongTin HDT = new HeDaoTao_ThongTin();
            HDT.MaHe = txtMaHeDaoTao.Text;
            HDT.TenHe = txtTenHeDaoTao.Text;
            try
            {
                if (!HDT.MaHe.Equals(""))
                {
                    cls_HeDaoTao.ThemHeDaoTao(HDT);
                    MessageBox.Show("Bạn đã thêm hệ đào tạo có mã " + HDT.MaHe + "", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Hãy nhập mã hệ đào tạo");
                    txtMaHeDaoTao.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới, có thể khóa chính bị trùng.", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMaHeDaoTao.ResetText();
            txtMaHeDaoTao.Focus();
            txtTenHeDaoTao.ResetText();
            btHoanTat.Enabled = true;
            if (DuLieu != null)
            {
                DuLieu(HDT);
            }
        }
        //CHỈNH SỬA HỆ ĐÀO TẠO.
        private void SuaHeDaoTao()
        {
            HeDaoTao_ThongTin HDT = new HeDaoTao_ThongTin();
            HDT.MaHe = txtMaHeDaoTao.Text;
            HDT.TenHe = txtTenHeDaoTao.Text;
            try
            {
                cls_HeDaoTao.SuaHeDaoTao(HDT);
                MessageBox.Show("Bạn đã chỉnh sửa thông tin hệ đào tạo " + HDT.MaHe + ".", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa, hãy kiểm tra lại,", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DuLieu != null)
            {
                DuLieu(HDT);
            }
            this.Hide();
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void QuanLyHeDaoTao_Load(object sender, EventArgs e)
        {
            txtMaHeDaoTao.Focus();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ChucNang.Equals("F9"))
            {
                ThemHeDaoTao();
            }
            if (this.ChucNang.Equals("F10"))
            {
                SuaHeDaoTao();
            }
        }
    }
}
