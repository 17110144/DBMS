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
    public class MonHoc_B
    {
        MonHoc_C cls = new MonHoc_C();
        public DataTable DanhSachMonHoc()
        {
            return cls.DanhSachMonHoc();
        }

        public DataTable TimKiemMonHoc(MonHoc_ThongTin MH)
        {
            return cls.TimKiemMonHoc(MH);
        }

        public DataTable DanhSachMonHocToanTruong()
        {
            return cls.DanhSachMonHocToanTruong();
        }

        public int XoaMonHoc(MonHoc_ThongTin MH)
        {
            return cls.XoaMonHoc(MH);
        }

        public int ThemMonHoc(MonHoc_ThongTin MH)
        {
            return cls.ThemMonHoc(MH);
        }

        public int SuaMonHoc(MonHoc_ThongTin MH)
        {
            return cls.SuaMonHoc(MH);
        }

        public DataTable TimMonHoc(MonHoc_ThongTin MH)
        {
            return cls.TimMonHoc(MH);
        }
    }
}
