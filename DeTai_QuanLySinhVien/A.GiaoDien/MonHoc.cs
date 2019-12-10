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
    public partial class MonHoc : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //MÔN HỌC
        MonHoc_B cls_MonHoc = new MonHoc_B();
        //
        string ChucNang = null;
        public MonHoc(string ChucNang, MonHoc_ThongTin MH)
        {
            InitializeComponent();
            this.ChucNang = ChucNang;
            if (this.ChucNang.Equals("F9"))
            {
                txtMaMonHoc.Focus();
                btHoanTat.Enabled = false;
            }
            if (this.ChucNang.Equals("F10"))
            {
                txtMaMonHoc.Text = MH.MaMonHoc;
                txtTenMonHoc.Text = MH.TenMonHoc;
                txtSoTinChi.Value = MH.SoTinChi;
                btHoanTat.Enabled = false;
                txtMaMonHoc.Enabled = false;
                txtTenMonHoc.Focus();
            }
        }
        //DỮ LIỆU TRUYỀN VỀ.
        public delegate void DuLieuTruyenVe(MonHoc_ThongTin MH);
        public DuLieuTruyenVe DuLieu;
        //THÊM MÔN HỌC MỚI.
        private void ThemMonHoc()
        {
            MonHoc_ThongTin MH = new MonHoc_ThongTin();
            MH.MaMonHoc = txtMaMonHoc.Text;
            MH.TenMonHoc = txtTenMonHoc.Text;
            MH.SoTinChi = int.Parse(txtSoTinChi.Value.ToString());
            try
            {
                if (!MH.MaMonHoc.Equals(""))
                {
                    cls_MonHoc.ThemMonHoc(MH);
                    MessageBox.Show("Bạn đã thêm môn học có mã " + MH.MaMonHoc + "", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Hãy nhập mã khóa học");
                    txtMaMonHoc.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới, có thể khóa chính bị trùng.", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMaMonHoc.ResetText();
            txtMaMonHoc.Focus();
            txtTenMonHoc.ResetText();
            btHoanTat.Enabled = true;
            if (DuLieu != null)
            {
                DuLieu(MH);
            }
        }
         //CHỈNH SỬA MÔN HỌC.
        private void SuaMonHoc()
        {
            MonHoc_ThongTin MH = new MonHoc_ThongTin();
            MH.MaMonHoc = txtMaMonHoc.Text;
            MH.TenMonHoc = txtTenMonHoc.Text;
            MH.SoTinChi = int.Parse(txtSoTinChi.Value.ToString());
            try
            {
                cls_MonHoc.SuaMonHoc(MH);
                MessageBox.Show("Bạn đã chỉnh sửa thông tin môn học "+MH.MaMonHoc+".", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa, hãy kiểm tra lại,", "Thông báo lối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DuLieu != null)
            {
                DuLieu(MH);
            }
            this.Hide();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ChucNang.Equals("F9"))
            {
                ThemMonHoc();
            }
            if (this.ChucNang.Equals("F10"))
            {
                SuaMonHoc();
            }
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            txtMaMonHoc.Focus();
        }
    }
}
