using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console_Game.Classes
{
    public class Pokemon
    {
        public string name;
        public double health;
        public double damage;


       public static double Attack(double damage, Pokemon a)
        {
            a.health -= damage;
                
                return a.health;
        }
    }
}
