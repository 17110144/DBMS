using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using D.ThongTin;
using C.DuLieu;
using System.Data.SqlClient;

namespace B.ThaoTac
{
    public class SinhVien_B
    {
        SinhVien_C cls = new SinhVien_C();
        //###=========================GIAO DIỆN DANH SÁCH SINH VIÊN===================###//
        public DataTable DanhSachSinhVien()
        {
            return cls.DanhSachSinhVien();
        }

        public DataTable TimKiemSinhVien(SinhVien_ThongTin SV)
        {
            return cls.TimKiemSinhVien(SV);
        }

        public int ThemSinhVien(SinhVien_ThongTin SV)
        {
            return cls.ThemSinhVien(SV);
        }

        public int SuaThongTinSinhVien(SinhVien_ThongTin SV)
        {
            return cls.SuaThongTinSinhVien(SV);
        }

        public SqlDataReader LayAnhSinhVien(SinhVien_ThongTin SV)
        {
            return cls.LayAnhSinhVien(SV);
        }

        public int XoaSinhVien(SinhVien_ThongTin SV)
        {
            return cls.XoaSinhVien(SV);
        }
        //###=========================================================================###//
        //###=========================GIAO DIỆN QUẢN LÝ ĐIỂM==========================###//
        public DataTable DanhSachSinhVienCuaLop(SinhVien_ThongTin SV)
        {
            return cls.DanhSachSinhVienCuaLop(SV);
        }
        //###=========================================================================###//

        //###=========================GIAO DIỆN XÉT RA TRƯỜNG=========================###//
        public DataTable DanhSachSinhVienRaTruong()
        {
            return cls.DanhSachSinhVienRaTruong();
        }

        public DataTable DanhSachSinhVienRaTruongDuocNhanBang()
        {
            return cls.DanhSachSinhVienRaTruongDuocNhanBang();
        }

        public DataTable DanhSachSinhVienRaTruongKhongDuocNhanBang()
        {
            return cls.DanhSachSinhVienRaTruongKhongDuocNhanBang();
        }
        //###=========================================================================###//
    }
}
