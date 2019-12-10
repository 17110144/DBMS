using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.ThongTin
{
    public class KhoaHoc_ThongTin
    {
        private string _MaKhoaHoc;
        public string MaKhoaHoc
        {
            get { return _MaKhoaHoc; }
            set { _MaKhoaHoc = value; }
        }

        private DateTime _NgayBatDau;
        public DateTime NgayBatDau
        {
            get { return _NgayBatDau; }
            set { _NgayBatDau = value; }
        }

        private DateTime _NgayKetThuc;
        public DateTime NgayKetThuc
        {
            get { return _NgayKetThuc; }
            set { _NgayKetThuc = value; }
        }
    }
}
