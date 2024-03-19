using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasyosoba.Klasy
{
    class Osoba
    {
        private string Imie;
        private string Nazwisko;
        private static int Licznik = 0;
        
        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Licznik++;
        }
        public void WyswietlLicznik()
        {
            Console.WriteLine(Licznik);
        }

    }
}
