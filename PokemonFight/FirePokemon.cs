using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFight
{
    class FirePokemon : Pokemon
    {
        
        public FirePokemon() : base(PokemonClass.Fire,10, 50, "Charmander")
        {
            specialSkill = "Flame";
        }
      

       
    }
}
