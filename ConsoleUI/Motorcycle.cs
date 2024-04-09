using System;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        // Additional property
        public bool HasSideCart { get; set; }


        // Implementing abstract method and overriding virtual method
        public override void DriveAbstract()
        {
            Console.WriteLine($"Driving a Vehicle from a abstract Method ");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"Does {Year} {Make} {Model} has a side cart? {HasSideCart}");
        }
    }
}
