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
            Pokemon charmander = new Pokemon("Charmander", PokemonTypes.Fire);

            Tackle tackle = new Tackle();
            AquaJet aquaJet = new AquaJet();
           piplup.LearnAttack(tackle,0);
           piplup.LearnAttack(aquaJet, attackIndex:1);

           Ember ember = new Ember();
           DragonRush dragonRush = new DragonRush();
           charmander.LearnAttack(ember,0);
           charmander.LearnAttack(dragonRush,1);

           Console.WriteLine(piplup.HealthPoints);
            BattleEngine.MakeAttack(piplup, charmander.Attacks[0]);
            Console.WriteLine(piplup.HealthPoints);
        }
    }
}