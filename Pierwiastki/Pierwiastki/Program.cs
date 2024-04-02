using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pierwiastki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj symbol lub liczbę atomową.");
            string symbol = Console.ReadLine();
            if (symbol == "H" || symbol == "1")
            {
                Console.WriteLine("Pierwiastek ten nazywa się wodór.");
            }
            else if (symbol == "He" || symbol == "2")
            {
                Console.WriteLine("Pierwiastek ten nazywa się hel.");
            }
            else if (symbol == "Po")
            {
                Console.WriteLine("Pierwiastek ten nazywa się polon.");
            }
            else if (symbol == "Au")
            {
                Console.WriteLine("Pierwiastek ten nazywa się złoto.");
            }
            else
            {

                Console.WriteLine("Nie znam takiego pierwiastka.");
                

            }



            Console.ReadLine();
        }
    }
}
