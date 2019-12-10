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
using System.Configuration;

namespace A.GiaoDien
{
    public partial class DangNhapCoSoDuLieu : Form
    {
        public DangNhapCoSoDuLieu()
        {
            InitializeComponent();
        }

        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenServer.Text == "" || cbHinhThuc.Text == "")
                {
                    MessageBox.Show("Thông tin bạn cung cấp chưa đủ, hãy kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    if (cbHinhThuc.Text.Equals("Sử Dụng Tài Khoản"))
                    {
                        if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
                        {
                            MessageBox.Show("Thông tin bạn cung cấp chưa đủ, hãy kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            _config.AppSettings.Settings["Server"].Value = txtTenServer.Text;
                            _config.AppSettings.Settings["Username"].Value = txtTaiKhoan.Text;
                            _config.AppSettings.Settings["Password"].Value = txtMatKhau.Text;
                            _config.AppSettings.Settings["LuaChon"].Value = cbHinhThuc.SelectedItem.ToString();
                        }
                    }
                    if (cbHinhThuc.Text.Equals("Không Dùng Tài Khoản"))
                    {
                        _config.AppSettings.Settings["Server"].Value = txtTenServer.Text;
                        _config.AppSettings.Settings["LuaChon"].Value = cbHinhThuc.SelectedItem.ToString();
                        _config.AppSettings.Settings["Username"].Value = "";
                        _config.AppSettings.Settings["Password"].Value = "";
                    }
                    _config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    DangNhap DN = new DangNhap();
                    DN.ShowDialog(this);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Thông tin bạn cung cấp bị sai, hãy kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHinhThuc.Text.Equals("Không Dùng Tài Khoản"))
            {
                txtTaiKhoan.Enabled = false;
                txtMatKhau.Enabled = false;
            }
            if (cbHinhThuc.Text.Equals("Sử Dụng Tài Khoản"))
            {
                txtTaiKhoan.Enabled = true;
                txtMatKhau.Enabled = true;
            }
        }

        private void DangNhapCoSoDuLieu_Load(object sender, EventArgs e)
        {
            cbHinhThuc.SelectedIndex = 1;
        }
    }
}
