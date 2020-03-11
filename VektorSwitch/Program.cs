using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            //Készítsetek programot ami feltölt egy tömböt 50 darab véletlenszámmal
            //1 -99 intervallumból, majd megszámolja, hogy azok közül hány darab
            //esik 1-25, 26-50, 51-75 és 76-99 közé!

            int[] tomb = new int[50];
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

                switch (tomb[i])
                {
                    case int j when (j<=25):
                        {
                            elson++;
                            break;
                        }
                    case int j when (j <= 50):
                        {
                            masodikn++;
                            break;
                        }
                    case int j when (j <= 75):
                        {
                            harmadikn++;
                            break;
                        }
                    case int j when (j <= 99):
                        {
                            negyedikn++;
                            break;
                        }
                }

            }

            Console.WriteLine("\n\n1-25-ig:\t{0} db szám",elson);
            Console.WriteLine("26-50-ig:\t{0} db szám", masodikn);
            Console.WriteLine("51-75-ig:\t{0} db szám", harmadikn);
            Console.WriteLine("76-99-ig:\t{0} db szám", negyedikn);

            Console.ReadLine();


             
        }
    }
}
