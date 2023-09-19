using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    internal class RockPokemon : Pokemon
    {
        public RockPokemon() 
        { 
            Type = PokemonTypes.Rock;
        }

        public void RockThrow() 
        {
            Console.WriteLine("Rock slam");
        }
    }
}
