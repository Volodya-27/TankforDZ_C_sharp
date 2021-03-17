using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfTanks;
using ClassLibrary1;

namespace WorldOfTanks
{
    class Game
    {
        Tank[] tank;
        public int Lenght { get => tank.Length; }

        public Game(int lenght)
        {
            tank = new Tank[lenght];
        }
        public Tank this[int index]
        {
            get => tank[index];
            set { tank[index] = value; }
        }
    }
}
