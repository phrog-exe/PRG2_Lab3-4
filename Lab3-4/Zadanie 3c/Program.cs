using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_3c
{
     class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("sedan", "czerwony", 4, "Ford", false);
          
            samochod.Jedz();
            samochod.Zatrzymaj();

            Autobus autobus = new Autobus(true, 2, "żółty", 6, "Mercedes", false);

            autobus.Jedz();
            autobus.Zatrzymaj();
            autobus.CzyLimitOk();
        }
    }
}
