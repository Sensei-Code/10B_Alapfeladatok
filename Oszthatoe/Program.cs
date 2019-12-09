using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oszthatoe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam > 0)
            {
                if (szam % 7 == 0) Console.Write("A megadott szám osztható héttel!");
                else Console.Write("A megadott szám NEM OSZTHATÓ héttel!");
            }
            else Console.Write("Hiba!! A megadott szám negatív!");

            Console.ReadLine();
        }
    }
}
