using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
     class Cow : Animal, IAnimal
    {
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Owner { get; set; }

        public void Eat()
        {
            Console.WriteLine($"Cows eat grass");
        }

        public void Move()
        {
            Console.WriteLine($"{Species} is galloping.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Species} is a {Breed}.");
        }
        public void animal_sound()
        {
            Console.WriteLine("Muu Muu");
        }
    }
}
