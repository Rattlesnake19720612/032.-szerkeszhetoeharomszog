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
