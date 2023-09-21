using PokemonCommon.Enums;

namespace PokemonCommon;

public class BattleUi
{
    private static Dictionary<Effectiveness, string> messages = new Dictionary<Effectiveness, string>()
    {
        {  Effectiveness.None , "It has no effect!" },
        { Effectiveness.NotVery, "It was not very effective...." },
        { Effectiveness.Normal, ""},
        { Effectiveness.Super , "It was super effective!"}
    };

    public static void DisplayAttackEffectiveness(Effectiveness effectiveness, string attackName, string attacker)
    {
        Console.WriteLine($"{attacker} used {attackName}! {messages[effectiveness]}");
    }
}