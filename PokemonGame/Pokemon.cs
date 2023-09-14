using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Pokemon
    {
        // Every pokemon starts with 100 health points
        private int _healthPoints = 100;

        // Get och change health points
        public int HealthPoints
        {
            get { return _healthPoints; }
            set { _healthPoints = value; }
        }

        // Get and set the name of a pokemon
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Get and set pokemon type
        private PokemonTypes _type;

        public PokemonTypes Type
        {
            get { return _type; }
            set { _type = value; }
        }

        // Name pokemon and set pokemon type
        public Pokemon(string name, PokemonTypes type)
        {
            _name = name;
            _type = type;
        }

        public static void Attack(Pokemon target)
        {
            target.HealthPoints -= 10;
            Console.WriteLine("Attacks " + target.Name);
        }
    }
}
