using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw_1
{
    class bai1
    {
        static void Main(string[] args)
        {
            int Day, Month, Year;
            Console.WriteLine("Nhap ngay, thang, nam:");
            Console.Write("Day : ");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month : ");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year : ");
            Year = Convert.ToInt32(Console.ReadLine());

            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
            {
                if (Day >= 1 && Day <= 31)
                    Console.WriteLine("{0}/{1}/{2} la ngay hop le", Day, Month, Year);
                else
                    Console.WriteLine("{0} ngay khong hop le", Day);
            }

            if (Month == 9 || Month == 6 || Month == 4 || Month == 11)
            {
                if (Day >= 1 && Day <= 30)
                    Console.WriteLine("{0}/{1}/{2} la ngay hop le", Day, Month, Year);
                else
                    Console.WriteLine("{0} ngay khong hop le", Day);
            }

            if (Month == 2)
            {
                if (Year % 400 == 0 || Year % 4 == 0 && Year % 100 != 0)
                {
                    if (Day >= 1 && Day <= 29)
                        Console.WriteLine("{0}/{1}/{2} la ngay hop le", Day, Month, Year);
                    else
                        Console.WriteLine("{0} ngay khong hop le", Day);
                }
                else
                {
                    if (Day >= 1 && Day <= 28)
                        Console.WriteLine("{0}/{1}/{2} la ngay hop le", Day, Month, Year);
                    else
                        Console.WriteLine("{0} ngay khong hop le", Day);
                }
            }

        }
    }
}
