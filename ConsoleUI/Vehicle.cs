﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "19XX";
        public string Make { get; set; } = "XXXX";
        public string Model { get; set; } = "XXXX";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("It drives with a wheel");
        }

         public virtual void ListTheProperties()
        {
            Console.WriteLine($"The model {Model} it´s from {Make} from the year {Year}");
        }
    }
}
