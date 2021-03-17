using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfTanks;
using ClassLibrary1;

namespace WorldOfTanks
{
    class Tank
    {
        private string name_tank;
        private int ammunition;
        private int armor;
        private int maneuverability;

        private static Random random = new Random();
        public string Name_tank { get => name_tank; set { name_tank = value; } }
        public int Ammuunition { get => ammunition; set { ammunition = value; } }
        public int Armor { get => armor; set { armor = value; } }
        public int Maneuverability { get => maneuverability; set { maneuverability = value; } }

        public Tank(string name_tank)
        {
            this.name_tank = name_tank;
            this.ammunition = Convert.ToInt32(MyR.GetRandom(ref random));     //random.Next(0, 100);
            this.armor = Convert.ToInt32(MyR.GetRandom(ref random));          //random.Next(0, 100);
            this.maneuverability = Convert.ToInt32(MyR.GetRandom(ref random));//random.Next(0, 100);
        }
        public Tank(string name_tank, int ammunition, int armor, int maneuverability) //прийшлось перегружати конструктор для виводу коли виграє танк 
        {
            this.name_tank = name_tank;
            this.ammunition = ammunition;
            this.armor = armor;
            this.maneuverability = maneuverability;
        }
        public static Tank operator ^(Tank t1, Tank t2)
        {
            if (t1.ammunition > t2.ammunition && t1.armor > t2.armor || t1.maneuverability > t2.maneuverability)
                return new Tank(t1.name_tank, t1.ammunition, t1.armor, t1.maneuverability);
            else
                return new Tank(t2.name_tank, t2.ammunition, t2.armor, t2.maneuverability);
        }
        public override string ToString() => $" Name {name_tank}\n " +
            $"Ammunition {ammunition}\n Armor {armor}\n Maneuverability {maneuverability} \n\n\n\n";
    }
}
