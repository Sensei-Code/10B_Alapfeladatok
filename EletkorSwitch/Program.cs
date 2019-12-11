using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletkorSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ELMÉLET: Ha többirányú elágazást (switch) használunk, akkor lehetőségünk
             *van nem csak konkrét értékeket megadni, hanem intervallumot is. Például
             *mit csináljon a program, ha egy szám 10 és 20 közé esik. Ebben az esetben
             *a case kulcsszó után nem egy értéket adunk meg, hanem egy logikai kifejezést
             *aminek ha az értéke true, akkor az fog lefutni.
             
              
             Kérjünk be egy egész számot, tekintsük ezt egy életkornak, és írassuk ki
             az életkorhoz tartozó megnevezést az alábbiak szerint: 
             0..8 gyerek 
             9..18 fiatalkorú 
             19..60 felnőtt
             61..120 nyugdíjas 
             minden más érték esetén adjunk hibaüzenetet  */

            //Kérjünk be egy egész számot
            Console.Write("Kérlek add meg az életkorod: ");
            int eletkor = int.Parse(Console.ReadLine());

            switch (eletkor)
            {
                //Ha az életkor megfelel egy olyan egész számnak ami nagyobb egyenlő
                //mint 0 ÉS kisebb egyenlo mint 8 akkor kiírja, hogy "Gyerek vagy".
                case int i when (i >= 0 && i <= 8):
                    Console.WriteLine("Gyerek vagy!");
                    break;
                case int i when (i >= 9 && i <= 18):
                    Console.WriteLine("Fiatalkorú vagy!");
                    break;
                case int i when (i >= 19 && i <= 60):
                    Console.WriteLine("Felnőtt vagy!");
                    break;
                case int i when (i >= 61 && i <= 120):
                    Console.WriteLine("Nyugdíjas vagy!");
                    break;
                default:
                    Console.WriteLine("HIBA! Hibás életkort adtál meg!");
                    break;
            }
            Console.ReadLine();

        }
    }
}
