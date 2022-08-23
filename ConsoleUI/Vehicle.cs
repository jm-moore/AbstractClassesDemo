using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2022;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This vehicle is in virtual drive.");
        }

    }

}
