using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklus0vegjel
{
    class Program
    {

        /*
         Nulla végjelig olvassunk be számokat a billentyűzetről, majd írassuk ki a számok
         - összegét
         - átlagát
         - a legnagyobb számot             
             */

        static void Main(string[] args)
        {
            int a;
            Console.Write("Kérek egy számot: ");
            a = int.Parse(Console.ReadLine());
            double osszeg = 0;
            int db = 0; ;
            int max = a;

            while (a != 0)
            {
                db++;
                osszeg += a;
                if (a > max) max = a;
                Console.Write("Kérem a következő számot: ");
                a = int.Parse(Console.ReadLine());
            }

            if (db > 0)
            {
                Console.WriteLine("A megadott számok összege: {0}",osszeg);
                Console.WriteLine("A magodott számok átlaga: {0}",Math.Round(osszeg/db,2));
                Console.WriteLine("A legnagyobb szám: {0}",max);
            }

            else Console.WriteLine("Nem adott meg számot!");
            Console.ReadLine();
        }
    }
}
