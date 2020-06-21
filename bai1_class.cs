using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw1
{
    class bai1_class
    {
        static void Main(string[] args)
        {
            TComplex sp = new TComplex();
            sp.input();
            Console.Write("sp = ");
            sp.output();
            TComplex sp1, sp2, sp3, sp4, sp5;
            sp1 = new TComplex();
            Console.Write("sp1 = ");
            sp1.output();
            sp2 = new TComplex(2, 3);
            Console.Write("sp2 = ");
            sp2.output();

            sp3 = sp1 - sp2;
            Console.Write("sp3 = sp1 - sp2 = ");
            sp3.output();
            sp4 = sp1 + sp2;
            Console.Write("sp4 = sp1 + sp2 = ");
            sp4.output();
            sp5 = sp4 * sp3;
            Console.Write("sp5 = sp4 * sp3 = ");
            sp5.output();
            
        }
    }
}
