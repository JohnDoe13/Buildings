using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings
{
    //class Pets
     class Pets
     
    {
        interface IPets
        {
            void startWalking();
        }

        public void startWalking()
        {
            Console.WriteLine("The animal is walking.");
        }
        //public virtual void animalSound()

        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes sound");
        }

        public void sleep()
        {
            Console.WriteLine("Sleeeeeeeeeping");
        }
    }
    class Lion : Pets
    
    
    {
        public override void animalSound()
        {
            //base.animalSound();
            Console.WriteLine("The lion roars");
        }

        public string fur;
        public Lion()
        {
            fur = "plenty of fur";
        }
    }       
    class Cow : Lion
    
    {
        public override void animalSound()
        
        {
            //    base.animalSound();
                Console.WriteLine("The cow says muuh");
         }
     
    }
    
    
         
         
 }
          

