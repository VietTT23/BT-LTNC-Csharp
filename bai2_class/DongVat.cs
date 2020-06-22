using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw2
{
    abstract class DongVat
    {
        public abstract void move();
        public abstract void food();
        public abstract void sound();
    }

    class Cho : DongVat
    {
        public override void move()
        {
            Console.WriteLine("Cho di chuyen bang 4 chan");
        }
        public override void food()
        {
            Console.WriteLine("Cho gam xuong va an com");
        }
        public override void sound()
        {
            Console.WriteLine("Gau gau gau ...");
        }
    }

    class Meo : DongVat
    {
        public override void move()
        {
            Console.WriteLine("Meo di chuyen bang 4 chan");
        }
        public override void food()
        {
            Console.WriteLine("Meo an ca");
        }
        public override void sound()
        {
            Console.WriteLine("Meow moew meow ...");
        }
    }

    class Chim : DongVat
    {
        public override void move()
        {
            Console.WriteLine("Chi di chuyen bang 2 chan va co canh de bay");
        }
        public override void food()
        {
            Console.WriteLine("Chim hoa qua, thoc, gao, cam con co");
        }
        public override void sound()
        {
            Console.WriteLine("Cuc cu cuc cu cuc cu ...");
        }
    }

    class Ga : DongVat
    {
        public override void move()
        {
            Console.WriteLine("Ga di chuyen bang 2 chan, co canh va it bay");
        }
        public override void food()
        {
            Console.WriteLine("Ga an thoc, giun, de, cam con co ...");
        }
        public override void sound()
        {
            Console.WriteLine("O o o ooo, cuc ta cuc tac ...");
        }
    }

    class Vit : DongVat
    {
        public override void move()
        {
            Console.WriteLine("Vit di chuyen bang 2 chan, co canh va biet boi");
        }
        public override void food()
        {
            Console.WriteLine("Vit an giun, de, thoc, cam uot,....");
        }
        public override void sound()
        {
            Console.WriteLine("Quac quac quac ...");
        }
    }

}
