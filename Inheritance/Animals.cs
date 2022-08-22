using System;
using System.Collections.Generic;
using System.Text;
using Inheritance;

namespace Inheritance
{
    public class Animals
    {
        public bool canBeAPet { get; set; } = true;
        public bool keptInAZoo { get; set; } = true;
        public bool isVicious { get; set; } = true;
        public bool livesMoreThan5Years { get; set; } = true;



        public void PrintAnimalFeatures()
        {
        Console.WriteLine($"Can be a pet : {canBeAPet}");
        Console.WriteLine($" Can be kept in a zoo : {keptInAZoo}");
        Console.WriteLine($" Is Vicious : {isVicious}"); 
        Console.WriteLine($" Lives more than 5 years : {livesMoreThan5Years }");
         }
     }
}
