using System;

namespace Buildings
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            int xx;
            int yy;
            
            
            //Här följer ett test där jag gjorde egna implementeringar som jag tänkt sen använda till Övn3.
            //Men just nu känns det som allt är ett virrvarv. Behöver mer tid på mig att bena upp alla delar. Sorry.
            // Console.WriteLine("Hello World!");
            //Just checking that I can access all classes
            //Instansiering dvs skapar nya object. Finns flera längst ner bara för att det skall bli lättare att se hur de hänger ihop.
            //Tycker att det är svårt så här i början att se hur allt hänger ihop o när man skall använda de olika delarna i OOP. Men det ger sig.
            Lion L = new Lion(); 
            BlockHouse b =new BlockHouse();
            Appartments apt = new Appartments();
            Pets myAnimal = new Pets();
            Lion myLion = new Lion();
            Pets myanimal = new Pets();
            b.Doors();
           
            Office off = new Office();
            
            //Använder mig av metoder
            off.InTheHouse();
            off.Ceiling();
            
            apt.color = "red";
            apt.rooms = 4;
            apt.InTheHood();
            apt.Floors();
            apt.NineToFive();
            apt.Walls();
            apt.PrintStuff("What the fuck?!");
            
            //Laborerat lite med metoder
            Console.WriteLine("Input first number:");
            xx = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number:");
            yy = int.Parse(Console.ReadLine());
            off.AddNumbers(xx,yy);
            Console.WriteLine($"Type of house {b.housetype}");
            //Console.WriteLine($"You live in {b.city}");
            int plus1 = off.PlusMethod(2, 3);
            double plus2 = off.PlusMethod(2.3, 4.5);
            Console.WriteLine("Int: "+plus1);
            Console.WriteLine("Double: "+plus2);
            apt.Rooms();
            Console.WriteLine($"Your appartment's color is {apt.color}");
            Console.WriteLine($"Rooms to roam around in {apt.rooms}");
            Residence Res = new Residence("Los Angeles","12345",230000);
            Console.WriteLine($"You live in {Res.city} with the zip code {Res.zipcode} and population of {Res.pop}");
            apt.Gender = "Male";
            Console.WriteLine($"Your gender is {apt.Gender}");
            apt.Gender = "Female";
            Console.WriteLine($"Your gender is {apt.Gender}");
            apt.Age = 23;
            Console.WriteLine($"Your age is {apt.Age}");

            
            Cow mycow = new Cow();
            Console.WriteLine($"The lion has {myLion.fur}");
            
            myLion.animalSound();
            mycow.animalSound();
            Console.WriteLine($"The cow has {mycow.fur}");

            Cow cow2 = new Cow();
            cow2.animalSound();
            cow2.sleep();
            cow2.startWalking();

            Pig mypig = new Pig();
            mypig.walkingSound();
             

            Rhino r = new Rhino();
            r.walkingSound();
            Console.WriteLine("Here the Rhino - walking:");
            r.walkingSound();
            
            
            
            
        }   
        

    }
}
