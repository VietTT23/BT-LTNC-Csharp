using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw_2
{
    class bai2
    {
        static void Main(string[] args)
        {
            //menu cac phep toan
            Console.WriteLine("\t**Calculator**");
            Console.WriteLine("(+): phep cong");
            Console.WriteLine("(-): phep tru");
            Console.WriteLine("(*): phep nhan");
            Console.WriteLine("(/): phep chia");
            Console.WriteLine("[Start]");

            int a, b;       //bien luu 2 so nguyen
            String oprt, x;    //bien luu toan tu

            do
            {
                Console.WriteLine("nhap 2 so va toan tu:");
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("operator: ");
                oprt = Console.ReadLine();
                switch (oprt)
                {
                    case "+":
                        {
                            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine("{0} / {1} = {2} (modulo = {3})", a, b, a / b, a%b);
                            break;
                        }
                }
                Console.WriteLine("Continue??? y/n ([y]: yes/ [n]: no)");
                x = Console.ReadLine();
            }
            while (x == "y");
            Console.WriteLine("[End]");
        }
    }
}
