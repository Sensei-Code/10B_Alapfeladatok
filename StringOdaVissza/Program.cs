using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOdaVissza
{
    class Program
    {
        //Egy beolvasott mondatról döntse el, hogy visszafelé is ugyanazt jelentik-e!
        //Pl. Indul a görög aludni. Géza kék az ég. Figyeljünk az írásjelekre!
        static void Main(string[] args)
        {
            Console.Write("Kérem a mondatot: ");
            string s = Console.ReadLine();
       
            s = s.Replace(" ", "").ToLower();

            int i = 0;
            int j = s.Length-1;
            bool eredmeny = true;

            while (i <= j)
            {
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    eredmeny = false;
                    break;
                }
            }


            Console.WriteLine(eredmeny);
            Console.ReadLine();
        }
    }
}
