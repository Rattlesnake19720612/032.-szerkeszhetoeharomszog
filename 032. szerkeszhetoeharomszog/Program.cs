using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032.szerkeszhetoeharomszog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a háromszög egyik befogóját! ");
            int befogo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a háromszög másik befogóját! ");
            int befogo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a háromszög átfogóját! ");
            int atfogo = Convert.ToInt32(Console.ReadLine());

            {
                if (befogo1 + befogo2 > atfogo && befogo1 + atfogo > befogo2)
                    Console.WriteLine("Ezekkel az adatokkal szerkeszthető háromszög.");

                else if (befogo2 + atfogo > befogo1 && befogo2 + befogo1 > atfogo && atfogo + befogo2 > befogo1)
                    Console.WriteLine("Ezekkel az adatokkal szerkeszthető háromszög.");

                else
                    Console.WriteLine("Ezekkel az adatokkal nem szerkeszthető háromszög.");

            }

            Console.ReadKey();
        }
    }
}

/*Ez egy C# program, amely meghatározza, hogy létrehozható-e háromszög a megadott oldalakkal. A program bekéri a felhasználótól a háromszög két befogójának és az átfogójának hosszát, majd ellenőrzi, hogy bármely két oldal összege nagyobb-e a harmadik oldalnál. Ha ez a feltétel teljesül, a program kiírja, hogy létrehozható a háromszög, különben kiírja, hogy nem hozható létre.
Íme, hogyan működik a program lépésről lépésre:
A program a konzolra írja az üzeneteket, amelyek arra kérnek, hogy a felhasználó adja meg a háromszög két befogójának és az átfogójának hosszát.
A program ezeket az értékeket egész számokként olvassa be a Convert.ToInt32 metódus és a Console.ReadLine használatával.
A program ellenőrzi, hogy a két első oldal (befogo1 és befogo2) összege nagyobb-e a harmadik oldalnál (atfogo). Ha ez a feltétel igaz, a program kiírja az üzenetet, hogy létrehozható a háromszög. Ezt az ellenőrzést az if utasítással hajtja végre.
Ha az if utasítás feltétele hamis, a program egy másik feltételt ellenőriz annak érdekében, hogy megnézze, létrehozható-e a háromszög. Ebben az esetben az ellenőrzés annak a feltételnek a vizsgálatát jelenti, hogy bármely két oldal összege nagyobb-e a harmadik oldalnál. Ha ez a feltétel igaz, a program kiírja az üzenetet, hogy létrehozható a háromszög. Ezt az ellenőrzést az else if utasítással hajtja végre.
Ha mind az if, mind az else if utasítások feltételei hamisak, a program kiírja az üzenetet, hogy nem hozható létre a háromszög.*/
