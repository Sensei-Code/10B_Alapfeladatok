using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk be egy egész számot és döntsük el róla, hogy páros vagy
            //páratlan

            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());

            //Kiszámoljuk a kettővel való osztás maradékát. 6 % 3 = 0 Mert 6-ban a 3 megvan 2-szer, maradék a 0.
            //5 % 2 = 1 Mert 5-ben a 2 megvan 2-szer, maradék az egy (2*2=4 ahhoz, hogy 5 legyen 1-et kellene adni).
            int maradek = szam % 2;

            //Megvizsgáljuk a maradékot, ha nulla akkor maradék nélkül megvan a számban a 2, tehát páros. Ellenkező
            //esetben páratlan
            if (maradek == 0) Console.WriteLine("A megadott szám páros!");
            else Console.Write("A megadott szám páratlan");

            Console.ReadLine();

        }
    }
}
