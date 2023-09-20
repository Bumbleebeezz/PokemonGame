using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons
{
    public class RockPokemon : Pokemon
    {
        public RockPokemon()
        {
            Type = PokemonTypes.Rock;
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }

        public override void Attack(Pokemon pokemon) => RockThrow();

        private void RockThrow()
        {
            Console.WriteLine("Rock slam");
        }
    }
}
