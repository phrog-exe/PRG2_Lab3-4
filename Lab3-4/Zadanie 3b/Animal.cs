using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_3b
{
     class Animal
    {
        public String Name { get; set; }

        public virtual void makeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
