using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    internal class FirePokemon : Pokemon
    {
        public FirePokemon()
        {
            Type = PokemonTypes.Fire;
        }

        public void Ember() 
        {
            Console.WriteLine("Burn bitch!");
        }
    }
}
