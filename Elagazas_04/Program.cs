using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk be két számot és a nagyobbikat osszuk el
            //a kisebbikkel. Az eredményt két tizedesjegy pontossággal
            //írjuk ki. A kerekítésre a Math.Round() függvény szolgál.
            Console.Write("Kérem az A számot: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Kérem a B számot: ");
            double b = double.Parse(Console.ReadLine());

            //Ha az A szám a nagyobb akkor azt osztjuk el a B-vel, ellenkező esetben
            //fordítva. ÉS (&&) operátorral vizsgáljuk még, hogy az osztandó ne legyen
            //0. A Math.Round() függvény két tizedesjegyre kerekíti az a/b, vagy b/a
            //kifejezéseket.
            if (a > b && b != 0) Console.WriteLine("{0}/{1} = {2}", a, b, Math.Round(a / b, 2));
            else if (b > a && a != 0) Console.WriteLine("{0}/{1} = {2}", b, a, Math.Round(b / a, 2));
                 else Console.WriteLine("HIBA! A nullával való osztás értelmetlen!");

            Console.ReadLine();
        }
    }
}
