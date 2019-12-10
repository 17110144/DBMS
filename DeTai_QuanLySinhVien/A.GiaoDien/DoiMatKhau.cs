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
    public partial class DoiMatKhau : Form
    {
        private string TaiKhoan = null;
        private string MatKhau = null;
        private string Quyen = null;
        private bool TrangThai = false;
        //BẢNG ĐĂNG NHẬP
        DangNhap_B cls_DangNhap = new DangNhap_B();
        public DoiMatKhau(DangNhap_ThongTin DN)
        {
            InitializeComponent();
            this.TaiKhoan = DN.TaiKhoan;
            this.MatKhau = DN.MatKhau;
            this.Quyen = DN.Quyen;
            this.TrangThai = DN.TrangThai;
            txtMatKhauCu.Focus();
        }
        //KHI KÍCH THỰC HIỆN.
        private void XuLyThayDoiMatKhau()
        {
            if (txtMatKhauCu.Text.Equals(""))
            {
                MessageBox.Show("Bạn hãy nhập vào mật khẩu cũ!", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Focus();
            }
            else
            {
                if (txtMatKhauMoi.Text.Equals(""))
                {
                    MessageBox.Show("Bạn hãy nhập vào mật khẩu mới!", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauMoi.Focus();
                }
                else
                {
                    if (txtNhapLaiMatKhauMoi.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn hãy xác nhận lại mật khẩu mới!", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNhapLaiMatKhauMoi.Focus();
                    }
                    else
                    {
                        if (!txtMatKhauMoi.Text.Equals(txtNhapLaiMatKhauMoi.Text))
                        {
                            MessageBox.Show("Xác nhận mật khẩu không chính xác, hãy nhập lại để xác nhận lại!", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNhapLaiMatKhauMoi.Text = "";
                            txtNhapLaiMatKhauMoi.Focus();
                        }
                        else
                        {
                            DangNhap_ThongTin DN = new DangNhap_ThongTin();
                            DN.TaiKhoan = this.TaiKhoan;
                            DN.MatKhau = txtMatKhauCu.Text;
                            DataTable Bang = new DataTable();
                            DataRow Hang;
                            Bang = cls_DangNhap.KiemTraDangNhap(DN);
                            try
                            {
                                Hang = Bang.Rows[0];
                                DN.MatKhau = txtNhapLaiMatKhauMoi.Text;
                                cls_DangNhap.UpDateMatKhau(DN);
                                MessageBox.Show("Thay đổi mật khẩu thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                                this.Hide();
                            }
                            catch
                            {
                                MessageBox.Show("Mật khẩu của bạn bị sai, hãy kiểm tra lại!", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMatKhauCu.Text = "";
                                txtMatKhauCu.Focus();
                            }
                        }
                    }
                }
            }
        }
        private void btThucHien_Click(object sender, EventArgs e)
        {
            XuLyThayDoiMatKhau();
        }

        private void KhiAnOMatKhauCu(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                XuLyThayDoiMatKhau();
            }
        }

        private void KhiAnOMatKhauMoi(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                XuLyThayDoiMatKhau();
            }
        }

        private void KhiAnONhapLai(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                XuLyThayDoiMatKhau();
            }
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
