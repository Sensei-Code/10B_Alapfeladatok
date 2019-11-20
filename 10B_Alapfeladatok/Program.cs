using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10B_Alapfeladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk be két számot, az egyik egy születési évszám, a másik az 
            //aktuális évszám! Számoljuk ki, hogy hány éves a személy!
            //Két változó létrehozása
            int aktevszam;
            int szulevszam;

            //Bekérjük a két évszámot
            Console.Write("Kérem adja meg az aktuális évet: ");
            //Az int.Parse() metódussal át kell konvertálnunk a megadott
            //értéket, mivel a Console.ReadLine() mindig szöveges értéket ad
            //vissza, nekünk pedig int típusúra van szükségünk.
            aktevszam = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a születési évet: ");
            szulevszam = int.Parse(Console.ReadLine());

            //Az eletkor változóba elmentjük a két évszám különbségét.
            int eletkor = aktevszam - szulevszam;

            //Kiíratjuk az eletkor valtozó tartalmát. A {0} azt jelentni, hogy
            //oda fogja behelyettesíteni a szöveg után megadott 0. paramétert, jelen
            //esetben az eletkor valtozót. A számozás mindig 0-tól indul.
            Console.Write("Az ön életkora: {0} év", eletkor);

            //Enter leütésére várunk. A \n vezérlőkarakter új sort jelent.
            Console.Write("\n\n\nA kilépéshez kérem üssön egy ENTERT!");
            Console.ReadLine(); ;
        }
    }
}
