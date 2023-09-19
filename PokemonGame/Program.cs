using System.Security.Cryptography.X509Certificates;

namespace PokemonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartScreenMenu start = new StartScreenMenu();
            start.StartLogo();

            // Create a trainers
            Trainer trainerJack = new Trainer();
            Trainer trainerJen = new Trainer();

            // Create pokemons
            Pokemon pikachu = new("Pikachu", PokemonTypes.Electric);
            Pokemon charmander = new("Charmander", PokemonTypes.Fire);
            Pokemon eevee = new("Eevee", PokemonTypes.Normal);
            Pokemon bulbasaur = new("Bulbasaur", PokemonTypes.Grass);
            Pokemon jigglypuff = new("Jigglypuff", PokemonTypes.Fairy);
            Pokemon psyduck = new("Psyduck", PokemonTypes.Water);
            Pokemon togepi = new("Togepi", PokemonTypes.Fairy);

            // Make a trainer do something
            trainerJack.Catch(pikachu); 
            trainerJack.MissedCatch(charmander);
            trainerJack.Catch(togepi);
            trainerJack.Catch(bulbasaur);

            Console.WriteLine("---------------------------");

            // Print every pokemon in PokemonCollection with name and type
            foreach (var pokemon in trainerJack.PokemonCollection)
            {
                Console.WriteLine(pokemon.Name + " : " + pokemon.Type);
            }

            Console.WriteLine("----------------------------");

            // Release every pokemon one by one and print out who got released
            for (int i = 0; i  < trainerJack.PokemonCollection.Count;) 
            {
                trainerJack.Release(trainerJack.PokemonCollection[i]);
            }


            Console.WriteLine("--------------------------------");


            WaterPokemon wartortle = new WaterPokemon();
            wartortle.Name = "Wartortle";
            Console.WriteLine(wartortle.Name);
            trainerJack.Catch(wartortle);


            Console.WriteLine("-----------------------------");

            FirePokemon charmeleon = new FirePokemon();
            charmeleon.Name = "Charmeleon";
            trainerJack.Catch(charmeleon);
            charmeleon.Ember();

            foreach (Pokemon pokemon in trainerJack.PokemonCollection)
            {   
                if (pokemon is FirePokemon fire) 
                { 
                    fire.Ember();
                }
                else if (pokemon is WaterPokemon water) 
                { 
                    water.Bubble();
                }
            }

            MagmaPokemon magmar = new MagmaPokemon();
            magmar.Name = "Magmar";

            Console.WriteLine(magmar.Name);
            Console.WriteLine(magmar.Type);

            trainerJack.Catch(magmar);

            Console.WriteLine("----------------------------");


            BugPokemon combee = new BugPokemon();
            combee.Name = "Combee";
            trainerJack.Catch(combee);

            RockPokemon shieldon = new RockPokemon();
            shieldon.Name = "Shieldon";
            trainerJack.Catch(shieldon);

            foreach (Pokemon pokemon in trainerJack.PokemonCollection)
            {
                if (pokemon is BugPokemon bug) 
                { 
                    bug.BugBite();
                }
                else if (pokemon is RockPokemon rock) 
                { 
                    rock.RockThrow();
                }
            }

        }
    }
}