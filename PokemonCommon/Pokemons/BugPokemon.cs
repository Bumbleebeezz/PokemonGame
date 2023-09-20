using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons
{
    public class BugPokemon : Pokemon
    {
        public BugPokemon()
        {
            Type = PokemonTypes.Bug;
        }

        public override void Attack(Pokemon pokemon) => BugBite();

        private void BugBite()
        {
            Console.WriteLine("Bite bite nom nom");
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
