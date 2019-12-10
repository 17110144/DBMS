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
    public class Lop_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();
        //DANH SÁCH LỚP HỌC.
        public DataTable DanhSachLop()
        {
            return cls.LayDuLieu("DanhSachLop");
        }
        public DataTable viewDanhSachTenLop()
        {
            return cls.LayDuLieuTuView("viewDanhSachTenLop");
        }
        public DataTable DanhSach_ThongTin_Lop()
        {
            return cls.LayDuLieu("DanhSach_ThongTin_Lop");
        }
 
        //THÊM LỚP HỌC MỚI.
        public int ThemLopHocMoi(Lop_ThongTin Lop)
        {
            int Nparameter = 5;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaLop";         value[0] = Lop.MaLop;
            name[1] = "@TenLop";        value[1] = Lop.TenLop;
            name[2] = "@MaKhoaHoc";     value[2] = Lop.MaKhoaHoc;
            name[3] = "@MaHeDaoTao";    value[3] = Lop.MaHeDaoTao;
            name[4] = "@MaNganh";       value[4] = Lop.MaNganh;
            return cls.CapNhat("ThemLopHocMoi", name, value, Nparameter);
        }
        //SỬA THÔNG TIN LỚP HỌC
        public int SuaThongTinLopHoc(Lop_ThongTin Lop)
        {
            int Nparameter = 5;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaLop"; value[0] = Lop.MaLop;
            name[1] = "@TenLop"; value[1] = Lop.TenLop;
            name[2] = "@MaKhoaHoc"; value[2] = Lop.MaKhoaHoc;
            name[3] = "@MaHeDaoTao"; value[3] = Lop.MaHeDaoTao;
            name[4] = "@MaNganh"; value[4] = Lop.MaNganh;
            return cls.CapNhat("SuaThongTinLopHoc", name, value, Nparameter);
        }
        //XÓA LỚP HỌC
        public int XoaLopHoc(Lop_ThongTin Lop)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaLop"; value[0] = Lop.MaLop;
            return cls.CapNhat("XoaLopHoc", name, value, Nparameter);
        }
        //TÌM KIẾM LỚP HỌC
        public DataTable TimKiemLopHoc(Lop_ThongTin Lop)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TimKiem"; value[0] = Lop.MaLop;
            return cls.TimKiem("TimKiemLopHoc", name, value, Nparameter);
        }
    }
}
