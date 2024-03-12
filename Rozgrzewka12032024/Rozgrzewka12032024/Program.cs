using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozgrzewka12032024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę, którą chcesz pomnożyć");
            string podanaLiczba = Console.ReadLine();
            int lPomnozona = int.Parse(podanaLiczba) * 2;
            Console.WriteLine ($"Powiększyłem twoją liczbę dwukrotnie i wyszło {lPomnozona}");
            Console.ReadLine();
        }
    }
}
