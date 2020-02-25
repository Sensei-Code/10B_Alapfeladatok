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

            Console.WriteLine("\nSTRINGEK ÖSSZEHASONLíTÁSA\n");

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

            Console.WriteLine("\nSTRING HOSSZÁNAK MEGHATÁROZÁSA\n");
            //A hossz változóba elmentjük, hogy milyen hosszú az str1 változóban
            //lévő szöveg.
            int hossz = str1.Length;
            Console.WriteLine("A(z) {0} szöveg {1} karakter hosszú",str1,hossz);

            Console.WriteLine("\nSTRING ADOTT KARAKTERÉNEK A KIOLVASÁSA\n");
            //Hivatkozhatunk egy szöveg karaktereire a [szám] segítségével. A sorszámozás
            //0-tól kezdődik, tehát a [1] a szöveg 2. karakterét jelenti.
            Console.WriteLine("Az str1({0}) változó 3. karaktere: {1}",str1,str1[2]);
            
            //A szöveg TrimStart(karakter) és TrimEnd(karakter) függvénye a megadott
            //karaktert levágja a szöveg elejéről vagy a végéről. A karaktert ' ' jelek
            //között adjuk meg! Ideális a felesleges szóközök eltávolítására. 
            //A ToUpper() és a ToLower() metódusok kis- vagy nagybetűssé alakítják
            //a szöveget.
            Console.WriteLine("\nSTRING KIS- ÉS NAGYBETŰSSÉ ALAKíTÁSA, LEVÁGÁS\n");
            string s = "aaLmaa";
            Console.WriteLine("Szöveg = {0}",s);
            Console.WriteLine("{0} - A szöveg elejéről levágtuk az a karaktereket", s.TrimStart('a'));
            Console.WriteLine("{0} - A szöveg végéről levágtuk az a karaktereket", s.TrimEnd('a'));
            Console.WriteLine("{0} - Nagybetűssé alakítottuk a szöveget",s.ToUpper());
            Console.WriteLine("{0} - Kisbetűssé alakítottuk a szöveget",s.ToLower());


            //A SubString függvénnyel lehetőségünk van szövegrészletek kivágására. Ha két 
            //számot adunk meg, akkor az elsőtől a másodikig vágja ki a szövegrészletet. Ha
            //csak egy számot adunk paraméterként, akkor onnantól a szöveg végéig lévő részt
            //adja vissza.
            Console.WriteLine("\nsubstring - SZÖVEGRÉSZLET KIMÁSOLÁSA\n");
            s = "körtefa";
            Console.WriteLine("Szöveg = {0}", s);
            Console.WriteLine("A szöveg 1. karakternél kezdődő és az 5-nél végződő részlete: {0}", s.Substring(0, 5));
            Console.WriteLine("A szöveg 6. karakterétől kezdődő részlet: {0}",s.Substring(5));



            Console.WriteLine("\nKERESÉS A SZÖVEGBEN\n");
            
            char keresett = 't';
            int i = s.IndexOf(keresett);            
          
            Console.WriteLine("A {0} szövegben a {1} karakter a {2}. pozíciótól kezdődik",s,keresett,i+1);
            

            Console.ReadLine();


        }
    }
}
