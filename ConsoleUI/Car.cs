using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; } = true;
        
        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} in an abstract method.");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }



    }
}
