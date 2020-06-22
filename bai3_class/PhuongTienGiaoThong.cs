using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw3
{
    abstract class PhuongTienGiaoThong
    {
        public abstract void move();
    }

    class OTO : PhuongTienGiaoThong
    {
        public override void move()
        {
            Console.WriteLine("Oto di chuyen bang 4 banh");
        }
    }

    class XEMAY : PhuongTienGiaoThong
    {
        public override void move()
        {
            Console.WriteLine("Xe may di chuyen bang 2 banh va su dung dong co");
        }
    }

    class TAUTHUY : PhuongTienGiaoThong
    {
        public override void move()
        {
            Console.WriteLine("Tau thuy di chuyen bang chan vit vs su dung dong co");
        }
    }

    class MAYBAY : PhuongTienGiaoThong
    {
        public override void move()
        {
            Console.WriteLine("May bay di chuyen bang canh quat va su dung dong co");
        }
    }
}
