using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę postaci");
            string nazwa = Console.ReadLine();
            Thread.Sleep(3000);
            switch (nazwa.ToLower())
            {
                case "gryf":
                    Console.WriteLine("Gryf z wyglądu jest połączeniem lwa oraz orła.");
                    break;
                default:
                    Console.WriteLine("Nie znam tej postaci.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
