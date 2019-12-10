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
    public class HocKy_B
    {
        HocKy_C cls = new HocKy_C();
        public DataTable DanhSachHocKy()
        {
            return cls.DanhSachHocKy();
        }

        public DataTable viewDanhSachThongTinHocKy()
        {
            return cls.DanhSachThongTinHocKy();
        }

        public int XoaHocKy(HocKy_ThongTin HK)
        {
            return cls.XoaHocKy(HK);
        }

        public int ThemHocKy(HocKy_ThongTin HK)
        {
            return cls.ThemHocKy(HK);
        }

        public int SuaHocKy(HocKy_ThongTin HK)
        {
            return cls.SuaHocKy(HK);
        }

        public DataTable TimKiemHocKy(HocKy_ThongTin HK)
        {
            return cls.TimKiemHocKy(HK);
        }
    }
}
