using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw1
{
    class TComplex
    {
        int thuc, ao;

        public TComplex()
        {
            thuc = 1;
            ao = 2;
        }

        public TComplex(int t, int a) 
        {
            thuc = t;
            ao = a;
        }

        public void input()
        {
            Console.WriteLine("Nhap so phuc: ");
            Console.Write("thuc = ");
            thuc = Convert.ToInt32(Console.ReadLine());
            Console.Write("ao = ");
            ao = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("{0} + {1}i", thuc, ao);
        }

        public static TComplex operator +(TComplex a, TComplex b)
        {
            TComplex c = new TComplex();
            c.thuc = a.thuc + b.thuc;
            c.ao = a.ao + b.ao;
            return c;
        }
        public static TComplex operator -(TComplex a, TComplex b)
        {
            TComplex c = new TComplex();
            c.thuc = a.thuc - b.thuc;
            c.ao = a.ao - b.ao;
            return c;
        }
        public static TComplex operator *(TComplex a, TComplex b)
        {
            TComplex c = new TComplex();
            c.thuc = a.thuc * b.thuc - a.ao * b.ao;
            c.ao = a.ao*b.thuc + a.thuc*b.ao;
            return c;
        }

    }
}
