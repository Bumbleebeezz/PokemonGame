using PokemonCommon.Pokemons;

namespace PokemonCommon.Trainers
{
    public class Trainer
    {
        public List<Pokemon> PokemonCollection { get; set; } // = new List<Pokemon>();

        public Trainer()
        {
            PokemonCollection = new List<Pokemon>();
        }

        public void Catch(Pokemon pokemon)
        {
            Console.WriteLine(pokemon.Name + " was caught");
            PokemonCollection.Add(pokemon);
        }

        public void MissedCatch(Pokemon pokemon)
        {
            Console.WriteLine($"Failed to catch " + pokemon.Name);
        }

        public void Release(Pokemon pokemon)
        {
            Console.WriteLine(pokemon.Name + " was released");
            PokemonCollection.Remove(pokemon);
        }
    }
}
