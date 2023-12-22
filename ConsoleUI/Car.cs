using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = false;
        public int Doors { get; set; } = 4;

        public override void DriveAbstract()
        {
            Console.WriteLine("This is the Drive Abstract from a Car.");
        }

        public override void ListTheProperties()
        {
            base.ListTheProperties();
            if (HasTrunk)
                Console.WriteLine($"The {Model} comes with a trunk, and has {Doors} doors.");
            else
                Console.WriteLine($"The {Model} doesn´t come with a trunk, and has {Doors} doors.");
        }
    }
}
