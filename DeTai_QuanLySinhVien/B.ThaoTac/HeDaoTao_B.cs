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
    public class HeDaoTao_B
    {
        HeDaoTao_C cls = new HeDaoTao_C();

        public DataTable DanhSachHeDaoTao()
        {
            return cls.DanhSachHeDaoTao();
        }

        public DataTable viewDanhSachTenHeDaoTao()
        {
            return cls.viewDanhSachTenHeDaoTao();
        }

        public int XoaHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            return cls.XoaHeDaoTao(HDT);
        }

        public int ThemHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            return cls.ThemHeDaoTao(HDT);
        }

        public int SuaHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            return cls.SuaHeDaoTao(HDT);
        }

        public DataTable TimKiemHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            return cls.TimKiemHeDaoTao(HDT);
        }
    }
}
