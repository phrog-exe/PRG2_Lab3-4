using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_3a
{
     class Program
    {
         static void Main(string[] args)
        {
            Pies pies = new Pies();

            pies.rasa = "Dalmatyńczyk";
            pies.kolorSiersci = "Biały w czarne łaty";
            pies.masa = 20;
            pies.wiek = 3;

            pies.patrz();
            pies.oddychaj();
            pies.biegnij();
            pies.dajLape();
            pies.szczekaj();
            pies.aportuj();

            
        }
    }
}
