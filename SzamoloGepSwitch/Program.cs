using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamoloGepSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Készíts egy programot ami bekér két egész számot
            //és egy menürendszer segítségével kiválaszthatod, 
            //összeadod, kivonod, összeszorzod vagy elosztod őket.

            Console.Write("Kérem az A számot: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Kérem a B számot: ");
            double b = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("A = {0}\t  B = {1}", a, b);
            Console.WriteLine("\n1. A két szám összege");
            Console.WriteLine("2. A két szám különbsége");
            Console.WriteLine("3. A két szám szorzata");
            Console.WriteLine("4. A két szám hányadosa");
            Console.Write("\nVálassz egy menüpontot: ");

            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.Write("\nA két szám összege: {0}", a + b);
                    break;
                case 2:
                    Console.Write("\nA két szám különbsége: {0}", a - b);
                    break;
                case 3:
                    Console.Write("\nA két szám szorzata: {0}", a * b);
                    break;
                case 4:                    
                    Console.Write("\nA két szám hányadosa: {0}", Math.Round(a/b,2));
                    break;
                default:
                    Console.Write("Rossz menüpontot választottál!");
                    break;

            }
            Console.ReadLine();



        }
    }
}
