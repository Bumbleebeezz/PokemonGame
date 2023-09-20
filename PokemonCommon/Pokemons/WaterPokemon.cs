using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons
{
    public class WaterPokemon : Pokemon
    {
        public WaterPokemon()
        {
            Type = PokemonTypes.Water;
        }

        private void Bubble()
        {
            Console.WriteLine("Blublublublub");
        }

        public override void Attack(Pokemon pokemon) => Bubble();

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
