using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk be a felhasználótól 5 számot, és számoljuk ki az összegüket.

            //Inicializálok egy 5 elemű int típusú tomb nevű tömböt!
            int[] tomb = new int[5];


            //Tömb feltöltése a felhasználó által megadott számokkal!
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("Kérem a tömb {0}. elemét: ", i + 1);
                string be = Console.ReadLine();
                tomb[i] = int.Parse(be);
            }

            //Létrehozok egy osszeg változót amibe majd összesítem a tömb
            //elemeit
            int osszeg = 0;

            //Egyesével végigmegyek a tömb elemein és hozzáadom őket az osszeg
            //valtozóhoz.
            for (int i = 0; i < tomb.Length; i++)
                     osszeg += tomb[i];

            Console.WriteLine("\nA tömb elemeinek összege: {0}",osszeg);

            Console.ReadLine();

        }
    }
}
