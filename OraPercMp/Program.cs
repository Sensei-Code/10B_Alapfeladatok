using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraPercMp
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszmp1 = 0;
            int osszmp2 = 0;

            Console.WriteLine("Kérem az első időpont részleteit: ");
            Console.Write("Kérem az órát: ");
            osszmp1 = osszmp1 + int.Parse(Console.ReadLine()) * 3600;
            Console.Write("Kérem a percet: ");
            osszmp1 = osszmp1 + int.Parse(Console.ReadLine()) * 60;
            Console.Write("Kérem a másodpercet: ");
            osszmp1 = osszmp1 + int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem a második időpont részleteit: ");

            Console.Write("Kérem az órát: ");
            osszmp2 = osszmp2 + int.Parse(Console.ReadLine()) * 3600;
            Console.Write("Kérem a percet: ");
            osszmp2 = osszmp2 + int.Parse(Console.ReadLine()) * 60;
            Console.Write("Kérem a másodpercet: ");
            osszmp2 = osszmp2 + int.Parse(Console.ReadLine());

            Console.Write("A két időpont között eltelt másodpercek szám: {0}", Math.Abs(osszmp1 - osszmp2));
            Console.ReadLine();

                }
    }
}
