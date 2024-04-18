using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
    class Cat : Animal, IAnimal
    {
        public string Breed;

        public string Color;

        public bool IsNeutered;

        public void animal_sound()
        {
            Console.WriteLine("Meow Meow");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Species}'s breed is {Breed} and It's color is {Color}");
        }

        public void Scrach()
        {
            Console.WriteLine($"{Species} is scraching the couch");
        }

        public void HealthCheck()
        {
            if (IsNeutered == true)
            {
                Console.WriteLine("This cat is neutered");
            }
            else
            {
                Console.WriteLine("This cat is not neutered");

            }

        }
    }
}
