using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class SinhVien_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();

        //###=========================GIAO DIỆN DANH SÁCH SINH VIÊN===================###//
        //LẤY RA DANH SÁCH SINH VIEN.
        public DataTable DanhSachSinhVien()
        {
            return cls.LayDuLieu("DanhSachSinhVien");
        }
        //TÌM KIẾM SINH VIÊN.
        public DataTable TimKiemSinhVien(SinhVien_ThongTin SV)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TimKiem";
            value[0] = SV.MaSinhVien;
            return cls.TimKiem("TimKiemSinhVien", name, value, Nparameter);
        }
        //THÊM SINH VIÊN MỚI.
        public int ThemSinhVien(SinhVien_ThongTin SV)
        {
            int Nparameter = 8;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSinhVien";        value[0] = SV.MaSinhVien;
            name[1] = "@TenSinhVien";       value[1] = SV.TenSinhVien;
            name[2] = "@NgaySinh";          value[2] = SV.NgaySinh;
            name[3] = "@GioiTinh";          value[3] = SV.GioiTinh;
            name[4] = "@Lop";               value[4] = SV.Lop;
            name[5] = "@DiaChi";            value[5] = SV.DiaChi;
            name[6] = "@ChinhSachUuTien";   value[6] = SV.ChinhSachUuTien;
            name[7] = "@Anh";               value[7] = SV.Anh;
            return cls.CapNhat("ThemSinhVien", name, value, Nparameter);
        }
        //CHỈNH SỬA THÔNG TIN SINH VIÊN.
        public int SuaThongTinSinhVien(SinhVien_ThongTin SV)
        {
            int Nparameter = 7;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSinhVien"; value[0] = SV.MaSinhVien;
            name[1] = "@TenSinhVien"; value[1] = SV.TenSinhVien;
            name[2] = "@NgaySinh"; value[2] = SV.NgaySinh;
            name[3] = "@GioiTinh"; value[3] = SV.GioiTinh;
            name[4] = "@Lop"; value[4] = SV.Lop;
            name[5] = "@DiaChi"; value[5] = SV.DiaChi;
            name[6] = "@ChinhSachUuTien"; value[6] = SV.ChinhSachUuTien;
            return cls.CapNhat("SuaThongTinSinhVien", name, value, Nparameter);
        }
        //LẤY RA ẢNH THEO MÃ SINH VIÊN HIỂN THỊ.
        public SqlDataReader LayAnhSinhVien(SinhVien_ThongTin SV)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TimKiem";
            value[0] = SV.MaSinhVien;
            return cls.LayAnh("LayAnhSinhVien", name, value, Nparameter);
        }
        //XÓA THÔNG TIN SINH VIÊN.
        public int XoaSinhVien(SinhVien_ThongTin SV)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@Xoa";
            value[0] = SV.MaSinhVien;
            return cls.CapNhat("XoaSinhVien", name, value, Nparameter);
        }
        //###=========================================================================###//
        //###=========================GIAO DIỆN QUẢN LÝ ĐIỂM==========================###//
        public DataTable DanhSachSinhVienCuaLop(SinhVien_ThongTin SV)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaLop";
            value[0] = SV.Lop;
            return cls.TimKiem("DanhSachSinhVienCuaLop", name, value, Nparameter);
        }
        //###=========================================================================###//

        //###=========================GIAO DIỆN XÉT RA TRƯỜNG=========================###//
        //DANH SÁCH SINH VIÊN RA TRƯỜNG TRONG NĂM NAY
        public DataTable DanhSachSinhVienRaTruong()
        {
            return cls.LayDuLieu("DanhSachSinhVienRaTruong");
        }

        public DataTable DanhSachSinhVienRaTruongDuocNhanBang()
        {
            return cls.LayDuLieu("DanhSachSinhVienRaTruongDuocNhanBang");
        }

        public DataTable DanhSachSinhVienRaTruongKhongDuocNhanBang()
        {
            return cls.LayDuLieu("DanhSachSinhVienRaTruongKhongDuocNhanBang");
        }
        //###=========================================================================###//
    }
}
