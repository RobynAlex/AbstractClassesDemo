using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} which is a {GetType().BaseType.Name} in an abstract method.");
        }


        public override void DriveVirtual()
        {
            Console.WriteLine($"I'm driving my {GetType().Name} virtually");
        }












    }
}
