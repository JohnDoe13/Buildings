using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings
{
    class House
    {
        
        public void Walls()
        {
            Console.WriteLine("A room has usually four walls.");
        }
        
        public void Windows()
        {
            Console.WriteLine("Windows to look out.");
        }

        public void Floors()
        {
            Console.WriteLine("Floors to walk on.");
        }

        public void Doors()
        {
            Console.WriteLine("At least one door.");
        }

        public void Rooms()
        {
            Console.WriteLine("One or more rooms.");
        }

        public void Ceiling()
        {
            Console.WriteLine("A ceiling in every room.");
        }
    }
}
