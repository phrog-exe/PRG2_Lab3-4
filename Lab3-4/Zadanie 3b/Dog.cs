using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_3b
{
     class Dog : Animal
    {
       public new String Name { get; set; }

        public override void makeSound()
        {
            Console.WriteLine("hau hau");
        }
    }
}
