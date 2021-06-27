using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings
{
    class BlockHouse : House
    {

        public string housetype;
        public BlockHouse()
        {
            housetype = "Mansion";
        }

        public string city;
        public BlockHouse(string nameOfCity)
        {
            city = nameOfCity;
        }
        public void InTheHouse()
        {
            Console.WriteLine("New kid on the block.");
        }

        public void PrintStuff(string stuff)
        {
            Console.WriteLine(stuff);
        }
         public void AddNumbers(int x,int y)
        {
        Console.WriteLine(x+y);
        }
    }

       
}

