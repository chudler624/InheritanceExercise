using System;
using System.Collections.Generic;
using System.Text;
using Inheritance;

namespace Inheritance
{
    public class Reptiles : Animals
    {
        public bool hasScales {get; set;} = true;
        public bool livesNearWater {get; set;} = true ;
        public bool isACarnivore { get; set;} = true;
        public bool likesWarmTemperatures { get; set; } = true;

        public void PrintReptileFeatures()
        {


            Console.WriteLine($"Has scales : {hasScales}");
            Console.WriteLine($"Lives near water : {livesNearWater}");
            Console.WriteLine($" Is a carnivore : {isACarnivore}");
            Console.WriteLine($" Likes warm tempertaures : {likesWarmTemperatures}");

        }
    }
}
