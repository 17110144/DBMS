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
    public class NganhDaoTao_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();
        public DataTable DanhSachNganhDaoTao()
        {
            return cls.LayDuLieu("DanhSachNganhDaoTao");
        }
        public DataTable viewDanhSachTenNganhDaoTao()
        {
            return cls.LayDuLieuTuView("viewDanhSachTenNganhDaoTao");
        }
        //TÌM KIẾM NGÀNH ĐÀO TẠO
        public DataTable TimKiemNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TenNganh";
            value[0] = NDT.TenNganh;
            return cls.TimKiem("TimKiemNganhDaoTao", name, value, Nparameter);
        }
        //LẤY RA DANH SÁCH THÔNG TIN ĐẦY ĐỦ VỀ NGÀNH ĐÀO TẠO
        public DataTable DanhSachThongTinNganhDaoTao()
        {
            return cls.LayDuLieu("DanhSachThongTinNganhDaoTao");
        }
        //XÓA 1 NGANH ĐÀO TẠO.
        public int XoaNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaNganh";
            value[0] = NDT.MaNganh;
            return cls.CapNhat("XoaNganhDaoTao", name, value, Nparameter);
        }
        //THÊM 1 HỌC KỲ.
        public int ThemNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            int Nparameter = 3;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaNganh";
            value[0] = NDT.MaNganh;
            name[1] = "@TenNganh";
            value[1] = NDT.TenNganh;
            name[2] = "@MaKhoa";
            value[2] = NDT.MaKhoa;
            return cls.CapNhat("ThemNganhDaoTao", name, value, Nparameter);
        }

        //SỬA 1 NGÀNH ĐÀO TẠO.
        public int SuaNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            int Nparameter = 3;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaNganh";
            value[0] = NDT.MaNganh;
            name[1] = "@TenNganh";
            value[1] = NDT.TenNganh;
            name[2] = "@MaKhoa";
            value[2] = NDT.MaKhoa;
            return cls.CapNhat("SuaNganhDaoTao", name, value, Nparameter);
        }

        //TÌM KIẾM NGÀNH ĐÀO TẠO ĐẦY ĐỦ.
        public DataTable TimKiemThongTinNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@TimKiem";
            value[0] = NDT.MaNganh;
            return cls.TimKiem("TimKiemThongTinNganhDaoTao", name, value, Nparameter);
        }
    }
}
