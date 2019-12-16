using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeletlenSzamok
{
    class Program
    {
        /*Készítsünk programot ami egy ötöslottó sorsolást szimulál!
         * Írjunk ki a képernyőre 5 db véletlen számot 1-99 tartományból)!
         */

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int szam = rnd.Next(1,100);
            Console.WriteLine("Az első szám: {0}",szam);
            szam = rnd.Next(1,100);
            Console.WriteLine("A második szám: {0}", szam);
            szam = rnd.Next(1, 100);
            Console.WriteLine("A harmadik szám: {0}", szam);
            szam = rnd.Next(1, 100);
            Console.WriteLine("A negyedik szám: {0}", szam);
            szam = rnd.Next(1, 100);
            Console.WriteLine("Az ötödik szám: {0}", szam);

            Console.ReadLine();


        }
    }
}
