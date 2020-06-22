using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw3
{
    class bai3_class
    {
        static void Main(string[] args)
        {
            PhuongTienGiaoThong x;
            string y;
            Console.WriteLine("Ban muon di chuyen bang phuong tien nap?");
            Console.WriteLine("1. OTO       (phím 1)");
            Console.WriteLine("2. XEMAY     (phím 2)");
            Console.WriteLine("3. TAUTHUY   (phím 3)");
            Console.WriteLine("4. MAYBAY    (phím 4)");
            Console.Write("[Enter] : ");
            y = Console.ReadLine();
            switch (y)
            {
                case "1":
                    {
                        x = new OTO();
                        x.move();
                        break;
                    }
                case "2":
                    {
                        x = new XEMAY();
                        x.move();
                        break;
                    }
                case "3":
                    {
                        x = new TAUTHUY();
                        x.move();
                        break;
                    }
                case "4":
                    {
                        x = new MAYBAY();
                        x.move();
                        break;
                    }
            }
        }
    }
}
