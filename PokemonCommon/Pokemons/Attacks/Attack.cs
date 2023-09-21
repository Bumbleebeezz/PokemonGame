using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons.Attacks;

public abstract class Attack
{
    public double Damage { get; }

    public string Name { get; }   

    public PokemonTypes Type { get; }

    protected Attack(int damage, string name, PokemonTypes type)
    {
        Damage = damage;
        Name = name;
        Type = type;
    }
}