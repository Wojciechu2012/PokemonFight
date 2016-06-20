using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFight
{
    abstract class Pokemon
    {
        private string name;
        public string Name { get { return name; } }

        public float Attack { get; private set; }

        private float hitPoints;
        public float HitPoints { get { return hitPoints; } }

        public string specialSkill { get; protected set; }
        
        
        private PokemonClass clasa;
        public PokemonClass Class { get { return clasa; } }

             

       public Pokemon(PokemonClass clas,int attack,int Hitpoints,string name)
        {
            this.name = name;
            this.clasa = clas;
            this.Attack = attack;
            this.hitPoints = Hitpoints;
        }

        public float normalAttack(Pokemon poke)
        {
            poke.TakeDamage(Attack);
            return Attack;
        }

        public void TakeDamage(float attack)
        {
            hitPoints -= attack;
        }

       public float SpecialAttack(Pokemon poke) {

            float specialAttack = CheckClass(poke);
            poke.TakeDamage(specialAttack * Attack);
            return specialAttack * Attack;
        }
        
        public float CheckClass(Pokemon poke)
        {
            if(this.Class == PokemonClass.Water)
            {
                if(poke.Class == PokemonClass.Water)
                {
                    return 1;
                }
                if (poke.Class == PokemonClass.Fire)
                {
                    return 3;
                }
                if (poke.Class == PokemonClass.Grass)
                {
                    return 0.4f;
                }
            }
            if (this.Class == PokemonClass.Fire)
            {
                if (poke.Class == PokemonClass.Water)
                {
                    return 0.4f;
                }
                if (poke.Class == PokemonClass.Fire)
                {
                    return 1;
                }
                if (poke.Class == PokemonClass.Grass)
                {
                    return 3;
                }
            }
            if (this.Class == PokemonClass.Grass)
            {
                if (poke.Class == PokemonClass.Water)
                {
                    return 3;
                }
                if (poke.Class == PokemonClass.Fire)
                {
                    return 0.4f;
                }
                if (poke.Class == PokemonClass.Grass)
                {
                    return 1;
                }
            }
            return 0;
        }

        public string GetSpecialSkillname()
        {
            return specialSkill;
        }
        
        
    }
}
