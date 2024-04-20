using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_3c
{
    class Samochod : Pojazd
    {
        public String podwozie {  get; set; }

        public Samochod(string podwozie, string kolor, int liczbaKol, string marka, bool czyJedzie)
        {
            this.podwozie = podwozie;
            this.kolor = kolor;
            this.liczbaKol = liczbaKol;
            this.marka = marka;
            this.czyJedzie = czyJedzie;
        }
    }
}
