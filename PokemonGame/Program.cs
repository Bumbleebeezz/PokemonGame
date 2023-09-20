using PokemonCommon.Pokemons;
using PokemonCommon.Trainers;

namespace PokemonGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartScreenMenu start = new StartScreenMenu();
            start.StartLogo();

            // Create a trainers
            Trainer trainerJack = new Trainer();
            Trainer trainerJen = new Trainer();

            Console.WriteLine("-----------------------------");

            WaterPokemon wartortle = new WaterPokemon();
            wartortle.Name = "Wartortle";


            Console.WriteLine("-----------------------------");

            FirePokemon charmeleon = new FirePokemon();
            charmeleon.Name = "Charmeleon";

            Console.WriteLine("-----------------------------");

            MagmaPokemon magmar = new MagmaPokemon();
            magmar.Name = "Magmar";
            magmar.Eat("apple");

            Console.WriteLine("----------------------------");
        }
       
    }
}