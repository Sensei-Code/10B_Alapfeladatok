using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklusWhile00
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int szam = 0;
            int i = 6;

            while (i < 5)
            {
                szam = rnd.Next(1, 100);
                Console.Write("{0} ", szam);
                i++;
            }

            Console.ReadLine();

        }
    }
}
