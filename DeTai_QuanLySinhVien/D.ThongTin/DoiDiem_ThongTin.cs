using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.ThongTin
{
    public class DoiDiem_ThongTin
    {
        private int _Stt;
        public int Stt
        {
            get { return _Stt; }
            set { _Stt = value; }
        }

        private string _DiemChu;
        public string DiemChu
        {
            get { return _DiemChu; }
            set { _DiemChu = value; }
        }

        private float _DiemSo;
        public float DiemSo
        {
            get { return _DiemSo; }
            set { _DiemSo = value; }
        }

        private string _KetLuan;
        public string KetLuan
        {
            get { return _KetLuan; }
            set { _KetLuan = value; }
        }
    }
}
