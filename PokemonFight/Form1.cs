using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonFight
{
    public partial class Form1 : Form
    {
        EnemyPokemon enemy = new EnemyPokemon();
        Game game = new Game();
        Pokemon poke;
        public Form1()
        {
            InitializeComponent();
            UpdateForm();
         }

    

       

        private void MyAttackNormalButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = game.Attack(poke, enemy, AttackSkills.NormalAttack);
            
            UpdateForm();
        }

      


        public void Onoffpoketypebuttons()
        {
            if (poketypelabel.Visible == true)
            {
                poketypelabel.Visible = false;
                Pokemon1.Visible = false;
                Pokemon3.Visible = false;
                Pokemon2.Visible = false;
            }else
            {
                poketypelabel.Visible = true;
                Pokemon1.Visible = true;
                Pokemon3.Visible = true;
                Pokemon2.Visible = true;
            }


        }

        private void Pokemon1_Click(object sender, EventArgs e)
        {
            poke = new FirePokemon();
            PickPokemon();

            MyAttackSpecialButton.Text = poke.GetSpecialSkillname();
        }

        private void Pokemon2_Click(object sender, EventArgs e)
        {
            poke = new WaterPokemon();
            PickPokemon();    
          
            MyAttackSpecialButton.Text = poke.GetSpecialSkillname();
        }

        private void Pokemon3_Click(object sender, EventArgs e)
        {
            poke = new GrassPokemon();
            PickPokemon();      
            MyAttackSpecialButton.Text = poke.GetSpecialSkillname();
        }

        private void MyAttackSpecialButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = game.Attack(poke, enemy, AttackSkills.SpecialSkill);

            UpdateForm();
        }


        public void PickPokemon()
        {
            textBox1.Text = "";
            MyAttackNormalButton.Text = "Normal attack";
            enemy = new EnemyPokemon();
            Onoffpoketypebuttons();
            UpdateForm();
        }


        public void UpdateForm()
        {

            if (poke != null)
            {
                EnemyPokemonLabel.Text = game.setPokeLabel(enemy);
                MyPokemonLabel.Text = game.setPokeLabel(poke);
                MyAttackNormalButton.Visible = true;
                MyAttackSpecialButton.Visible = true;
                if (poke.HitPoints <= 0)
                {
                    MyAttackNormalButton.Visible = false;
                    MyAttackSpecialButton.Visible = false;
                    textBox1.Text += "\r\n Wygrał " + enemy.Name;
                    Onoffpoketypebuttons();
                }
                if (enemy.HitPoints <= 0)
                {
                    MyAttackNormalButton.Visible = false;
                    MyAttackSpecialButton.Visible = false;
                    textBox1.Text += "\r\n Wygrał " + poke.Name;
                    Onoffpoketypebuttons();
                }

            }


        }



    }
}
