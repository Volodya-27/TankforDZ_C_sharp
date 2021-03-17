using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfTanks;
using ClassLibrary1;

namespace MyClassLib
{
    internal class Program
    {
        static void Main()
        {
            int tt = 34;

            Game tank = new Game(5);
            for (int i = 0; i < tank.Lenght; i++)
            {
                tank[i] = new Tank($"T-" + tt);
                tt++;
            }
            for (int i = 0; i < tank.Lenght; i++)
            {
                Console.WriteLine(tank[i]);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Win tank \n{tank[2] ^ tank[4]}"); //перевірка на виграш 1 і 3 танка  

            Console.ReadKey();
        }
    }
}
