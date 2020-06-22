using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw2
{
    class bai2_class
    {
        static void Main(string[] args)
        {
            DongVat x;
            string y;
            Console.WriteLine("Chon con vat yeu thich ca ban <3: ");
            Console.WriteLine("1. Cho   (phim 1)");
            Console.WriteLine("2. Meo   (phim 2)");
            Console.WriteLine("3. Chim  (phim 3)");
            Console.WriteLine("4. Ga    (phim 4)");
            Console.WriteLine("5. Vit   (phim 5)");
            Console.Write("[Enter] : ");
            y = Console.ReadLine();
            switch (y)
            {
                case "1":
                    {
                        x = new Cho();
                        x.move();
                        x.food();
                        x.sound();
                        break;
                    }
                case "2":
                    {
                        x = new Meo();
                        x.move();
                        x.food();
                        x.sound();
                        break;
                    }
                case "3":
                    {
                        x = new Chim();
                        x.move();
                        x.food();
                        x.sound();
                        break;
                    }
                case "4":
                    {
                        x = new Ga();
                        x.move();
                        x.food();
                        x.sound();
                        break;
                    }
                case "5":
                    {
                        x = new Vit();
                        x.move();
                        x.food();
                        x.sound();
                        break;
                    }
            }

        }
    }
}
