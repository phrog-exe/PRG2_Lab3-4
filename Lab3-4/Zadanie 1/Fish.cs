using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
     class Fish : Animal, IAnimal
    {
        public string WaterType { get; set; }
        public string Color { get; set; }
        public bool HasFins { get; set; }

        public void Swim()
        {
            Console.WriteLine($"{Species} is swimming.");
        }

        public void DisplayColor()
        {

            Console.WriteLine($"Color of the fish: {Color}");

        }

        public void DisplayWaterType()
        {
            Console.WriteLine($"This {Species} lives in {WaterType} water.");
        }

        public void animal_sound()
        {
            Console.WriteLine("Blub Blub");
        }
    }
}
