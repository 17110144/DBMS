using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.ThongTin
{
    public class Lop_ThongTin
    {
        private string _MaLop;
        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }

        private string _TenLop;
        public string TenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }

        private string _MaKhoaHoc;
        public string MaKhoaHoc
        {
            get { return _MaKhoaHoc; }
            set { _MaKhoaHoc = value; }
        }

        private string _MaHeDaoTao;
        public string MaHeDaoTao
        {
            get { return _MaHeDaoTao; }
            set { _MaHeDaoTao = value; }
        }

        private string _MaNganh;
        public string MaNganh
        {
            get { return _MaNganh; }
            set { _MaNganh = value; }
        }
    }
}
