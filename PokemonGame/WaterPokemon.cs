using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon()
        {
            Type = PokemonTypes.Water;
        }

        public void Bubble() 
        {
            Console.WriteLine("Blublublublub");
        }
    }
}
