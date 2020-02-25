using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzovegesSzGep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy műveletet: ");
            string s = Console.ReadLine();

            int muvelethelyzet = 0;
            double a = 0;
            double b = 0;

            if (s.IndexOf("+") != -1)
            {
                muvelethelyzet = s.IndexOf("+");

                a = double.Parse(s.Substring(0, muvelethelyzet));
                b = double.Parse(s.Substring(muvelethelyzet + 1, s.Length - (muvelethelyzet + 1)));

                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            }
            else if (s.IndexOf("-") != -1)
            {
                 muvelethelyzet = s.IndexOf("-");

                 a = double.Parse(s.Substring(0, muvelethelyzet));
                 b = double.Parse(s.Substring(muvelethelyzet + 1, s.Length - (muvelethelyzet + 1)));

                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            }


            Console.ReadLine();

        }
    }
}
