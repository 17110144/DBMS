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
    public partial class DangNhap : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG THÔNG TIN ĐĂNG NHẬP
        DangNhap_B cls_DangNhap = new DangNhap_B();
        //
        string Quyen = null;
        public DangNhap()
        {
            InitializeComponent();
        }
        //ĐĂNG NHẬP
        private void DangNhapTaiKhoan()
        {
            if (txtTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Bạn hãy nhập tài khoản của mình", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtTaiKhoan.Focus();
            }
            else
            {
                if (txtMatKhau.Text.Equals(""))
                {
                    MessageBox.Show("Bạn hãy nhập mật khẩu của mình", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtMatKhau.Focus();
                }
                else
                {
                    DangNhap_ThongTin DN = new DangNhap_ThongTin();
                    DN.TaiKhoan = txtTaiKhoan.Text;
                    DN.MatKhau = txtMatKhau.Text;
                    DataTable Bang = new DataTable();
                    DataRow Hang;
                    Bang = cls_DangNhap.KiemTraDangNhap(DN);
                    try
                    {

                        Hang = Bang.Rows[0];
                        Quyen = Hang["Quyen"].ToString();
                        DN.Quyen = Quyen;
                        DN.TrangThai = true;
                        cls_DangNhap.UpDateTrangThai(DN);
                        A.GiaoDien.GiaoDienChinh GDC = new A.GiaoDien.GiaoDienChinh(DN);
                        GDC.ShowDialog(this);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu của bạn bị sai, hãy kiểm tra lại!", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhau.Text = "";
                        txtTaiKhoan.Focus();
                    }
                }
            }
            txtMatKhau.Focus();
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DangNhapTaiKhoan();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhiAnPhimTat(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                DangNhapTaiKhoan();
            }
            if (e.KeyValue.ToString() == "121")
            {
                DangNhapTaiKhoan();
            }
            if (e.KeyValue.ToString() == "122")
            {
                this.Close();
            }
        }

        private void KhiAnOTaiKhoan(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                DangNhapTaiKhoan();
            }
            if (e.KeyValue.ToString() == "121")
            {
                DangNhapTaiKhoan();
            }
            if (e.KeyValue.ToString() == "122")
            {
                this.Close();
            }
        }
    }
}
