using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklusHasonlitas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk be két számot és döntsük el melyik a nagyobb! Ha a két szám
            //megegyezik akkor kérjük be újból a másodikat!
            
            //Bekérjük a két számot
            Console.Write("Kérem az A számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a B számot: ");
            int b = int.Parse(Console.ReadLine());

            //Ha a két szám megegyezik akkor belelép a ciklusba és újból bekéri
            //a B számot! Ha különböznek akkor nem lép bele, hanem egyből az
            //összehasonlításra ugrik.
            while (a == b)
            {
                Console.WriteLine("\nHiba! A két szám megegyezik!\n");
                Console.Write("Kérem adja meg újra a B számot: ");
                b = int.Parse(Console.ReadLine());
            }

            //Lehetséges megoldás hátultesztelő ciklussal. A másik jobb.
            /* int a,b;
            Console.Write("Kérem az A számot: ");
            a = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Kérem a B számot: ");
                b = int.Parse(Console.ReadLine());
                if (a == b) Console.WriteLine("\nHiba! A két szám megegyezik!\n");
            } while (a == b);*/
            

            //Összehasonlítja a két számot, hogy melyik a nagyobb!
            if (a > b) Console.WriteLine("A nagyobb szám az A ({0})",a);
            else Console.WriteLine("A nagyobb szám a B ({0})",b);

            Console.ReadLine();



        }
    }
}
