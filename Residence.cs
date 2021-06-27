using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings
{
    //First inheriting from House
    class Residence : Appartments
    {
        //local variables to be used inside the constructor.
        public string city;
        public string zipcode;
        public int pop;
        
        //Constructor with parameters 
        //Must have the same name as the class name
        public Residence(string nameOfCity,string ZipCode,int Population)
        {
            city = nameOfCity;
            zipcode = ZipCode;
            pop = Population;
        }

    }
}
