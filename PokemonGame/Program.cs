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

            Pokemon wartortle = new Pokemon();
            wartortle.Name = "Wartortle";


            Console.WriteLine("-----------------------------");

            Pokemon charmeleon = new Pokemon();
            charmeleon.Name = "Charmeleon";

            Console.WriteLine("-----------------------------");

            Pokemon magmar = new Pokemon();
            magmar.Name = "Magmar";

            Console.WriteLine("----------------------------");
        }
       
    }
}