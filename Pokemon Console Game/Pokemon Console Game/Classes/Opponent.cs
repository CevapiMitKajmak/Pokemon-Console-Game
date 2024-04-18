using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console_Game.Classes
{
    internal class Opponent : Pokemon
    {
        
        public double EnemyAttack(Proponent proponent)
        {
            proponent.health -= this.damage;
            return proponent.health;
        }
        
    }
}
