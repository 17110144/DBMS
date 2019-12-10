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
    public class DangNhap_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();
        public DataTable KiemTraDangNhap(DangNhap_ThongTin DN)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TaiKhoan";  value[0] = DN.TaiKhoan;
            name[1] = "@MatKhau";   value[1] = DN.MatKhau;
            return cls.TimKiem("KiemTraDangNhap", name, value, Nparameter);
        }

        public int UpDateTrangThai(DangNhap_ThongTin DN)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TaiKhoan";  value[0] = DN.TaiKhoan;
            name[1] = "@TrangThai"; value[1] = DN.TrangThai;
            return cls.CapNhat("UpDateTrangThai", name, value, Nparameter);
        }

        public int UpDateMatKhau(DangNhap_ThongTin DN)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TaiKhoan";  value[0] = DN.TaiKhoan;
            name[1] = "@MatKhau";   value[1] = DN.MatKhau;
            return cls.CapNhat("UpDateMatKhau", name, value, Nparameter);
        }
        //LẤY RA DANH SÁCH CÁC TÀI KHOẢN
        public DataTable DanhSachTaiKhoan()
        {
            return cls.LayDuLieu("DanhSachTaiKhoan");
        }
        //XÓA 1 TÀI KHOẢN.
        public int XoaTaiKhoan(DangNhap_ThongTin DN)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TaiKhoan";  value[0] = DN.TaiKhoan;
            return cls.CapNhat("XoaTaiKhoan", name, value, Nparameter);
        }
        //THÊM 1 TÀI KHOẢN.
        public int ThemTaiKhoan(DangNhap_ThongTin DN)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TaiKhoan";  value[0] = DN.TaiKhoan;
            name[1] = "@Quyen";     value[1] = DN.Quyen;
            return cls.CapNhat("ThemTaiKhoan", name, value, Nparameter);
        }

        //SỬA 1 TÀI KHOẢN - CẤP QUYỀN.
        public int ChinhSuaQuyen(DangNhap_ThongTin DN)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TaiKhoan";  value[0] = DN.TaiKhoan;
            name[1] = "@Quyen";     value[1] = DN.Quyen;
            return cls.CapNhat("ChinhSuaQuyen", name, value, Nparameter);
        }

        //TÌM KIẾM TÀI KHOẢN.
        public DataTable TimKiemTaiKhoan(DangNhap_ThongTin DN)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TimKiem";   value[0] = DN.TaiKhoan;
            return cls.TimKiem("TimKiemTaiKhoan", name, value, Nparameter);
        }
        //LẤY RA QUYỀN.
        public DataTable DanhSachQuyen()
        {
            return cls.LayDuLieu("DanhSachQuyen");
        }
    }
}
