using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
     class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }

        public void sleep() 
        {
            Console.WriteLine("Zzzz");
        }

    }
}
