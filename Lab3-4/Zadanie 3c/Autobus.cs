using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_3c
{
    class Autobus : Pojazd
    {
        
        public bool limitKierowcy { get; set; }
        public int liczbaKasownikow { get; set; }

       
        public Autobus(bool limitKierowcy, int liczbaKasownikow, string kolor, int liczbaKol, string marka, bool czyJedzie)
        {
            this.limitKierowcy = limitKierowcy;
            this.liczbaKasownikow = liczbaKasownikow;
            this.kolor = kolor;
            this.liczbaKol = liczbaKol;
            this.marka = marka;
            this.czyJedzie = czyJedzie;
        }

       
        public bool CzyLimitOk()
        {
            if (limitKierowcy)
            {
                Console.WriteLine("Limit kierowcy jest w porządku.");
                return true;
            }
            else
            {
                Console.WriteLine("Limit kierowcy jest przekroczony!");
                return false;
            }
        }
    }
}
