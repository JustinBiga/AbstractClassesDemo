using System;
namespace ConsoleUI
{
	internal abstract class Vehicle
	{
        // Properties
        public int Year { get; set; } = 2022;
        public string Make { get; set; } = "generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving a Vehicle from a virtual Method.");
        }

    }
}

