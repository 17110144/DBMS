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
    public partial class KetQuaHocTapCuaSinhVien : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG HỌC KỲ
        HocKy_B cls_HK = new HocKy_B();
        //BẢNG ĐIỂM
        BangDiem_B cls_BD = new BangDiem_B();

        int DongChon = 0;
        string ChucNang = null;
        string Ma = null;
        public KetQuaHocTapCuaSinhVien(SinhVien_ThongTin SV)
        {
            InitializeComponent();
            //LẤY DỮ LIỆU TỪ DANH SÁCH SINH VIÊN ĐỔ VỀ Ô TEXT.
            txtMaSo.Text = SV.MaSinhVien;
            txtHoTen.Text = SV.TenSinhVien;
            txtLop.Text = SV.Lop;
            //LOAD TOÀN BỘ DỮ LIỆU LÊN COMBOBOX.
            cbHocKy.DataSource = cls_HK.DanhSachHocKy();
            cbHocKy.DisplayMember = "TenHocKy";
            cbHocKy.ValueMember = "MaHocKy";
            //LẤY RA TOÀN BỘ KẾT QUẢ HỌC TẬP CỦA SINH VIÊN.
            BangDiem_ThongTin BD = new BangDiem_ThongTin();
            BD.MaSinhVien = SV.MaSinhVien;
            tbKetQuaHocTap.DataSource = cls_BD.LayKetQuaHocTap(BD);
            tbKetQuaHocTap.AutoResizeColumns();
            //HIỂN THỊ KẾT QUẢ HỌC TẬP - ĐÀO TẠO CỦA SINH VIÊN.
            DataTable Bang = new DataTable();
            DataRow Hang;
            Bang = cls_BD.KetQuaTongKetDaoTao(BD);
            Hang = Bang.Rows[0];
            txtSoTCTichLuy.Text = Hang[0].ToString();
            txtDiemTLHe10.Text = Hang[1].ToString();
            txtDiemTLHe4.Text = Hang[2].ToString();

        }

        private void ChonKyHoc_LoadDiem(object sender, EventArgs e)
        {
            txtSoTCTichLuy.ResetText();
            txtDiemTLHe10.ResetText();
            txtDiemTLHe4.ResetText();
            BangDiem_ThongTin BD = new BangDiem_ThongTin();
            BD.MaSinhVien = txtMaSo.Text;
            BD.MaHocKy = cbHocKy.SelectedValue.ToString();
            tbKetQuaHocTap.DataSource = cls_BD.LayDiemTheoKySinhVien(BD);
            tbKetQuaHocTap.AutoResizeColumns();
            //HIỂN THỊ KẾT QUẢ
            DataTable Bang = new DataTable();
            DataRow Hang;
            Bang = cls_BD.SoTinChiDat(BD);
            Hang = Bang.Rows[0];
            txtSoTCDat.Text = Hang[0].ToString();

            DataTable Bang1 = new DataTable();
            DataRow Hang1;
            Bang1 = cls_BD.KetQuaTongKetHocKy(BD);
            Hang1 = Bang1.Rows[0];
            txtDiemTBHe10.Text = Hang1[0].ToString();
            txtDiemTBHe4.Text = Hang1[1].ToString();
        }
        //KÍCH CHỌN XEM TẤT CẢ KẾT QUẢ HỌC TẬP.
        private void btAll_Click(object sender, EventArgs e)
        {
            txtSoTCDat.ResetText();
            txtDiemTBHe10.ResetText();
            txtDiemTBHe4.ResetText();
            SinhVien_ThongTin SV = new SinhVien_ThongTin();
            //LẤY RA TOÀN BỘ KẾT QUẢ HỌC TẬP CỦA SINH VIÊN.
            BangDiem_ThongTin BD = new BangDiem_ThongTin();
            BD.MaSinhVien = txtMaSo.Text;
            tbKetQuaHocTap.DataSource = cls_BD.LayKetQuaHocTap(BD);
            tbKetQuaHocTap.AutoResizeColumns();
            //HIỂN THỊ KẾT QUẢ HỌC TẬP - ĐÀO TẠO CỦA SINH VIÊN.
            DataTable Bang = new DataTable();
            DataRow Hang;
            Bang = cls_BD.KetQuaTongKetDaoTao(BD);
            Hang = Bang.Rows[0];
            txtSoTCTichLuy.Text = Hang[0].ToString();
            txtDiemTLHe10.Text = Hang[1].ToString();
            txtDiemTLHe4.Text = Hang[2].ToString();
        }
        private void tbKetQuaHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
        }
        //KHI KÍCH ĐÚP CHUỘT VÀO BẢNG CHUYỂN ĐẾN TRANG CHỈNH SỬA ĐIỂM.
        private void KichDup_ChinhSuaDiemCuaSinhVien(object sender, MouseEventArgs e)
        {
            ChucNang = "ChinhSua";
            string MaLop = txtLop.Text;
            BangDiem_ThongTin BD = new BangDiem_ThongTin();
            BD.MaSinhVien = txtMaSo.Text;
            BD.Stt = int.Parse(tbKetQuaHocTap.Rows[DongChon].Cells[0].Value.ToString());
            BD.MaHocKy = tbKetQuaHocTap.Rows[DongChon].Cells[1].Value.ToString();
            BD.MaMonHoc = tbKetQuaHocTap.Rows[DongChon].Cells[2].Value.ToString();
            BD.DiemQuaTrinh = float.Parse(tbKetQuaHocTap.Rows[DongChon].Cells[5].Value.ToString());
            BD.DiemThi = float.Parse(tbKetQuaHocTap.Rows[DongChon].Cells[6].Value.ToString());
            A.GiaoDien.NhapDiem ND = new A.GiaoDien.NhapDiem(ChucNang, MaLop, BD);
            ND.DuLieu = new NhapDiem.DuLieuTruyenVe(LayDuLieu);
            ND.ShowDialog(this);
        }
        //LẤY DỮ LIỆU TRẢ VỀ
        public void LayDuLieu(BangDiem_ThongTin BD)
        {
            this.Ma = BD.MaSinhVien;
            if (!this.Ma.Equals(""))
            {
                tbKetQuaHocTap.DataSource = cls_BD.LayDiemTheoKySinhVien(BD);
                tbKetQuaHocTap.AutoResizeColumns();
            }
        }
    }
}
