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
    public class HeDaoTao_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();
        //LẤY DANH SÁCH HỆ ĐÀO TẠO
        public DataTable DanhSachHeDaoTao()
        {
            return cls.LayDuLieu("DanhSachHeDaoTao");
        }
        public DataTable viewDanhSachTenHeDaoTao()
        {
            return cls.LayDuLieuTuView("viewDanhSachTenHeDaoTao");
        }
        //XÓA 1 HỆ ĐÀO TẠO.
        public int XoaHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaHe";  value[0] = HDT.MaHe;
            return cls.CapNhat("XoaHeDaoTao", name, value, Nparameter);
        }
        //THÊM 1 HỆ ĐÀO TẠO
        public int ThemHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaHe";  value[0] = HDT.MaHe;
            name[1] = "@TenHe"; value[1] = HDT.TenHe;
            return cls.CapNhat("ThemHeDaoTao", name, value, Nparameter);
        }

        //SỬA 
        public int SuaHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaHe";  value[0] = HDT.MaHe;
            name[1] = "@TenHe"; value[1] = HDT.TenHe;
            return cls.CapNhat("SuaHeDaoTao", name, value, Nparameter);
        }

        //TÌM KIẾM HỌC KỲ.
        public DataTable TimKiemHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TimKiem"; value[0] = HDT.MaHe;
            return cls.TimKiem("TimKiemHeDaoTao", name, value, Nparameter);
        }
    }
}
