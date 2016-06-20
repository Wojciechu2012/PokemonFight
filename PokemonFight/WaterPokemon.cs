using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFight
{
    class WaterPokemon : Pokemon
    {
        public WaterPokemon() : base(PokemonClass.Water, 10, 50, "Water")
        {
            specialSkill = "Water";
        }
    }
}
