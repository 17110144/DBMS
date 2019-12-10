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
    public class KhoaHoc_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();
        public DataTable DanhSachKhoaHoc()
        {
            return cls.LayDuLieu("DanhSachKhoaHoc");
        }
        public DataTable viewDanhSachTenKhoaHoc()
        {
            return cls.LayDuLieuTuView("viewDanhSachTenKhoaHoc");
        }
        public DataTable DanhSach_ThongTin_KhoaHoc()
        {
            return cls.LayDuLieu("DanhSach_ThongTin_KhoaHoc");
        }

        public int ThemKhoaHoc(KhoaHoc_ThongTin KH)
        {
            int Nparameter = 3;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaKhoaHoc"; value[0] = KH.MaKhoaHoc;
            name[1] = "@NgayBatDau"; value[1] = KH.NgayBatDau;
            name[2] = "@NgayKetThuc"; value[2] = KH.NgayKetThuc;
            return cls.CapNhat("ThemKhoaHoc", name, value, Nparameter);
        }

        public int ChinhSuaKhoaHoc(KhoaHoc_ThongTin KH)
        {
            int Nparameter = 3;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaKhoaHoc"; value[0] = KH.MaKhoaHoc;
            name[1] = "@NgayBatDau"; value[1] = KH.NgayBatDau;
            name[2] = "@NgayKetThuc"; value[2] = KH.NgayKetThuc;
            return cls.CapNhat("ChinhSuaKhoaHoc", name, value, Nparameter);
        }

        public int XoaKhoaHoc(KhoaHoc_ThongTin KH)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaKhoaHoc"; value[0] = KH.MaKhoaHoc;
            return cls.CapNhat("XoaKhoaHoc", name, value, Nparameter);
        }

        public DataTable TimKiemKhoaHoc(KhoaHoc_ThongTin KH)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaKhoaHoc"; value[0] = KH.MaKhoaHoc;
            return cls.TimKiem("TimKiemKhoaHoc", name, value, Nparameter);
        }
    }
}
