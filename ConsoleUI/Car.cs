using System;
using System.Reflection;

namespace ConsoleUI
{
	internal class Car : Vehicle
	{
        // Additional property
        public bool HasTrunk { get; set; }

        // Implementing abstract method
        public override void DriveAbstract()
        {
            Console.WriteLine($"Does {Year} {Make} {Model} has a trunk? {HasTrunk}");
        }
    }
}

