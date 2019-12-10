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
    public class MonHoc_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();
        //LẤY RA DANH SÁCH MÔN HỌC.
        public DataTable DanhSachMonHoc()
        {
            return cls.LayDuLieu("DanhSachMonHoc");
        }
        //TÌM KIẾM MÔN HỌC.
        public DataTable TimKiemMonHoc(MonHoc_ThongTin MH)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TenMonHoc";
            value[0] = MH.TenMonHoc;
            return cls.TimKiem("TimKiemMonHoc", name, value, Nparameter);
        }
        //LẤY RA DANH SÁCH MÔN HỌC TOÀN TRƯỜNG
        public DataTable DanhSachMonHocToanTruong()
        {
            return cls.LayDuLieu("DanhSachMonHocToanTruong");
        }
        //XÓA MÔN HỌC
        public int XoaMonHoc(MonHoc_ThongTin MH)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaMonHoc";
            value[0] = MH.MaMonHoc;
            return cls.CapNhat("XoaMonHoc", name, value, Nparameter);
        }
        //THÊM MÔN HỌC
        public int ThemMonHoc(MonHoc_ThongTin MH)
        {
            int Nparameter = 3;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaMonHoc";
            value[0] = MH.MaMonHoc;
            name[1] = "@TenMonHoc";
            value[1] = MH.TenMonHoc;
            name[2] = "@SoTinChi";
            value[2] = MH.SoTinChi;
            return cls.CapNhat("ThemMonHoc", name, value, Nparameter);
        }
        //SỬA MÔN HỌC
        public int SuaMonHoc(MonHoc_ThongTin MH)
        {
            int Nparameter = 3;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaMonHoc";
            value[0] = MH.MaMonHoc;
            name[1] = "@TenMonHoc";
            value[1] = MH.TenMonHoc;
            name[2] = "@SoTinChi";
            value[2] = MH.SoTinChi;
            return cls.CapNhat("SuaMonHoc", name, value, Nparameter);
        }

        //TÌM KIẾM MÔN HỌC TẤT TẦN TẬT.
        public DataTable TimMonHoc(MonHoc_ThongTin MH)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TimKiem";
            value[0] = MH.MaMonHoc;
            return cls.TimKiem("TimMonHoc", name, value, Nparameter);
        }
    }
}
