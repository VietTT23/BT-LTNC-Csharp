using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw_3
{
    class bai3
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac so chinh phuong < {0}: ", n);
            for (int i = 0; i < n; i++)
            {
                if ((int)(Math.Sqrt(i)) == Math.Sqrt(i))
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("Cac so nguyen to < {0}: ", n);
            if (n >= 0 && n <= 2)
            {
                Console.WriteLine("khong co so nguyen to nao < {0}", n);
            }
            else
            {
                for (int i = 2; i < n; i++)
                {

                }
            }
        }
    }
}
