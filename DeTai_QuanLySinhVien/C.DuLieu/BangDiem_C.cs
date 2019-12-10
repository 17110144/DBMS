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
    public class BangDiem_C
    {
        KetNoi_CSDL cls = new KetNoi_CSDL();
        //LẤY ĐIỂM TRONG 1 HỌC KỲ CỦA SINH VIÊN.
        public DataTable LayDiemTheoKySinhVien(BangDiem_ThongTin BD)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSinhVien";    value[0] = BD.MaSinhVien;
            name[1] = "@MaHocKy";       value[1] = BD.MaHocKy;
            return cls.TimKiem("LayDiemTheoKySinhVien", name, value, Nparameter);
        }
        //THÊM KẾT QUẢ HỌC TẬP 
        public int ThemKetQua(BangDiem_ThongTin BD)
        {
            int Nparameter = 5;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSinhVien";    value[0] = BD.MaSinhVien;
            name[1] = "@MaMonHoc";      value[1] = BD.MaMonHoc;
            name[2] = "@MaHocKy";       value[2] = BD.MaHocKy;
            name[3] = "@DiemQuaTrinh";  value[3] = BD.DiemQuaTrinh;
            name[4] = "@DiemThi";       value[4] = BD.DiemThi;
            return cls.CapNhat("ThemKetQua", name, value, Nparameter);
        }
        //UPDATE ĐIỂM QUÁ TRÌNH VÀO ĐIỂM THI
        public int UpDateDiemQTVaDiemThi(BangDiem_ThongTin BD)
        {
            int Nparameter = 5;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSinhVien";    value[0] = BD.MaSinhVien;
            name[1] = "@MaMonHoc";      value[1] = BD.MaMonHoc;
            name[2] = "@MaHocKy";       value[2] = BD.MaHocKy;
            name[3] = "@DiemQuaTrinh";  value[3] = BD.DiemQuaTrinh;
            name[4] = "@DiemThi";       value[4] = BD.DiemThi;
            return cls.CapNhat("UpDateDiemQTVaDiemThi", name, value, Nparameter);
        }
        //XÓA ĐIỂM CỦA SINH VIÊN.
        public int XoaDiemCuaSinhVien(BangDiem_ThongTin BD)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@STT"; value[0] = BD.Stt;
            return cls.CapNhat("XoaDiemCuaSinhVien", name, value, Nparameter);
        }
        //LẤY TOÀN BỘ ĐIỂM - KẾT QUẢ HỌC TẬP CỦA SINH VIÊN.
        public DataTable LayKetQuaHocTap(BangDiem_ThongTin BD)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSinhVien";
            value[0] = BD.MaSinhVien;
            return cls.TimKiem("LayKetQuaHocTap", name, value, Nparameter);
        }
        //LẤY RA KẾT QUẢ HỌC TẬP ĐÀO TẠO CỦA SINH VIÊN.
        public DataTable KetQuaTongKetDaoTao(BangDiem_ThongTin BD)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSinhVien";
            value[0] = BD.MaSinhVien;
            return cls.TimKiem("KetQuaTongKetDaoTao", name, value, Nparameter);
        }
        //SỐ TÍN CHỈ ĐẠTTRONG KỲ.
        public DataTable SoTinChiDat(BangDiem_ThongTin BD)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSinhVien";    value[0] = BD.MaSinhVien;
            name[1] = "@MaHocKy";       value[1] = BD.MaHocKy;
            return cls.TimKiem("SoTinChiDat", name, value, Nparameter);
        }
        //KẾT QUẢ ĐIỂM TRUNG BÌNH HỌC KỲ - TÍNH MÔN TRƯỢT.
        public DataTable KetQuaTongKetHocKy(BangDiem_ThongTin BD)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSinhVien";    value[0] = BD.MaSinhVien;
            name[1] = "@MaHocKy";       value[1] = BD.MaHocKy;
            return cls.TimKiem("KetQuaTongKetHocKy", name, value, Nparameter);
        }
        //LẤY RA DANH SÁCH SINH VIÊN ĐỦ ĐIỀU KIỆN XÉT HỌC BỔNG
        public DataTable DanhSachSinhVienXetHocBong(BangDiem_ThongTin BD)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaHocKy";
            value[0] = BD.MaHocKy;
            return cls.TimKiem("DanhSachSinhVienXetHocBong", name, value, Nparameter);
        }
        //DANH SÁCH SINH VIÊN CỦA KHOA ĐƯỢC XÉT HỌC BỔNG
        public DataTable DanhSachSinhVienXetHocBong_Khoa(BangDiem_ThongTin BD)
        {
            int Nparameter = 2;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaHocKy";   value[0] = BD.MaHocKy;
            name[1] = "@TimKiem";   value[1] = BD.MaMonHoc;
            return cls.TimKiem("DanhSachSinhVienXetHocBong_Khoa", name, value, Nparameter);
        }
        //DANH SÁCH SINH VIÊN CỦA KHOA ĐƯỢC XÉT HỌC BỔNG - TOP
        public DataTable DanhSachSinhVienXetHocBong_Khoa_Top(BangDiem_ThongTin BD)
        {
            int Nparameter = 3;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaHocKy";   value[0] = BD.MaHocKy;
            name[1] = "@TimKiem";   value[1] = BD.MaMonHoc;
            name[2] = "@Top";       value[2] = BD.MaSinhVien;
            return cls.TimKiem("DanhSachSinhVienXetHocBong_Khoa_Top", name, value, Nparameter);
        }
    }
}
