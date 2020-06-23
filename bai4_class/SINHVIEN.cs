using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai4_class
{
    class SINHVIEN : CONNGUOI
    {
        double diemToan, diemVan, diemAnh;
        public SINHVIEN(string ht, string qq, string gt, string ptdl, int tu, int dT, int dV, int dA)
            : base(ht, qq, gt, ptdl, tu)
        {
            diemToan = dT;
            diemVan = dV;
            diemAnh = dA;
        }
        public double diemTB()
        {
            double dTB;
            dTB = (diemToan + diemVan + diemAnh) / 3;
            return dTB;
        }
        public void input()
        {
            base.input();
            Console.Write("Diem Toan:   ");
            diemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem van:    ");
            diemVan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem Anh:    ");
            diemAnh = Convert.ToDouble(Console.ReadLine());
        }
        public void output()
        {
            base.output();
            Console.Write("Diem Trung Binh: ");
            Console.WriteLine(diemTB());
        }
    }
}
