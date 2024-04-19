using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_3c
{
    
        public class Pojazd
        {
           
            public string Kolor { get; set; }
            public int LiczbaKol { get; set; }
            public string Marka { get; set; }

        
            
            public bool CzyJedzie(bool czyJedzie)
            {
                return CzyJedzie;
            }

            // Metoda rozpoczynająca jazdę pojazdu
            public bool Jedz()
            {
                if (!CzyJedzie)
                {
                    CzyJedzie = true;
                    Console.WriteLine("Pojazd rusza.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Pojazd już jedzie.");
                    return false;
                }
            }

            // Metoda zatrzymująca pojazd
            public bool Zatrzymaj()
            {
                if (CzyJedzie)
                {
                    CzyJedzie = false;
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
