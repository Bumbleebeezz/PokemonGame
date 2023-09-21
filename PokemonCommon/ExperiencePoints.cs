using PokemonCommon.Pokemons;

namespace PokemonCommon;

public class ExperiencePoints
{
    public static void ExperiencePointsModifier(Pokemon pokemon)
    {
        pokemon.XP += 10;
    }
}