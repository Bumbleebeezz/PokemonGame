using PokemonCommon.Pokemons;

namespace PokemonCommon;

public class HealthPointCheck
{
    public static bool HealthPointChecker(Pokemon pokemonTarget, Pokemon pokemonAttacker)
    {
        if (pokemonAttacker.HealthPoints <= 0)
        {
            Console.WriteLine(pokemonTarget.Name + " won the match");
            Console.WriteLine(pokemonAttacker.Name + " fainted");
            ExperiencePoints.ExperiencePointsModifier(pokemonTarget);
            Console.WriteLine(pokemonTarget.Name + " gained 10 xp");
            return false;
        }
        else if (pokemonTarget.HealthPoints <= 0)
        {
            Console.WriteLine(pokemonAttacker.Name + " won the match");
            Console.WriteLine(pokemonTarget.Name + " fainted");
            ExperiencePoints.ExperiencePointsModifier(pokemonAttacker);
            Console.WriteLine(pokemonAttacker.Name + " gained  10 xp");
            return false;
        }
        return true;
    }
}