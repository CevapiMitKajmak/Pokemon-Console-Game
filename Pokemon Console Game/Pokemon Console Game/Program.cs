using Pokemon_Console_Game.Classes;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Threading.Channels;
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
            mewtwo.damage = 1000;

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



            while (proponents.Count >= 0 || opponents.Count >= 0)
            {
                Console.WriteLine("Möchtest du Kämpfen? [Ja/Nein]\n");
                string? input = Console.ReadLine();

                if (input == "Ja")
                {

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
                        Console.WriteLine("Falsche eingabe \n");
                    }


                    Console.WriteLine($"Dein ausgewähltes Pokemon ist {proponents[chosenFriendlyPokemon].name}\n");


                    Console.WriteLine("Wähle ein Pokemon aus, gegen welches du kämpfen möchtest: \n");
                    indexselecter = 0;

                    foreach (Opponent opponent in opponents)
                    {
                        Console.WriteLine(indexselecter + " " + opponent.name);
                        indexselecter++;
                    }

                    int chosenEnemyPokemon = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Dein ausgewähltes Pokemon ist {opponents[chosenEnemyPokemon].name} \n");


                    //Attack Friendly to Enemy 

                    proponents[chosenFriendlyPokemon].FriendlyAttack(opponents[chosenEnemyPokemon]);

                    Console.WriteLine($"Du hast {proponents[chosenFriendlyPokemon].damage} Schaden bei {opponents[chosenEnemyPokemon].name} angerichtet!");

                    if (opponents[chosenEnemyPokemon].health <= 0)
                    {
                        Console.WriteLine($"Du hast {opponents[chosenEnemyPokemon].name} besiegt.");
                        opponents.Remove(opponents[chosenEnemyPokemon]);

                    }
                    else if (opponents[chosenEnemyPokemon].health >= 0)
                    {
                        opponents[chosenEnemyPokemon].EnemyAttack(proponents[chosenFriendlyPokemon]);

                        Console.WriteLine($"{opponents[chosenEnemyPokemon].name} hat zurückgeschlagen und hat {opponents[chosenEnemyPokemon].damage} Schaden bei {proponents[chosenFriendlyPokemon].name} angerichtet");
                    }
                    if (proponents[chosenFriendlyPokemon].health <= 0)
                    {
                        Console.WriteLine($"Dein {proponents[chosenFriendlyPokemon].name} wurde besiegt.");
                        proponents.Remove(proponents[chosenFriendlyPokemon]);
                    }
                }
                else if (input == "Nein")
                {
                    Console.WriteLine("Bis zum nächsten Mal");
                    Environment.Exit(0);
                }
                else if (input != "Ja" || input != "Nein")
                {
                    Console.WriteLine("Bitte 'Ja' oder 'Nein' eingeben.");
                }
            }
        }
    }
}


