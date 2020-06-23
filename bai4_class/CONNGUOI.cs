using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai4_class
{
    class CONNGUOI
    {
        protected string hoTen, queQuan, gioiTinh, ptDiLai;
        protected int tuoi;
        public CONNGUOI() { }
        public CONNGUOI(string ht, string qq, string gt, string ptdl, int tu)
        {
            hoTen = ht;
            queQuan = qq;
            gioiTinh = gt;
            ptDiLai = ptdl;
            tuoi = tu;
        }
        public void input()
        {
            Console.Write("Ho Ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Que Quan: ");
            queQuan = Console.ReadLine();
            Console.Write("Gioi Tinh: ");
            gioiTinh = Console.ReadLine();
            Console.Write("Phuong Tien Di Lai: ");
            ptDiLai = Console.ReadLine();
            Console.Write("Tuoi: ");
            tuoi = Convert.ToInt32(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine(hoTen);
            Console.WriteLine(queQuan);
            Console.WriteLine(gioiTinh);
            Console.WriteLine(ptDiLai);
            Console.WriteLine(tuoi);
        }
    }
}
