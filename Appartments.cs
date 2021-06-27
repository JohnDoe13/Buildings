using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings
{
    class Appartments : Office
    {
        private string gender;
        public string color;
        public int rooms;
        public void InTheHood()
        {
            Console.WriteLine("Welcome to the hood.");
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
          public int Age { get; set; }
    }
}
