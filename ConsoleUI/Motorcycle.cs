using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is in virtual drive.");
        }
    }
}
