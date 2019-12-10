using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.ThongTin
{
    public class MonHoc_ThongTin
    {
        private string _MaMonHoc;
        public string MaMonHoc
        {
            get { return _MaMonHoc; }
            set { _MaMonHoc = value; }
        }

        private string _TenMonHoc;
        public string TenMonHoc
        {
            get { return _TenMonHoc; }
            set { _TenMonHoc = value; }
        }

        private int _SoTinChi;
        public int SoTinChi
        {
            get { return _SoTinChi; }
            set { _SoTinChi = value; }
        }
    }
}
