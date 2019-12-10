using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.ThongTin
{
    public class HocKy_ThongTin
    {
        private string _MaHocKy;
        public string MaHocKy
        {
            get { return _MaHocKy; }
            set { _MaHocKy = value; }
        }

        private string _TenHocKy;
        public string TenHocKy
        {
            get { return _TenHocKy; }
            set { _TenHocKy = value; }
        }
    }
}
