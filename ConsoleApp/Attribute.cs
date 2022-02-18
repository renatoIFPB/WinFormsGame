using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [Serializable]
    class Attribute
    {
        //int Força
        //int Destreza
        //int Agilidade, 
        //int Inteligencia 
        //int Constituição
        public int Strength { get; set; } //aumenta o dano e a chance de bloqueio
        public int Dexterity { get; set; } //aumenta a chance de critico
        public int Agility { get; set; } //aumenta a chance de bloqueio
        public int Intelligence { get; set; } //aumenta a chance de boqueio e de critico
        public int Constitution { get; set; } //aumenta a vida e a regeneração

        public Attribute() { }

        public Attribute(Attribute status)
        {
            Strength = status.Strength;
            Dexterity = status.Dexterity;
            Agility = status.Agility;
            Intelligence = status.Intelligence;
            Constitution = status.Constitution;
        }

        public Attribute(int strength, int dexterity, int agility,
            int intelligence, int constitution)
        {
            Strength = strength;
            Dexterity = dexterity;
            Agility = agility;
            Intelligence = intelligence;
            Constitution = constitution;
        }

        public int CountAttribute()
        {
            return this.Strength + this.Dexterity + this.Agility
                + this.Intelligence + this.Constitution;
        }

        protected void AugmentAttribute(Attribute status)
        {
            Strength += status.Strength;
            Dexterity += status.Dexterity;
            Agility += status.Agility;
            Intelligence += status.Intelligence;
            Constitution += status.Constitution;
        }
        
        protected void ReduceAttribute(Attribute status)
        {
            Strength -= status.Strength;
            Dexterity -= status.Dexterity;
            Agility -= status.Agility;
            Intelligence -= status.Intelligence;
            Constitution -= status.Constitution;
        }

        public string PrintStatus()
        {
            return "\tForça: " + Strength + "\n\tDestreza: " + Dexterity +
                "\n\tAgilidade: " + Agility + "\n\tInteligencia: " + Intelligence
                + "\n\tConstituição: " + Constitution;
        }

    }
}
