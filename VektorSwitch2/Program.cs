using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorSwitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int meret = 50;

            int[] tomb = new int[meret];
            int[] tomb25 = new int[meret];
            int[] tomb50 = new int[meret];
            int[] tomb75 = new int[meret];
            int[] tomb99 = new int[meret];

            Random rnd = new Random();
            int elson = 0;
            int masodikn = 0;
            int harmadikn = 0;
            int negyedikn = 0;

            // int veletlen;


            for (int i = 0; i < tomb.Length; i++)
            {
                // veletlen = rnd.Next(1, 100);
                // tomb[i] = veletlen;

                //Egyből a tömbbe mentjük el a véletlen számot, nem használunk
                //külön változót a legenerálásához.
                tomb[i] = rnd.Next(1, 100);
                Console.Write("{0}  ", tomb[i]);               

            }

            for (int i = 0;i<tomb.Length;i++)
                {
                switch (tomb[i])
                {
                    case int j when (j <= 25):
                        {
                            tomb25[elson] = tomb[i];
                            elson++;                            
                            break;
                        }
                    case int j when (j <= 50):
                        {
                            tomb50[masodikn] = tomb[i];
                            masodikn++;
                            break;
                        }
                    case int j when (j <= 75):
                        {
                            tomb75[harmadikn] = tomb[i];
                            harmadikn++;
                            break;
                        }
                    case int j when (j <= 99):
                        {
                            tomb99[negyedikn] = tomb[i];
                            negyedikn++;
                            break;
                        }
                }


            }

            Console.Write("\n\n1-25-ig:{0} db szám: ", elson);
            for (int i = 0; i < elson; i++)
            {
                Console.Write("{0} ", tomb25[i]);
            }

            Console.Write("\n26-50-ig:{0} db szám: ", masodikn);
            for (int i = 0; i < masodikn; i++)
            {
                Console.Write("{0} ", tomb50[i]);
            }

            Console.Write("\n51-75-ig:{0} db szám: ", harmadikn);
            for (int i = 0; i < harmadikn; i++)
            {
                Console.Write("{0} ", tomb75[i]);
            }

            Console.Write("\n76-99-ig:{0} db szám: ", negyedikn);
            for (int i = 0; i < negyedikn; i++)
            {
                Console.Write("{0} ", tomb99[i]);
            }

            Console.ReadLine();



        }
    }
}
