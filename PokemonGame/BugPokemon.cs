using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    internal class BugPokemon : Pokemon
    {
        public BugPokemon() 
        { 
            Type = PokemonTypes.Bug;
        }

        public void BugBite() 
        {
            Console.WriteLine("Bite bite nom nom");
        }
    }
}
