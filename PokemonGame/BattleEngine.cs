using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks;

namespace PokemonGame;

public static class BattleEngine
{
    public static void MakeAttack(Pokemon target, Attack attack)
    {
        Effectiveness effectiveness = CheckEffectiveness(target.Types.ToArray(), attack.Type);
        double modifier = (double)effectiveness / 100.0;

        target.HealthPoints = target.HealthPoints - attack.Damage * modifier;
    }

  
    public static Effectiveness CheckEffectiveness(PokemonTypes[] targetTypes, PokemonTypes attackType)
  #region EffectivenessChecks
    {
        switch (attackType)
        {
            case PokemonTypes.Normal:
                return NormalAttackEffectiveness(targetTypes);
            case PokemonTypes.Fire:
                return FireAttackEffectiveness(targetTypes);
            case PokemonTypes.Water:
                return WaterAttackEffectiveness(targetTypes);
            case PokemonTypes.Grass:
                return GrassAttackEffectiveness(targetTypes);
            case PokemonTypes.Electric:
                return ElectricAttackEffectiveness(targetTypes);
            case PokemonTypes.Ice:
                return IceAttackEffectiveness(targetTypes);
            case PokemonTypes.Fighting:
                return FightingAttackEffectiveness(targetTypes);
            case PokemonTypes.Poison:
                return PoisonAttackEffectiveness(targetTypes);
            case PokemonTypes.Ground:
                return GroundAttackEffectiveness(targetTypes);
            case PokemonTypes.Flying:
                return FlyingAttackEffectiveness(targetTypes);
            case PokemonTypes.Psychic:
                return PsychicAttackEffectiveness(targetTypes);
            case PokemonTypes.Bug:
                return BugAttackEffectiveness(targetTypes);
            case PokemonTypes.Rock:
                return RockAttackEffectiveness(targetTypes);
            case PokemonTypes.Ghost:
                return GhostAttackEffectiveness(targetTypes);
            case PokemonTypes.Dragon:
                return DragonAttackEffectiveness(targetTypes);
            case PokemonTypes.Dark:
                return DarkAttackEffectiveness(targetTypes);
            case PokemonTypes.Steel:
                return SteelAttackEffectiveness(targetTypes);
            case PokemonTypes.Fairy:
                return FairyAttackEffectiveness(targetTypes);
            default:
                return Effectiveness.Normal;
        }
    }

    private static Effectiveness FireAttackEffectiveness(List<PokemonTypes> targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Poison))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fighting))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Dragon))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Dark))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }
    private static Effectiveness SteelAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Water))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Electric))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Ice))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Rock))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Fairy))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness DarkAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fighting))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Dragon))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fairy))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Psychic))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Ghost))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness DragonAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fairy))
            return Effectiveness.None;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Dragon))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness GhostAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Normal))
            return Effectiveness.None;
        if (targetTypes.Contains(PokemonTypes.Dark))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Psychic))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Ghost))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness RockAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fighting))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Ground))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Ice))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Flying))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Bug))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness BugAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fighting))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Poison))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Flying))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Ghost))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fairy))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Grass))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Psychic))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Dark))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness PsychicAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Dark))
            return Effectiveness.None;
        if (targetTypes.Contains(PokemonTypes.Psychic))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fighting))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Poison))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness FlyingAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Electric))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Rock))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Grass))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Fighting))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Bug))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness GroundAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Flying))
            return Effectiveness.None;
        if (targetTypes.Contains(PokemonTypes.Bug))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Grass))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Electric))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Poison))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Rock))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }
    private static Effectiveness FairyAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Poison))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fighting))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Dragon))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Dark))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }
    private static Effectiveness PoisonAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.None;
        if (targetTypes.Contains(PokemonTypes.Poison))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Ground))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Rock))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Ghost))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Grass))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Fairy))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness FightingAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Ghost))
            return Effectiveness.None;
        if (targetTypes.Contains(PokemonTypes.Poison))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Flying))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Psychic))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Bug))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fairy))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Normal))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Ice))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Rock))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Dark))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness IceAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Water))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Ice))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Grass))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Ground))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Flying))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Ghost))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness ElectricAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Ground))
            return Effectiveness.None;
        if (targetTypes.Contains(PokemonTypes.Electric))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Grass))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Dragon))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Water))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Flying))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness GrassAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Grass))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Poison))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Flying))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Bug))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Dragon))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Water))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Ground))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Rock))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness WaterAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Water))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Grass))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Dragon))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Ground))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Rock))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness FireAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Fire))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Water))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Rock))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Dragon))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Grass))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Ice))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Bug))
            return Effectiveness.Super;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.Super;

        return Effectiveness.Normal;
    }

    private static Effectiveness NormalAttackEffectiveness(PokemonTypes[] targetTypes)
    {
        if (targetTypes.Contains(PokemonTypes.Ghost))
            return Effectiveness.None;
        if (targetTypes.Contains(PokemonTypes.Rock))
            return Effectiveness.NotVery;
        if (targetTypes.Contains(PokemonTypes.Steel))
            return Effectiveness.NotVery;

        return Effectiveness.Normal;
    }

    #endregion
}




