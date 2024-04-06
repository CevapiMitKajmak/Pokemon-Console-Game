using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console_Game.Classes
{
    internal class Ability
    {
        private Guid _id;
        private string _name;
        private int _useAmount;
        private float _damage;


        public Ability(string name, int useAmount, float damage)
        {
            _id = Guid.NewGuid();
            _name = name;
            _useAmount = useAmount;
            _damage = damage;
        }
    }
}
