
using PokemonCommon.Enums;
using PokemonCommon.Pokemons.Attacks;

namespace PokemonCommon.Pokemons
{
    public class Pokemon
    {
        public Pokemon() { }
        // Every pokemon starts with 100 health points 

        private double _healthPoints = 100;

        // Every pokemon starts with 0 xp
        private int _xp = 0;

        // Get and change xp
        public int XP
        {
            get { return _xp;}
            set { _xp = value; }
        }

        // Get och change health points
        public double HealthPoints
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

        // List of pokemon types
        private List<PokemonTypes> _types = new List<PokemonTypes>();

        // Get and set pokemon type
        public List<PokemonTypes> Types
        {
            get { return _types; }
            set { _types = value; }
        }

        // Every pokemon can have maximum of 4 attacks active
        public Attack[] Attacks { get;} = new Attack[4];

        // Name pokemon and set pokemon type
        public Pokemon(string name, params PokemonTypes[] types)
        {
            _name = name;
            _types = types.ToList();
        }

        public virtual void Attack(Pokemon target) { }

        // 
        public void LearnAttack(Attack attack, int attackIndex)
        {
            if (attackIndex >  3)
            {
               return;  
            }
            if (attack is null)
            {
                return;
            }
            Attacks[attackIndex] = attack;
        }
    }
}
