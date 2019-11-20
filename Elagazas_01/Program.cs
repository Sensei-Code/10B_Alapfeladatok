using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk be egy pozitív egész számot, ami egy ember életkora.
            //Ha a bekért szám nagyobb vagy egyenlő 18-cal, akkor írjuk ki,
            //hogy a személy nagykorú. Ellenkező esetben írjuk ki, hogy
            //kiskorú.

            Console.Write("Kérlek add meg az életkorodat: ");
            int eletkor = int.Parse(Console.ReadLine());

            //Ha az eletkor változó tartalma nagyobb egyenlő mint 18, akkor kiírja, hogy
            //"Gratulálok! Te nagykorú vagy!". Máskülönben (else) azt írja ki, hogy
            //"Te még kiskorú vagy!".
            if (eletkor >= 18)
            {
                Console.Write("Gratulálok! Te nagykorú vagy!");
            }
            else
            {
                Console.Write("Te még kiskorú vagy!");
            }

            Console.ReadLine();





        }
    }
}
