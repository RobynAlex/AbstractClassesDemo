using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "0";
        public string Make { get; set; } = "Generic";
        public string Model { get; set; } = "Gen";


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I'm driving virtually");
        }




       





    }
}
