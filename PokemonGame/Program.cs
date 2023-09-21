using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks;
using PokemonCommon.Trainers;

namespace PokemonGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Trainer trainerJack = new Trainer();

            Pokemon piplup = new Pokemon("Piplup", PokemonTypes.Water);

            Tackle tackle = new Tackle();
           piplup.LearnAttack(tackle,0);

           foreach (var piplupAttack in piplup.Attacks)
           {
               if (piplupAttack == null)
               {
                   continue;
               }
               Console.WriteLine(piplupAttack.Name);
           }
        }
    }
}