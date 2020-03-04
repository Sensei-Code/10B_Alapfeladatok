using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorOtosLotto
{
    class Program
    {
        static void Main(string[] args)
        {

            //A szükséges változók inicializálása
            int db = 0;
            Random r = new Random();
            int veletlen = 0;
            int[] tomb = new int[5];
            bool egyezes;
          

            //Addig fut a ciklus, amíg 5 különböző számot nem generálunk. A db változó
            //értékét csak akkor növeljük, ha olyan számot mentünk a tömbbe, ami még
            //nem szerepel benne.
            while (db < 5)
            {
                //Az egyezes változót alaphelyzetbe állítjuk, mert lehet, hogy az előző
                //"körben" true-ra változott az értéke.
                egyezes = false;

                //legenerálom a véletlen számot
                veletlen = r.Next(1, 6);
             
                //Megvizsgálom a tömbömet, hogy van-e már benne a veletlen
                //változó értékével megegyező szám. A ciklus 0-tól db-ig fut, tehát
                //csak a már legenerált és mentett számokat vizsgálja.
                for (int i = 0; i < db; i++)
                {
                    //Megvizsgáljuk, hogy a tömb aktuális eleme megegyezik-e
                    //a frissen generált véletlenszámmal. Ha igen, akkor ezt egy
                    //változóba elmentjük és kilépünk a for ciklusból.
                    if (tomb[i] == veletlen)
                    {
                        egyezes = true;
                        break;
                    }
                }

                //Ha nem találtunk egyezést a for ciklusban, akkor az egyezes változó
                //tartalma érinetetlen maradt, tehát false. Ekkor hozzáadhatjuk a 
                //véletlenszámot a tömbhöz és növelhetjük a db változót, ami a sikeresen
                //legenerált számok darabszámát jelöli.
                if (egyezes == false)
                {
                    tomb[db] = veletlen;
                    db++;
                }
            }

            //A tömb tartalmának kiírása
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}\t", tomb[i]);
            }
  
            //ENTER leütésére várunk
            Console.ReadLine();
            

        }
    }
}
