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
    public partial class RaTruong_DSSV : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG SINH VIÊN
        SinhVien_B cls_SinhVien = new SinhVien_B();
        
        public RaTruong_DSSV()
        {
            InitializeComponent();
            //LOAD TOÀN BỘ DANH SÁCH SINH VIÊN RA TRƯỜNG TRONG NĂM.
            try
            {
                tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruong();
            }
            catch { }
        }

        private void btDSSV_RaTruong_Click(object sender, EventArgs e)
        {
            //LOAD TOÀN BỘ DANH SÁCH SINH VIÊN RA TRƯỜNG TRONG NĂM.
            try
            {
                tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruong();
            }
            catch { }

        }

        private void btDSSV_NhanBang_Click(object sender, EventArgs e)
        {
            //LOAD TOÀN BỘ DANH SÁCH SINH VIÊN RA TRƯỜNG ĐƯỢC NHẬN BẰNG.
            try
            {
                tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruongDuocNhanBang();
            }
            catch { }

        }

        private void btDSSV_KhongNhanBang_Click(object sender, EventArgs e)
        {
            //LOAD TOÀN BỘ DANH SÁCH SINH VIÊN RA TRƯỜNG KHÔNG ĐƯỢC NHẬN BẰNG.
            try
            {
                tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruongKhongDuocNhanBang();
            }
            catch { }
        }
    }
}
