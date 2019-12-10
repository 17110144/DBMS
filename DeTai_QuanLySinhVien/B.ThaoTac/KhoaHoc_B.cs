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
    public class KhoaHoc_B
    {
        KhoaHoc_C cls = new KhoaHoc_C();
        public DataTable DanhSachKhoaHoc()
        {
            return cls.DanhSachKhoaHoc();
        }
        public DataTable viewDanhSachTenKhoaHoc()
        {
            return cls.viewDanhSachTenKhoaHoc();
        }
        public DataTable DanhSach_ThongTin_KhoaHoc()
        {
            return cls.DanhSach_ThongTin_KhoaHoc();
        }

        public int ThemKhoaHoc(KhoaHoc_ThongTin KH)
        {
            return cls.ThemKhoaHoc(KH);
        }

        public int ChinhSuaKhoaHoc(KhoaHoc_ThongTin KH)
        {
            return cls.ChinhSuaKhoaHoc(KH);
        }

        public int XoaKhoaHoc(KhoaHoc_ThongTin KH)
        {
            return cls.XoaKhoaHoc(KH);
        }

        public DataTable TimKiemKhoaHoc(KhoaHoc_ThongTin KH)
        {
            return cls.TimKiemKhoaHoc(KH);
        }
    }
}
