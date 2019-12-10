using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.ThongTin
{
    public class SinhVien_ThongTin
    {
        private string _MaSinhVien;
        public string MaSinhVien
        {
            get { return _MaSinhVien; }
            set { _MaSinhVien = value; }
        }

        private string _TenSinhVien;
        public string TenSinhVien
        {
            get { return _TenSinhVien; }
            set { _TenSinhVien = value; }
        }

        private DateTime _NgaySinh;
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        private bool _GioiTinh;
        public bool GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        private byte[] _Anh;
        public byte[] Anh
        {
            get { return _Anh; }
            set { _Anh = value; }
        }

        private string _Lop;
        public string Lop
        {
            get { return _Lop; }
            set { _Lop = value; }
        }

        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private bool _ChinhSachUuTien;
        public bool ChinhSachUuTien
        {
            get { return _ChinhSachUuTien; }
            set { _ChinhSachUuTien = value; }
        }
    }
}
