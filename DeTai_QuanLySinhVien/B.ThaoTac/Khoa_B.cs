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
    public class Khoa_B
    {
        Khoa_C cls = new Khoa_C();
        public DataTable DanhSachKhoa()
        {
            return cls.DanhSachKhoa();
        }

        public int XoaKhoa(Khoa_ThongTin K)
        {
            return cls.XoaKhoa(K);
        }

        public int ThemKhoa(Khoa_ThongTin K)
        {
            return cls.ThemKhoa(K);
        }

        public int SuaKhoa(Khoa_ThongTin K)
        {
            return cls.SuaKhoa(K);
        }

        public DataTable TimKiemKhoa(Khoa_ThongTin K)
        {
            return cls.TimKiemKhoa(K);
        }
    }
}
