using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console_Game.Classes
{
    public class Pokemon
    {
        private Guid _id;
        private string _name;
        private int _level;
        private float _health;

        public Pokemon(string name, float damage, int level, float health)
        {
            _id = Guid.NewGuid();
            _name = name;
            _level = level;
            _health = health;
        }

        public float fight(Pokemon PokemonA, Pokemon PokemonB)
        {
            
        }
    }
}
