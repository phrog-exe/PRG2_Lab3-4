using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
    class Snake : Animal, IAnimal
    {
        public string Name { get; set; }
        public string Pattern { get; set; }
        public string Length { get; set; }
        public bool IsVenomous { get; set; }

        public void animal_sound()
        {
            Console.WriteLine("Ssss Ssss");
        }

        public void DisplayPattern() 
        {
            Console.WriteLine($"Pattern type: {Pattern}");
        }

        public void Move()
        {
            Console.WriteLine($"{Species} {Name} is slithering.");
        }

        public void IsDangerous()
        {
            if( IsVenomous == true) 
            {
                Console.WriteLine("This snake is dangerous");
            }
            else
            {
                Console.WriteLine("This snake is not dangerous");
            }
        }
    }
}
