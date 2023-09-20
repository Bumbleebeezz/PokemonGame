using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons
{
    public class FirePokemon : Pokemon
    {
        public FirePokemon()
        {
            Type = PokemonTypes.Fire;
        }

        private void Ember()
        {
            Console.WriteLine("Burn bitch!");
        }

        public override void Attack(Pokemon target)
        {
            Ember();
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
