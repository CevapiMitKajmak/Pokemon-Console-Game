using Pokemon_Console_Game.Classes;
using static Pokemon_Console_Game.Classes.Pokemon;

namespace Pokemon_Console_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon Charizard = new Pokemon();

            Charizard.name = "Charizard";
            Charizard.health = 100;
            Charizard.damage = 10;

            Pokemon Bulbasaurus = new Pokemon();

            Bulbasaurus.name = "Bulbasaurus";
            Bulbasaurus.health = 100;
            Bulbasaurus.damage = 10;

            Attack(Bulbasaurus.damage,Charizard);

            Console.WriteLine(Charizard.health);
        }
    }
}
