using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2001200136_PhamDangKhoa
{
    public class DSXe
    {
        string matinh;
        string tentinh;
        List<QLXe> ds = new List<QLXe>();
        public void DocFile(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            matinh = read.SelectSingleNode("/CucQuanLy/MaTinh").InnerText;
            tentinh = read.SelectSingleNode("/CucQuanLy/TenTinh").InnerText;
            XmlNodeList nodelist = read.SelectNodes("/CucQuanLy/DanhSach/Xe");
            foreach (XmlNode node in nodelist)
            {
                QLXe dsxe=null;
                string bienso = node["BienSo"].InnerText;
                string tenxe = node["TenXe"].InnerText;
                double giatri = double.Parse(node["GiaTriXe"].InnerText);
                string loaixe = node["LoaiXe"].InnerText;
                string khuvuc = node["KhuVuc"].InnerText;
                if (loaixe == "Mo to")
                {
                    dsxe = new XeMoTo(bienso, tenxe, giatri, loaixe, khuvuc);
                }
                else if(loaixe=="O to")
                    dsxe = new XeOTo(bienso, tenxe, giatri, loaixe, khuvuc);
                else
                    dsxe = new XeTai(bienso, tenxe, giatri, loaixe, khuvuc);
                ds.Add(dsxe);
            }
        }
        public void xuat()
        {
            Console.WriteLine("Ma tinh:{0}\nTen tinh:{1}", matinh, tentinh);
            Console.WriteLine("Danh sach xe la: \n");
            foreach (QLXe a in ds)
            {
                a.xuat();
            }
        }
        public double tinhThueAllXe()
        {
            double tong = 0;
            foreach (QLXe a in ds)
            {
                tong = tong + a.TongThue();
            }
            return tong;
        }
        public QLXe XeMinPhiKV()
        {
            QLXe min = ds[0];
            foreach(QLXe a in ds)
            {
                if (a.PhiKhuVuc() < min.PhiKhuVuc())
                    min = a;
            }
            return min;
        }
        public int DemXeMoto()
        {
            int dem = 0;
            foreach (QLXe a in ds)
            {
                if (a.LoaiXe == "Mo to")
                    dem++;
            }
            return dem;
        }
        public int DemXeOto()
        {
            int dem = 0;
            foreach (QLXe a in ds)
            {
                if (a.LoaiXe == "O to")
                    dem++;
            }
            return dem;
        }
        public int DemXeTai()
        {
            int dem = 0;
            foreach (QLXe a in ds)
            {
                if (a.LoaiXe == "Tai")
                    dem++;
            }
            return dem;
        }
        public void SapXep()
        {
            ds = ds.OrderBy(t => t.TenXe).ToList();
        }
    }
}
