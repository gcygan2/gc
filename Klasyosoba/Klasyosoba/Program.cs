using Klasyosoba.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasyosoba
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Dawid", "Małkiewiz");
            osoba.WyswietlLicznik();
            Osoba osoba2 = new Osoba("Grzegorz", "Cygan");
            osoba.WyswietlLicznik();
            Console.ReadKey();
        }
    }
}
