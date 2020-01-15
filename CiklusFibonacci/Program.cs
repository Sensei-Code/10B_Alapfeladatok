using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklusFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Kérjünk be egy számot a felhasználótól és annyi elemét írassuk ki
             a Fibonacci számsorozatnak. Az első elem 0, a második elem 1, minden
             további elemet úgy kapunk, hogy az előző kettőt összeadjuk!
             Pl.: 0,1,1,2,3,5,8,13,21,...
             */

            Console.Write("Mennyi elemet írjak ki a Fibonacci sorozatból: ");
            int be = int.Parse(Console.ReadLine());
            int index = 1;

            int a = 0;
            int b = 1;
            int osszeg;
            Console.WriteLine(a);
            Console.WriteLine(b);

            while (index <= be - 2)
            {
                osszeg = a + b;
                a = b;
                b = osszeg;

                Console.WriteLine(osszeg);

                index++;
            }
            Console.ReadLine();
        }
    }
}
