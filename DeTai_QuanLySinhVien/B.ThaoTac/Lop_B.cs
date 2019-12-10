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
    public class Lop_B
    {
        Lop_C cls = new Lop_C();
        //LÂY RA DANH SÁCH LƠP HỌC.
        public DataTable DanhSachLop()
        {
            return cls.DanhSachLop();
        }
        //LẤY DỮ LIỆU TÊN LỚP TỪ VIEW
        public DataTable viewDanhSachTenLop()
        {
            return cls.viewDanhSachTenLop();
        }
        //DANH SÁCH THÔNG TIN ĐẦY ĐỦ LỚP HỌC.
        public DataTable DanhSach_ThongTin_Lop()
        {
            return cls.DanhSach_ThongTin_Lop();
        }
        //THÊM LỚP HỌC MỚI
        public int ThemLopHocMoi(Lop_ThongTin Lop)
        {
            return cls.ThemLopHocMoi(Lop);
        }
        //SỬA THÔNG TIN LỚP HỌC
        public int SuaThongTinLopHoc(Lop_ThongTin Lop)
        {
            return cls.SuaThongTinLopHoc(Lop);
        }

        //XÓA LỚP HỌC
        public int XoaLopHoc(Lop_ThongTin Lop)
        {
            return cls.XoaLopHoc(Lop);
        }

        //TÌM KIẾM LỚP HỌC
        public DataTable TimKiemLopHoc(Lop_ThongTin Lop)
        {
            return cls.TimKiemLopHoc(Lop);
        }
    }
}