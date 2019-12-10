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
    public partial class NhapDiem : Form
    {
        //KHAI BÁO DÙNG CHUNG.
        //BẢNG MÔN HOC.
        MonHoc_B cls_MonHoc = new MonHoc_B();
        //BẢNG HỌC KỲ.
        HocKy_B cls_HocKy = new HocKy_B();
        //BẢNG SINH VIÊN
        SinhVien_B cls_SinhVien = new SinhVien_B();
        //BẢNG ĐIỂM
        BangDiem_B cls_BangDiem = new BangDiem_B();

        BindingSource source;

        public delegate void DuLieuTruyenVe(BangDiem_ThongTin BD);
        public DuLieuTruyenVe DuLieu;
        string ChucNang = null;
        int BangDiemSTT;
        public NhapDiem(string ChucNang, string MaLop, BangDiem_ThongTin BD)
        {
            InitializeComponent();
            this.ChucNang = ChucNang;
            try
            {
                cbHocKy.DataSource = cls_HocKy.DanhSachHocKy();
                cbHocKy.DisplayMember = "TenHocKy";
                cbHocKy.ValueMember = "MaHocKy";

                cbMonHoc.DataSource = cls_MonHoc.DanhSachMonHoc();
                cbMonHoc.DisplayMember = "TenMonHoc";
                cbMonHoc.ValueMember = "MaMonHoc";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối, bạn hãy kiểm tra lại.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ChucNang.Equals("F1"))
            {
                try
                {
                    SinhVien_ThongTin SV = new SinhVien_ThongTin();
                    SV.Lop = MaLop;
                    source = new BindingSource();
                    foreach (DataRow Hang in cls_SinhVien.DanhSachSinhVienCuaLop(SV).Rows)
                    source.Add(Hang);

                    //LẤY RA GIÁ TRỊ ĐẦU TIÊN.
                    source.MoveFirst();
                    ShowRecord();
                    XemDiemTheoKySinhVien();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối, bạn hãy kiểm tra lại.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (ChucNang.Equals("ChinhSua"))
            {
                BangDiemSTT = BD.Stt;
                txtMaSinhVien.Text = BD.MaSinhVien;
                cbHocKy.SelectedValue = BD.MaHocKy;
                cbMonHoc.SelectedValue = BD.MaMonHoc;
                txtDiemQuaTrinh.Text = BD.DiemQuaTrinh.ToString();
                txtDiemThi.Text = BD.DiemThi.ToString();
                ChinhSua = "1";
                XacNhanXoa = "1";
                btXacNhan_QLD.Enabled = false;
                btChinhSua_QLD.Text = "Lưu lại.";
                txtDiemQuaTrinh.Focus();
            }
            txtDiemQuaTrinh.Focus();
        }
        
        //LƯU MẢNG GIÁ TRỊ
        private void ShowRecord()
        {
            try
            {
                DataRow currentRow = (DataRow)source.Current;
                txtMaSinhVien.Text = currentRow["MaSinhVien"].ToString();
                txtTenSinhVien.Text = currentRow["TenSinhVien"].ToString();
            }
            catch
            {
                txtMaSinhVien.ResetText();
                txtTenSinhVien.ResetText();
                MessageBox.Show("Lớp học chưa có sinh viên nào.!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       
        //XEM ĐIỂM THEO 1 KỲ NÀO ĐÓ CỦA SINH VIÊN.
        public void XemDiemTheoKySinhVien()
        {
            try
            {
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaSinhVien = txtMaSinhVien.Text;
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                tbKetQuaHocTap.DataSource = cls_BangDiem.LayDiemTheoKySinhVien(BD);
                tbKetQuaHocTap.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối, bạn hãy kiểm tra lại.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //TÌM KIẾM MÔN HỌC.
        private void TimKiemMonHoc(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                try
                {
                    MonHoc_ThongTin MH = new MonHoc_ThongTin();
                    MH.TenMonHoc = cbMonHoc.Text;
                    cbMonHoc.DataSource = cls_MonHoc.TimKiemMonHoc(MH);
                    cbMonHoc.DisplayMember = "TenMonHoc";
                    cbMonHoc.ValueMember = "MaMonHoc";
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối, bạn hãy kiểm tra lại.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btDau_Click(object sender, EventArgs e)
        {
            try
            {
                source.MoveFirst();
                ShowRecord();
                XemDiemTheoKySinhVien();
            }
            catch{ }
        }

        private void btTruoc_Click(object sender, EventArgs e)
        {
            try
            {
                source.MovePrevious();
                ShowRecord();
                XemDiemTheoKySinhVien();
            }
            catch { }
        }

        private void btSau_Click(object sender, EventArgs e)
        {
            try
            {
                source.MoveNext();
                ShowRecord();
                XemDiemTheoKySinhVien();
            }
            catch { }
        }

        private void brCuoi_Click(object sender, EventArgs e)
        {
            try
            {
                source.MoveLast();
                ShowRecord();
                XemDiemTheoKySinhVien();
            }
            catch { }
        }

        private void ChonKyHocDeXemDiemCuaSinhVien(object sender, EventArgs e)
        {
            XemDiemTheoKySinhVien();
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            txtDiemQuaTrinh.Focus();
        }
        //THÊM KẾT QUẢ HỌC TẬP VÀO BẢNG ĐIỂM.
        public void ThemKetQuaHocTap()
        {
            try
            {
                //Thêm kết quả học tập
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaSinhVien = txtMaSinhVien.Text;
                BD.MaMonHoc = cbMonHoc.SelectedValue.ToString();
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                BD.DiemQuaTrinh = float.Parse(txtDiemQuaTrinh.Text);
                BD.DiemThi = float.Parse(txtDiemThi.Text);
                cls_BangDiem.ThemKetQua(BD);
                //Next đến người tiếp theo.
                source.MoveNext();
                ShowRecord();
                //Load lại bảng kết quả học tập.
                XemDiemTheoKySinhVien();
                //
                txtDiemQuaTrinh.ResetText();
                txtDiemThi.ResetText();
                txtDiemQuaTrinh.Focus();
            }
            catch
            {
                MessageBox.Show("Lỗi, bạn hãy kiểm tra lại. Có thể bạn chưa nhập những thông số cần thiết.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Button THÊM.
        private void btXacNhan_QLD_Click(object sender, EventArgs e)
        {
            ThemKetQuaHocTap();
        }
        //KHI ẤN ENTER.
        private void EnterDiemThi(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                if (ChinhSua.Equals("0"))
                {
                    ThemKetQuaHocTap();
                }
                else
                {
                    ChinhSuaKetQuaHocTap();
                }
            }
        }
        //KHI CHỌN CHỈNH SỬA
        //CHỈNH SỬA KẾT QUẢ HỌC TẬP
        public void ChinhSuaKetQuaHocTap()
        {
            try
            {
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaSinhVien = txtMaSinhVien.Text;
                BD.MaMonHoc = cbMonHoc.SelectedValue.ToString();
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                BD.DiemQuaTrinh = float.Parse(txtDiemQuaTrinh.Text);
                BD.DiemThi = float.Parse(txtDiemThi.Text);
                cls_BangDiem.UpDateDiemQTVaDiemThi(BD);
                XemDiemTheoKySinhVien();
                ChinhSua = "0";
                btChinhSua_QLD.Text = "Chỉnh sửa";
                txtDiemQuaTrinh.ResetText();
                txtDiemThi.ResetText();
                btXacNhan_QLD.Enabled = true;
                txtDiemQuaTrinh.Focus();
                if (ChucNang.Equals("ChinhSua"))
                {
                    if (DuLieu != null)
                    {
                        DuLieu(BD);
                    }
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối, bạn hãy kiểm tra lại.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string ChinhSua = "0";
        private void btChinhSua_QLD_Click(object sender, EventArgs e)
        {
            if (ChinhSua.Equals("0"))
            {
                ChinhSua = "1";
                btXacNhan_QLD.Enabled = false;
                btChinhSua_QLD.Text = "Lưu lại.";
                txtTenSinhVien.ResetText();
                txtMaSinhVien.ResetText();
                cbHocKy.ResetText();
                cbMonHoc.ResetText();
                txtDiemQuaTrinh.ResetText();
                txtDiemThi.ResetText();
                txtMaSinhVien.Focus();
            }
            else 
            {
                ChinhSuaKetQuaHocTap();
            }
        }
        string XacNhanXoa = "0";
        int DongChon;
        private void tbKetQuaHocTap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            ChinhSua = "1";
            XacNhanXoa = "1";
            btXacNhan_QLD.Enabled = false;
            btChinhSua_QLD.Text = "Lưu lại.";
            txtDiemQuaTrinh.Focus();
            txtDiemQuaTrinh.Text = tbKetQuaHocTap.Rows[DongChon].Cells[5].Value.ToString();
            txtDiemThi.Text = tbKetQuaHocTap.Rows[DongChon].Cells[6].Value.ToString();
            cbMonHoc.SelectedValue = tbKetQuaHocTap.Rows[DongChon].Cells[2].Value.ToString();
        }
        //XÓA KẾT QUẢ HỌC TẬP
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (XacNhanXoa.Equals("1"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        BangDiem_ThongTin BD = new BangDiem_ThongTin();
                        if (ChucNang.Equals("ChinhSua"))
                        {
                            BD.Stt = BangDiemSTT;
                            cls_BangDiem.XoaDiemCuaSinhVien(BD);
                            MessageBox.Show("Bạn đã hủy kết quả môn " + cbMonHoc.Text + " của sinh viên có mã " + txtMaSinhVien.Text + ".", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
                            if (DuLieu != null)
                            {
                                BD.MaSinhVien = txtMaSinhVien.Text;
                                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                                DuLieu(BD);
                            }
                            this.Hide();
                        }
                        else
                        {
                            BD.Stt = int.Parse(tbKetQuaHocTap.Rows[DongChon].Cells[0].Value.ToString());
                            cls_BangDiem.XoaDiemCuaSinhVien(BD);
                        }
                        XemDiemTheoKySinhVien();
                        txtDiemQuaTrinh.ResetText();
                        txtDiemThi.ResetText();
                        txtDiemQuaTrinh.Focus();
                        XacNhanXoa = "0";
                        ChinhSua = "0";
                        btChinhSua_QLD.Text = "Chỉnh sửa";
                        btXacNhan_QLD.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa, bạn hãy kiểm tra lại.", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Hãy chọn bản ghi muốn xóa.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
