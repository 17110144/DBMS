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
    public class NganhDaoTao_B
    {
        NganhDaoTao_C cls = new NganhDaoTao_C();
        public DataTable DanhSachNganhDaoTao()
        {
            return cls.DanhSachNganhDaoTao();
        }
        public DataTable viewDanhSachTenNganhDaoTao()
        {
            return cls.viewDanhSachTenNganhDaoTao();
        }
        public DataTable TimKiemNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            return cls.TimKiemNganhDaoTao(NDT);
        }

        public DataTable DanhSachThongTinNganhDaoTao()
        {
            return cls.DanhSachThongTinNganhDaoTao();
        }

        public int XoaNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            return cls.XoaNganhDaoTao(NDT);
        }

        public int ThemNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            return cls.ThemNganhDaoTao(NDT);
        }

        public int SuaNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            return cls.SuaNganhDaoTao(NDT);
        }

        public DataTable TimKiemThongTinNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            return cls.TimKiemThongTinNganhDaoTao(NDT);
        }
    }
}
