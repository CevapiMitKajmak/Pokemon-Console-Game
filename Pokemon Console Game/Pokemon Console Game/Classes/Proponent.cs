using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console_Game.Classes
{
    internal class Proponent : Pokemon
    {

        public double FriendlyAttack(Opponent opponent)
        {
            opponent.health -= this.damage;

            return opponent.health;
        }
        
    }
}
