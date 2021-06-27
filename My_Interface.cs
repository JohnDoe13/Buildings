using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings
{
    
        interface IPets
        {
            void walkingSound();
            void screaming();
            
        }
    class Pig : IPets
    {
        public void walkingSound()
        {
            Console.WriteLine("Here me walking");
        }
        public void screaming()
        {
            Console.WriteLine("I am screaming big time!");
        }

    }
    class Rhino : Pig { }
   
    
}
