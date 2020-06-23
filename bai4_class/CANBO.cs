using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai4_class
{
    class CANBO : CONNGUOI
    {
        double heSoLuong;
        int thamNien;
        public CANBO(string ht, string qq, string gt, string ptdl, int tu, double hsl, int tn)
            : base(ht, qq, gt, ptdl, tu)
        {
            heSoLuong = hsl;
            thamNien = tn;
        }
        public void input()
        {
            base.input();
            Console.Write("He So Luong: ");
            heSoLuong = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tham Nien Cong Tac: ");
            thamNien = Convert.ToInt32(Console.ReadLine());
        }
        public void output()
        {
            base.output();
            Console.WriteLine(heSoLuong);
            Console.WriteLine(thamNien);
        }
        public double tinhLuong()
        {
            double luong;
            luong = heSoLuong * 1300 + thamNien * 100;
            return luong;
        }
    }
}
