using Pokemon_Console_Game.Classes;
using System.Linq.Expressions;
using static Pokemon_Console_Game.Classes.Pokemon;

namespace Pokemon_Console_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Proponent> proponents = new List<Proponent>();
            List<Opponent> opponents = new List<Opponent>();

            Proponent mewtwo = new Proponent();
            mewtwo.name = "Mewtwo";
            mewtwo.health = 250;
            mewtwo.damage = 30;
            
            Proponent charizard = new Proponent();
            charizard.name = "Charizard";
            charizard.health = 400;
            charizard.damage = 10;
            Proponent eevee = new Proponent();
            eevee.name = "Eevee";
            eevee.health = 150;
            eevee.damage = 20;
            Proponent pikachu = new Proponent();
            pikachu.name = "Pikachu";
            pikachu.health = 150;
            pikachu.damage = 40;
            Proponent gengar = new Proponent();
            gengar.name = "Gengar";
            gengar.health = 100;
            gengar.damage = 50;
            

            Opponent rayquaza = new Opponent();
            rayquaza.name = "Rayquaza";
            rayquaza.health = 500;
            rayquaza.damage = 70;
            
            Opponent lucario = new Opponent();
            lucario.name = "Lucario";
            lucario.health = 200;
            lucario.damage = 40;
            Opponent bulbasaur = new Opponent();
            bulbasaur.name = "Bulbasaur";
            bulbasaur.health = 275;
            bulbasaur.damage = 20;
            Opponent lugia = new Opponent();
            lugia.name = "Lugia";
            lugia.health = 300;
            lugia.damage = 50;
            Opponent dragonite = new Opponent();
            dragonite.name = "Dragonite";
            dragonite.health = 500;
            dragonite.damage = 45;


            proponents.Add(mewtwo);
            proponents.Add(charizard);
            proponents.Add(eevee);
            proponents.Add(pikachu);
            proponents.Add(gengar);
            opponents.Add(rayquaza);
            opponents.Add(lucario);
            opponents.Add(bulbasaur);
            opponents.Add(lugia);
            opponents.Add(dragonite);

            Console.WriteLine("Wähle ein Pokemon aus zum kämpfen:");
            Console.WriteLine();
            int indexselecter = 0;
            foreach (Proponent proponent in proponents)
            {
                Console.WriteLine(indexselecter + " " + proponent.name);
                indexselecter++;
            }

            int chosenFriendlyPokemon = Convert.ToInt32(Console.ReadLine());
            //Doesnt work, I WILL FIX IT LATER
            if (chosenFriendlyPokemon < 0 || chosenFriendlyPokemon > proponents.Count)
            {
                Console.WriteLine("Falsche eingabe");
            }


            Console.WriteLine("Dein ausgewähltes Pokemon ist " + proponents[chosenFriendlyPokemon].name);
            Console.WriteLine();

            Console.WriteLine("Wähle ein Pokemon aus, gegen welches du kämpfen möchtest:");
            Console.WriteLine();
            indexselecter = 0;

            foreach (Opponent opponent in opponents)
            {
                Console.WriteLine(indexselecter + " " + opponent.name);
                indexselecter++;
            }

            int chosenEnemyPokemon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dein ausgewähltes Pokemon ist " + opponents[chosenEnemyPokemon].name);
            Console.WriteLine();

            //Attack Friendly to Enemy

            proponents[chosenFriendlyPokemon].FriendlyAttack(opponents[chosenEnemyPokemon]);

            Console.WriteLine(opponents[chosenEnemyPokemon].health);

        }
    }
}
