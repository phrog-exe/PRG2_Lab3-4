using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_3c
{
    
        public class Pojazd
        {
           
            public string kolor { get; set; }
            public int liczbaKol { get; set; }
            public string marka { get; set; }     
            public bool czyJedzie { get; set; }
       
        
            public bool Jedz()
            {
                if (!czyJedzie)
                {
                    czyJedzie = true;
                    Console.WriteLine("Pojazd rusza.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Pojazd już jedzie.");
                    return false;
                }
            }

            public bool Zatrzymaj()
            {
                if (czyJedzie)
                {
                    czyJedzie = false;
                    Console.WriteLine("Pojazd zatrzymuje się.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Pojazd już jest zatrzymany.");
                    return false;
                }
            }
        }
}
