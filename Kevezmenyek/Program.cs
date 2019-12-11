using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevezmenyek
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Készítsünk programot, mely osztálykirándulásszervezésében segíti a használóját,
            melyhez a lehető legkedvezőbb szállásárat kelleneelérni.A kiválasztott hotelben
            többféle kedvezményt adnak a diákoknak, egyszerre közülük csak az egyik vehető
            igénybe:
            
            –Csoportos kedvezmény: 10 fő alatt 0 %; 10 - 19 fő esetén 5 %; 20 - 29 fő esetén 8 %;
              30 - 40 fő esetén 12 %; 40 fő felett 14 % a kedvezmény mértéke.
            –Intézményi kedvezmény: 5 fő alatt nincs; 5 - 11 fő esetén 1 fő ingyen szálláshoz jut;
              12 - 19 fő esetén 2 fő ingyenes; 20 - 28 fő esetén 3 fő ingyenes; 29 - 40 fő esetén 4 fő,míg 40 fő felett 5 fő kap ingyenes szállást.
            –Diákkedvezmény: egyénileg is jár, mértéke 10
            
            Készítsen programot, amely beolvassa a kiránduláson résztvevők számát majd
            megadja, hogy a háromféle kedvezményből melyiket kell igénybe venni, hogy a
            lehető legkevesebbe kerüljön a szállás.
*/

            Console.Write("Kérem a kirándulás létszámát: ");
            int letszam = int.Parse(Console.ReadLine());
            int csopkedv = 0;
            int intkedv = 0;
            int diakkedv = letszam*10;

            switch (letszam)
            {
                case int i when (i < 10):
                    csopkedv = 0;
                    break;
                case int i when (i >= 10 && i <= 19):
                    csopkedv = letszam * 5;
                    break;
                case int i when (i >= 20 && i <= 29):
                    csopkedv = letszam * 8;
                    break;
                case int i when (i >= 30 && i <= 40):
                    csopkedv = letszam * 12;
                    break;
                case int i when (i >= 40):
                    csopkedv = letszam * 14;
                    break;
            }

            switch (letszam)
            {
                case int i when (i < 5):
                    intkedv = 0;
                    break;
                case int i when (i >= 5 && i <= 11):
                    intkedv = 100;
                    break;
                case int i when (i >= 12 && i <= 19):
                    intkedv = 200;
                    break;
                case int i when (i >= 20 && i <= 28):
                    intkedv = 300;
                    break;
                case int i when (i >= 29 && i <= 40):
                    intkedv = 400;
                    break;
                case int i when (i > 40):
                    intkedv = 500;
                    break;
            }

            Console.WriteLine("Kedvezmények mértéke:");
            Console.WriteLine("A csoportos kedvezmény mértéke: {0}",csopkedv);
            Console.WriteLine("Az intézményi kedvezmény mértéke: {0}", intkedv);
            Console.WriteLine("A diákkedvezmény mértéke: {0}\n\n", diakkedv);            

            if (csopkedv > intkedv && csopkedv > diakkedv)
                Console.WriteLine("A legjobb kedvezmény a csoportos kedvezmény!");
            else if (intkedv > csopkedv && intkedv > diakkedv)
                  Console.WriteLine("A legjobb kedvezmény az intézményi kedvezmény!");
                 else
                Console.WriteLine("A legjobb kedvezmény a diákkedvezmény!");



            Console.ReadLine();

        }
    }
}
