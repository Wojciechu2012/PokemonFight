using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFight
{
    class Game
    {
      
        Random rand = new Random();

        public string setPokeLabel(Pokemon poke)
        {
            return poke.Name+"\n" + "Pokemon typ : " + poke.Class + "\nPosiada " + poke.HitPoints + "HP";
         }


        public string Attack(Pokemon poke1,Pokemon poke2,AttackSkills skills)
        {
            float topoke1, topoke2;

            if (skills == AttackSkills.NormalAttack)
            {
               topoke2=poke1.normalAttack(poke2);
            }
            else
             topoke2=poke1.SpecialAttack(poke2);

            int i = rand.Next(2);
            if (i == 1)
            {
                topoke1 = poke2.normalAttack(poke1);
            }
            else
                topoke1 = poke2.SpecialAttack(poke1);

            string poke1attack = "Pokemon " + poke1.Name + "\r\nzadał " + topoke2 + " obrażeń pokemonowi " + poke2.Name + "\r\n" +
                "---------------------------------------------------"; 
            string poke2attack = "\r\nPokemon " + poke2.Name + "\r\nzadał " + topoke1 + " obrażeń pokemonowi " + poke1.Name + "\r\n" +
                "---------------------------------------------------"; ;

            return poke1attack + poke2attack;

            
        }
    }
}
