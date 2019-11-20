using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk be egy számot, majd vizsgáljuk meg, hogy az pozitív
            //vagy negatív szám-e.

            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam == 0) Console.WriteLine("A szám NULLA!");
            else if (szam > 0) Console.WriteLine("A megadott szám pozitív!");
                 else Console.WriteLine("A megadott szám negatív!");

            Console.ReadLine();

        }
    }
}
