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
    public class Khoa_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();
        //LẤY DANH SÁCH KHOA
        public DataTable DanhSachKhoa()
        {
            return cls.LayDuLieu("DanhSachKhoa");
        }
        //XÓA 1 KHOA.
        public int XoaKhoa(Khoa_ThongTin K)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaKhoa";
            value[0] = K.MaKhoa;
            return cls.CapNhat("XoaKhoa", name, value, Nparameter);
        }
        //THÊM 1 KHOA
        public int ThemKhoa(Khoa_ThongTin K)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaKhoa";
            value[0] = K.MaKhoa;
            name[1] = "@TenKhoa";
            value[1] = K.TenKhoa;
            return cls.CapNhat("ThemKhoa", name, value, Nparameter);
        }

        //SỬA 1 KHOA.
        public int SuaKhoa(Khoa_ThongTin K)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaKhoa";
            value[0] = K.MaKhoa;
            name[1] = "@TenKhoa";
            value[1] = K.TenKhoa;
            return cls.CapNhat("SuaKhoa", name, value, Nparameter);
        }

        //TÌM KIẾM HỌC KỲ.
        public DataTable TimKiemKhoa(Khoa_ThongTin K)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TimKiem";
            value[0] = K.MaKhoa;
            return cls.TimKiem("TimKiemKhoa", name, value, Nparameter);
        }
    }
}
