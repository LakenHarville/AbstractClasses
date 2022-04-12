using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           

            #region Vehicles

         



            
            var vehicles = new List<Vehicle>();
         
           
            var camry = new Car() { HasTrunk = true, Make = "Toyota", Year = 2014 };
            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "Kawasaki", Model = "Ninja", Year = 2005 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Chevy", Model = "Malibu", Year = 2010 };
            Vehicle coupe = new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = 2008 };

            vehicles.Add(camry);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(coupe);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make: {veh.Make}. Model: {veh.Model}. Year: {veh.Year}.");
                veh.DriveAbstract();
                Console.WriteLine();
            }
            



            #endregion            
            Console.ReadLine();
        }
    }
}
