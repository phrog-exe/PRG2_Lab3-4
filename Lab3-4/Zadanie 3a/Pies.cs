using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_3a
{
     class Pies : Zwierze, Ssak
    {
        public string kolorSiersci;

        public string rasa;

        public void szczekaj()
        {
            Console.WriteLine("Szczeka");
        }

        public void dajLape() 
        {
            Console.WriteLine("Daje Łape");

        }

        public void aportuj() 
        {
            Console.WriteLine("Aportuje");
        }

        public void biegnij()
        {
            Console.WriteLine("Biegnie");
        }

    }
}
