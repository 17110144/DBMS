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
    public partial class QuanLySinhVien : Form
    {
        //KHAI BÁO DÙNG CHUNG.
        //BẢNG LỚP
        Lop_B cls_Lop = new Lop_B();
        //BẢNG SINH VIÊN.
        SinhVien_B cls_SinhVien = new SinhVien_B();

        bool GioiTinh;
        bool DienUuTien;
        string ChucNang = null;
        String picLoc = null;
        FileStream fstream;
        BinaryReader br;
        public QuanLySinhVien(string ChucNang, SinhVien_ThongTin SV)
        {
            InitializeComponent();
            cbLop.DataSource = cls_Lop.viewDanhSachTenLop(); 
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            this.ChucNang = ChucNang;

            //NẾU CHỌN SỬA THÔNG TIN SINH VIÊN
            if (ChucNang.Equals("F10"))
            {

                txtMaSinhVien.Enabled = false;
                ChonAnh.Enabled = false;
                txtMaSinhVien.Text = SV.MaSinhVien;
                txtTenSinhVien.Text = SV.TenSinhVien;
                txtNgaySinh.Text = SV.NgaySinh.ToString();
                if (SV.GioiTinh == true)
                {
                    raNam.Checked = true;
                }
                if (SV.GioiTinh == false)
                {
                    raNu.Checked = true;
                }
                cbLop.SelectedValue = SV.Lop;
                txtDiaChi.Text = SV.DiaChi;
                if (SV.ChinhSachUuTien == true)
                {
                    raCo.Checked = true;
                }
                if (SV.ChinhSachUuTien == false)
                {
                    raKhong.Checked = true;
                }
                try
                {
                    SqlDataReader Anh = cls_SinhVien.LayAnhSinhVien(SV);
                    Anh.Read();
                    if (Anh.HasRows)
                    {
                        SV.Anh = (byte[])(Anh[0]);
                        if (SV.Anh == null)
                        {
                            AnhSV.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(SV.Anh);
                            AnhSV.Image = Image.FromStream(ms);
                            Anh.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Sinh viên chưa có thông tin ảnh!", "Cảnh báo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            txtMaSinhVien.Focus();
            btHoanTat.Enabled = false;
        }
        //TRUYỀN DỮ LIỆU - THÊM SỬA XÓA SINH VIÊN.
        public delegate void DuLieuTruyenVe(SinhVien_ThongTin SV);
        public DuLieuTruyenVe DuLieu;
        private void SuaThongTinSinhVien()
        {
            SinhVien_ThongTin SV = new SinhVien_ThongTin();
            SV.MaSinhVien = txtMaSinhVien.Text;
            SV.TenSinhVien = txtTenSinhVien.Text;
            SV.NgaySinh = txtNgaySinh.Value;
            SV.GioiTinh = GioiTinh;
            SV.Lop = cbLop.SelectedValue.ToString();
            SV.DiaChi = txtDiaChi.Text;
            SV.ChinhSachUuTien = DienUuTien;
            try
            {
                cls_SinhVien.SuaThongTinSinhVien(SV);
                MessageBox.Show("Bạn đã sửa thành công thông tin sinh viên " + txtTenSinhVien.Text + " có mã " + SV.MaSinhVien + "", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (DuLieu != null)
                {
                    SV.MaSinhVien = txtMaSinhVien.Text;
                    DuLieu(SV);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không thể chỉnh sửa, hãy kiểm tra lại!", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }
        //
        private void btThem_Click(object sender, EventArgs e)
        {
            if (ChucNang.Equals("F9"))
            {
                btHoanTat.Enabled = true;
                try
                {
                    SinhVien_ThongTin SV = new SinhVien_ThongTin();
                    SV.MaSinhVien = txtMaSinhVien.Text;
                    SV.TenSinhVien = txtTenSinhVien.Text;
                    SV.NgaySinh = txtNgaySinh.Value;
                    SV.GioiTinh = GioiTinh;
                    SV.Anh = br.ReadBytes((int)fstream.Length);
                    SV.Lop = cbLop.SelectedValue.ToString();
                    SV.DiaChi = txtDiaChi.Text;
                    SV.ChinhSachUuTien = DienUuTien;
                    cls_SinhVien.ThemSinhVien(SV);
                    MessageBox.Show("Thêm mới thành công sinh viên " + SV.TenSinhVien + ", mã số " + SV.MaSinhVien + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (DuLieu != null)
                    {
                        SV.MaSinhVien = txtMaSinhVien.Text;
                        DuLieu(SV);
                    }
                    LoadTrang();
                }
                catch
                {
                    MessageBox.Show("Không thể thêm mới, hãy xem xét lại! Có thể bạn chưa chọn ảnh.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (ChucNang.Equals("F10"))
            {
                SuaThongTinSinhVien();
            }
        }
        //LOAD MỚI 1 TRANG
        public void LoadTrang()
        {
            txtMaSinhVien.Focus();
            txtMaSinhVien.ResetText();
            txtTenSinhVien.ResetText();
            txtNgaySinh.ResetText();
            //cbLop.ResetText();
            txtDiaChi.ResetText();
            raCo.Checked = false;
            raKhong.Checked = false;
            raNam.Checked = false;
            raNu.Checked = false;
            AnhSV.Image = null;
        }
        //CHỌN ẢNH.
        private void ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PNG Files(*.png)|*.png|JPG Files(*jpg)|*.jpg|All Files(*.*)|*.*";
            dlg.Title = "Chọn ảnh cho sinh viên.";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picLoc = dlg.FileName.ToString();
                AnhSV.ImageLocation = picLoc;
                fstream = new FileStream(picLoc, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fstream);
            }
        }
        //CÁC BIẾN CỜ.
        private void raCo_CheckedChanged(object sender, EventArgs e)
        {
            DienUuTien = true;
        }

        private void raKhong_CheckedChanged(object sender, EventArgs e)
        {
            DienUuTien = false;
        }

        private void raNam_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = true;
        }

        private void raNu_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = false;
        }
        //KHI THÊM MỚI XONG
        private void btHoanTat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EnterTenSinhVien(object sender, KeyEventArgs e)
        {
            if (ChucNang.Equals("F10"))
            {
                if (e.KeyValue.ToString() == "13")
                {
                    SuaThongTinSinhVien();
                }
            }
        }

        private void EnterDiaChi(object sender, KeyEventArgs e)
        {
            if (ChucNang.Equals("F10"))
            {
                if (e.KeyValue.ToString() == "13")
                {
                    SuaThongTinSinhVien();
                }
            }
        }
    }
}
