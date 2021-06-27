using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings
{
    class Office : BlockHouse
    {
        public void NineToFive()
        {
            Console.WriteLine("Working 9 to 5.");
        }

        public int PlusMethod(int x, int y)
        {
            return x + y;
        }

        public double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
