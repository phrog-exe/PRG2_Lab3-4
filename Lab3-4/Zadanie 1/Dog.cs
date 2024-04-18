using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
    class Dog : Animal, IAnimal
    {
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Owner { get; set; }

        public void animal_sound()
        {
            Console.WriteLine("Hau Hau");
        }

        public void Move()
        {
            Console.WriteLine($"{Species} is walking.");
        }

        public void DisplayBreed()
        {
            Console.WriteLine($"this dogs breed is {Breed}.");

        }

        public void DisplayOwner()
        {
            Console.WriteLine($"This dogs owner is {Owner}");
        }
    }
}
