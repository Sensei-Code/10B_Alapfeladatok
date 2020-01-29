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
            //Lehessen új számokat is bekérni, valamint legyen egy menüpont
            //a kilépésre.

            Console.Write("Kérem az A számot: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Kérem a B számot: ");
            double b = double.Parse(Console.ReadLine());

            int menu = 0;

            do {

                Console.Clear();

                Console.WriteLine("A = {0}\t  B = {1}", a, b);
                Console.WriteLine("\n1. A két szám összege");
                Console.WriteLine("2. A két szám különbsége");
                Console.WriteLine("3. A két szám szorzata");
                Console.WriteLine("4. A két szám hányadosa");
                Console.WriteLine("5. Új számok bekérése");
                Console.WriteLine("6. Kilépés");
                Console.Write("\nVálassz egy menüpontot: ");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("\nA két szám összege: {0}", a + b);
                        Console.WriteLine("Üss egy ENTER-t a folytatáshoz!");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("\nA két szám különbsége: {0}", a - b);
                        Console.WriteLine("Üss egy ENTER-t a folytatáshoz!");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("\nA két szám szorzata: {0}", a * b);
                        Console.WriteLine("Üss egy ENTER-t a folytatáshoz!");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("\nA két szám hányadosa: {0}", Math.Round(a / b, 2));
                        Console.WriteLine("Üss egy ENTER-t a folytatáshoz!");
                        Console.ReadLine();
                        break;
                    case 5:


                        break;
                    case 6:
                        break;
                    default:
                        Console.Write("Rossz menüpontot választottál!");
                        break;
                }

            } while (menu!=6);

            Console.ReadLine();



        }
    }
}
