using PokemonCommon;
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

            StartScreenMenu.StartLogo();
            Console.ReadKey();

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

           Console.WriteLine("Piplup xp: " + piplup.XP);
           Console.WriteLine("Charmander xp: " + charmander.XP);

           bool isAlive = true;
           while (isAlive)
           {
                
                Console.WriteLine("Piplup hp:" + piplup.HealthPoints);
                BattleEngine. MakeAttack(piplup, charmander.Attacks[0], charmander.Name);
                Console.WriteLine("Piplip hp:" + piplup.HealthPoints);

                Console.WriteLine("Charmander hp:" + charmander.HealthPoints);
                BattleEngine.MakeAttack(charmander,  piplup.Attacks[1], piplup.Name);
                Console.WriteLine("Charmander hp:" + charmander.HealthPoints);

                isAlive = HealthPointCheck.HealthPointChecker(piplup, charmander);
           }
        }
    }
}