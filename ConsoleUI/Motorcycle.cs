using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;
        public int Passengers { get; set; } = 1;

        public override void DriveAbstract()
        {
            Console.WriteLine("This is the Drive Abstract from a Motorcycle.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("It drives with the handles");
        }

        public override void ListTheProperties()
        {
            base.ListTheProperties();
            if (HasSideCart)
                Console.WriteLine($"The {Model} comes with a side cart, and it´s made for {Passengers} passengers.");
            else
                Console.WriteLine($"The {Model} doesn´t come with a side cart, and it´s made for {Passengers} passengers.");
        }
    }
}
