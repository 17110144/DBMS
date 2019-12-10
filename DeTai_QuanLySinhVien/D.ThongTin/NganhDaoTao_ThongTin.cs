using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.ThongTin
{
    public class NganhDaoTao_ThongTin
    {
        private string _MaNganh;
        public string MaNganh
        {
            get { return _MaNganh; }
            set { _MaNganh = value; }
        }

        private string _TenNganh;
        public string TenNganh
        {
            get { return _TenNganh; }
            set { _TenNganh = value; }
        }

        private string _MaKhoa;
        public string MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }
    }
}
