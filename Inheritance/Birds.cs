using System;
using System.Collections.Generic;
using System.Text;
using Inheritance;

namespace Inheritance
{
    internal class Birds : Animals
    {
        public bool canFly { get; set; } = true;
        public bool hasWings { get; set; } = true;
        public bool eatsPlants { get; set; } = true;
        public bool laysEggs { get; set; } = true;

        public void PrintBirdFeatures()
        {
            Console.WriteLine($"Can fly: {canFly}");
            Console.WriteLine($"Has wings: {hasWings}");
            Console.WriteLine($"Eats plants : {eatsPlants}");
            Console.WriteLine($"Lays eggs : {laysEggs}");
        }
            

           

    }
}
