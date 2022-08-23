using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive.");
        }
        //public override void DriveVirtual()
        //{
        //    Console.WriteLine("This car is in virtual drive.");
        //}
    }
}
