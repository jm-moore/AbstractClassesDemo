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
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles


            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
            List<Vehicle> vehicles = new List<Vehicle>();
            Car miata = new Car()
            {
                Year = 2012,
                Make = "Mazda",
                Model = "Miata",
                HasTrunk = true,
            };
            //miata.DriveAbstract();
            vehicles.Add(miata);

            Motorcycle rebel = new Motorcycle()
            {
                Year = 2009,
                Make = "Honda",
                Model = "Rebel",
                HasSideCar = false,
            };
            //rebel.DriveAbstract();
            vehicles.Add(rebel);

            Vehicle silverado = new Car()
            {
                Year = 2018,
                Make = "Chevrolet",
                Model = "Silverado"
            };
            //silverado.DriveVirtual();
            vehicles.Add(silverado);

            Vehicle xpro = new Motorcycle()
            {
                Year = 2015,
                Model = "X-Pro",
                Make = "Motor Pro"
            };
            //xpro.DriveVirtual();
            vehicles.Add(xpro);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine($"Make: {v.Make}  Model: {v.Model}  Year: {v.Year}");
                v.DriveAbstract();
                v.DriveVirtual();
                Console.WriteLine();
            }

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
