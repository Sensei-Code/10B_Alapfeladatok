using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzovegesValtozok
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "Hello";
            string b = " felhasználó!";

            //Két string összadása összefűzést eredményez (változó + változó).
            string c = a + b;

            Console.WriteLine(c);
            
            //Két string összadása összefűzést eredményez (változó + literál).
            c = a + " felhasználó!";

            Console.WriteLine(c);

            //Nem írja ki a \a karaktereket, mert a \ a C#-ban escape karakter!
            string f = "c:\alma.txt";
            Console.WriteLine(f);

            //Ha szeretnénk \ jelet kiírni, akkor a string előtti @-tel vagy \\
            //(dupla backslash f="c:\\alma.txt") írásával tehetjük meg.
            f = @"c:\alma.txt";
            Console.WriteLine(f);

            //Kétféleképpen tudok üres stringet létrehozni.
            a = ""; /*vagy*/ a = String.Empty;

            Console.WriteLine("\nS T R I N G E K  Ö S S Z E H A S O N L í T Á S A\n");

            int cmp;
            string str1 = "alma";
            string str2 = "alom";

            //Az str1-et hasonlítjuk az str2-höz.
            cmp = str1.CompareTo(str2);

            //Ha a visszatérési érték nulla, akkor a két szöveg megegyezik!
            if (cmp == 0) Console.WriteLine("{0} = {1}",str1,str2);
            //Ha a visszatérési érték nagyobb mint 0 akkor az első string ABC sorrendben
            //a második string után van
            if (cmp > 0) Console.WriteLine("{0} > {1}",str1,str2);
            //Ha a visszatérési érték kisebb mint 0 akkor az első string ABC sorrendben
            //a második string előtt van.
            if (cmp < 0) Console.WriteLine("{0} < {1}",str1,str2);

            Console.ReadLine();


        }
    }
}
