using Klasa.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Uczen pierwszy = new Uczen();
            Console.WriteLine(pierwszy.PrzedstawSie());

            Uczen drugi = new Uczen();
            drugi.WprowadzDane("Małgosia", 'K');
            Console.WriteLine(drugi.PrzedstawSie());

            Console.ReadLine();
        }
    }
}
