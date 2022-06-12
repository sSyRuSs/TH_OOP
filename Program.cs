using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001200136_PhamDangKhoa
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine("---------------MENU---------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1.Nhap xuat 1 loai xe");
            Console.WriteLine("2.Xuat thong tin cac loai xe co trong file");
            Console.WriteLine("3.Thong ke so luong tung nhom xe");
            Console.WriteLine("4.Tinh tong thue truoc ba cua tat ca cac xe");
            Console.WriteLine("5.Tim va xuat thonng tin xe co phi khu vuc nho nhat");
            Console.WriteLine("6.Sap xep xe theo ten, neu trung sap xep theo gia tri");
            
            Console.WriteLine("0.Thoat chuong trinh");
            Console.WriteLine("----------------------------------");
        }
        static void process()
        {
            int chon;
            XeMoTo a = new XeMoTo();
            DSXe dsxe = new DSXe();
            do
            {
                menu();
                Console.WriteLine("Chon so de thuc thi: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        a.nhap();
                        a.xuat();
                        break;
                    case 2:
                        dsxe.DocFile("Xe.xml");
                        dsxe.xuat();
                        break;
                    case 3:
                        Console.WriteLine("Co: {0} xe MoTo\t {1} xe Oto\t{2} xe Tai", dsxe.DemXeMoto(), dsxe.DemXeOto(), dsxe.DemXeTai());
                        break;
                    case 4:
                        Console.WriteLine("Tong thue truoc ba cua tat ca cac xe la: {0}", dsxe.tinhThueAllXe());
                        break;
                    case 5:
                        Console.WriteLine("Xe co phi khu vuc nho nhat la:\n {0}", dsxe.XeMinPhiKV().ToString());
                        break;
                    case 6:
                        dsxe.SapXep();
                        dsxe.xuat();
                        break;
                }

            } while (chon != 0);

        }
        static void Main(string[] args)
        {
            process();
            Console.ReadLine();
        }
    }
}
