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
    public class HocKy_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();
        public DataTable DanhSachHocKy()
        {
            return cls.LayDuLieu("DanhSachHocKy");
        }
        //LẤY RA DANH SÁCH THÔNG TIN ĐẦY ĐỦ VỀ HỌC KỲ
        public DataTable DanhSachThongTinHocKy()
        {
            return cls.LayDuLieu("DanhSachThongTinHocKy");
        }
        //XÓA 1 HỌC KỲ.
        public int XoaHocKy(HocKy_ThongTin HK)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaHocKy";
            value[0] = HK.MaHocKy;
            return cls.CapNhat("XoaHocKy", name, value, Nparameter);
        }
        //THÊM 1 HỌC KỲ.
        public int ThemHocKy(HocKy_ThongTin HK)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaHocKy";
            value[0] = HK.MaHocKy;
            name[1] = "@TenHocKy";
            value[1] = HK.TenHocKy;
            return cls.CapNhat("ThemHocKy", name, value, Nparameter);
        }

        //SỬA 1 HỌC KỲ.
        public int SuaHocKy(HocKy_ThongTin HK)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaHocKy";
            value[0] = HK.MaHocKy;
            name[1] = "@TenHocKy";
            value[1] = HK.TenHocKy;
            return cls.CapNhat("SuaHocKy", name, value, Nparameter);
        }

        //TÌM KIẾM HỌC KỲ.
        public DataTable TimKiemHocKy(HocKy_ThongTin HK)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TimKiem";
            value[0] = HK.MaHocKy;
            return cls.TimKiem("TimKiemHocKy", name, value, Nparameter);
        }
    }
}
