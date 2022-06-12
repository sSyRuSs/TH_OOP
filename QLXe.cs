using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001200136_PhamDangKhoa
{
    public abstract class QLXe
    {
        string maTinh;

        public string MaTinh
        {
            get { return maTinh; }
            set { maTinh = value; }
        }
        string tenTinh;

        public string TenTinh
        {
            get { return tenTinh; }
            set { tenTinh = value; }
        }
        string bienSo;

        public string BienSo
        {
            get { return bienSo; }
            set { bienSo = value; }
        }
        string tenXe;

        public string TenXe
        {
            get { return tenXe; }
            set { tenXe = value; }
        }
        double giaTri;

        public double GiaTri
        {
            get { return giaTri; }
            set { giaTri = value; }
        }
        string loaiXe;

        public string LoaiXe
        {
            get { return loaiXe; }
            set { loaiXe = value; }
        }
        string khuVuc;
        private string bienso;
        private string tenxe;
        private double giatri;
        private string loaixe;
        private string khuvuc;

        public string KhuVuc
        {
            get { return khuVuc; }
            set { khuVuc = value; }
        }
        public abstract double PhiKhuVuc();
        public abstract double Thue();
        public double TongThue()
        {
            return PhiKhuVuc() + Thue();
        }
        public QLXe()
        {
            MaTinh = "";
            TenTinh = "";
            BienSo = "";
            TenXe = "";
            GiaTri = 0;
            LoaiXe = "";
            KhuVuc = "";
        }
        public QLXe(string bs, string tx, double gt, string lx, string kv)
        {
            this.MaTinh = "";
            this.TenTinh = "";
            this.BienSo = bs;
            this.TenXe = tx;
            this.GiaTri = gt;
            this.LoaiXe = lx;
            this.KhuVuc = kv;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap ma cua tinh: ");
            MaTinh = Console.ReadLine();
            Console.WriteLine("Nhap ten cua tinh: ");
            TenTinh = Console.ReadLine();
            Console.WriteLine("Nhap bien so: ");
            BienSo = Console.ReadLine();
            Console.WriteLine("Nhap ten xe: ");
            TenXe = Console.ReadLine();
            Console.WriteLine("Nhap gia tri: ");
            GiaTri= double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap loai xe: ");
            LoaiXe = Console.ReadLine();
            Console.WriteLine("Nhap khu vuc: ");
            KhuVuc = Console.ReadLine();
        }
        public virtual void  xuat()
        {
            Console.WriteLine("Bien so: {0}\nTen xe: {1}\nGia tri:{2}\nLoai xe:{3}\nKhu vuc: {4}\nTong thue truoc ba: {5}\n\n\n", BienSo, TenXe, GiaTri, LoaiXe, KhuVuc,TongThue());
        }
        public override string ToString()
        {
            string str = string.Format("{0}\t{1}\t{2}\t{3}\t{4}", BienSo, TenXe, GiaTri, LoaiXe, KhuVuc);
            return str;
        }
    }
}
