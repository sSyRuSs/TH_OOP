using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001200136_PhamDangKhoa
{
    public class XeTai:QLXe
    {
        public override double PhiKhuVuc()
        {
            if (KhuVuc == "Huyen")
                return GiaTri * 0.02;
            else if (KhuVuc == "Tinh")
                return GiaTri * 0.05;
            else
                return GiaTri * 0.1;
        }
        public override double Thue()
        {
            return GiaTri * 0.1;
        }
        public double PhiKD()
        {
            return GiaTri * 0.02;
        }
        public double PhiMT()
        {
            return GiaTri * 0.08;
        }
        public XeTai()
        {
            MaTinh = "";
            TenTinh = "";
            BienSo = "";
            TenXe = "";
            GiaTri = 0;
            LoaiXe = "";
            KhuVuc = "";
        }
        public XeTai(string bs, string tx, double gt, string lx, string kv)
        {
            this.MaTinh = "";
            this.TenTinh = "";
            this.BienSo = bs;
            this.TenXe = tx;
            this.GiaTri = gt;
            this.LoaiXe = lx;
            this.KhuVuc = kv;
        }
    }
}
