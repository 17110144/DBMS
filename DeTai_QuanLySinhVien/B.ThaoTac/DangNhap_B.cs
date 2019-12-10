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
    public class DangNhap_B
    {
        DangNhap_C cls = new DangNhap_C();
        public DataTable KiemTraDangNhap(DangNhap_ThongTin DN)
        {
            return cls.KiemTraDangNhap(DN);
        }

        public int UpDateTrangThai(DangNhap_ThongTin DN)
        {
            return cls.UpDateTrangThai(DN);
        }

        public int UpDateMatKhau(DangNhap_ThongTin DN)
        {
            return cls.UpDateMatKhau(DN);
        }

        public DataTable DanhSachTaiKhoan()
        {
            return cls.DanhSachTaiKhoan();
        }

        public int XoaTaiKhoan(DangNhap_ThongTin DN)
        {
            return cls.XoaTaiKhoan(DN);
        }

        public int ThemTaiKhoan(DangNhap_ThongTin DN)
        {
            return cls.ThemTaiKhoan(DN);
        }

        public int ChinhSuaQuyen(DangNhap_ThongTin DN)
        {
            return cls.ChinhSuaQuyen(DN);
        }

        public DataTable TimKiemTaiKhoan(DangNhap_ThongTin DN)
        {
            return cls.TimKiemTaiKhoan(DN);
        }

        public DataTable DanhSachQuyen()
        {
            return cls.DanhSachQuyen();
        }
    }
}
