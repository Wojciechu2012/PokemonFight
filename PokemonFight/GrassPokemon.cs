using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFight
{
    class GrassPokemon : Pokemon
    {
        public GrassPokemon() : base(PokemonClass.Grass, 15, 30, "Grass")
        {
            specialSkill = "Leaf";
        }
    }
}
