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
           IceFang iceFang = new IceFang();
           Aeroblast aeroblast = new Aeroblast();
           piplup.LearnAttack(tackle,0);
           piplup.LearnAttack(aquaJet,1);
           piplup.LearnAttack(iceFang,2);
           piplup.LearnAttack(aeroblast,3);


           Ember ember = new Ember();
           DragonRush dragonRush = new DragonRush();
           HyperBeam hyperBeam = new HyperBeam();
           CloseCombat closeCombat = new CloseCombat();
           charmander.LearnAttack(ember,0);
           charmander.LearnAttack(dragonRush,1);
           charmander.LearnAttack(hyperBeam, 2);
           charmander.LearnAttack(closeCombat,3);


           bool isAlive = true;
           while (isAlive)
           {
               PokemonCommon.AsciiArt.PiplupArt.Name();
               foreach (var attack in piplup.Attacks)
               {
                   Console.WriteLine(attack.Name);
               }
               var piplupAttack = Console.ReadLine();
               isAlive = HealthPointCheck.HealthPointChecker(piplup, charmander);
               PokemonCommon.AsciiArt.CharmanderArt.Name();
               foreach (var attack in charmander.Attacks)
               {
                   Console.WriteLine(attack.Name);
               }
               Console.ReadLine();
               isAlive = HealthPointCheck.HealthPointChecker(piplup, charmander);


            }
        }
    }
}