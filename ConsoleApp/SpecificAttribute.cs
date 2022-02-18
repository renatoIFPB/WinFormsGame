using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [Serializable]
    class SpecificAttribute : Attribute
    {
        public int Level { get; protected set; }
        public int HpTotal { get; protected set; }
        public double Damage { get; protected set; }
        public double Protection { get; protected set; } // Diminui o dano recebido
        public StatisticForBattle statisticForBattle { get; set; }

        public SpecificAttribute() { }

        public SpecificAttribute(Attribute status) : base(status) { }

        public SpecificAttribute(Item item) : base(item.Strength,
            item.Dexterity, item.Agility, item.Intelligence, item.Constitution)
        {
            this.HpTotal = item.HpTotal;
            this.Damage = item.Damage;
            this.Protection = item.Protection;
        }

        protected void UpLevel()
        {
            Level++;
            HpTotal += Level * 10;
        }

        protected void UpdateAllAttributeByAttribute(Attribute status)
        {
            Damage += status.Strength * 1;
            HpTotal += status.Constitution * 3;
            Protection += status.Constitution * 0.5;

            this.AugmentAttribute(status);
        }

        protected void DecreaseAllAttributeByAttribute(Attribute status)
        {
            Damage -= status.Strength * 2;
            HpTotal -= status.Constitution * 3;
            Protection -= status.Constitution;

            this.ReduceAttribute(status);
        }

        protected void AddAllAttributeByItemSpecificAttribute(SpecificAttribute status)
        {
            this.UpdateAllAttributeByAttribute(status);
            Damage += status.Damage;
            HpTotal += status.HpTotal;
            Protection += status.Protection;
        }

        protected void RemoveAllAttributeByItemSpecificAttribute(SpecificAttribute status)
        {
            this.DecreaseAllAttributeByAttribute(status);
            Damage -= status.Damage;
            HpTotal -= status.HpTotal;
            Protection -= status.Protection;
        }

        private void ChanceCritic(Attribute statusEnimy, double myChanceInt, double enemyChanceInt)
        {
            double totalChance = (this.Dexterity + statusEnimy.Dexterity)
                + ((this.Agility + statusEnimy.Agility) / 2);

            int totalThis = this.Dexterity + (this.Agility / 2);

            double criticPorcent = (totalThis * 100) / totalChance;

            double tmpMyChance = (criticPorcent * myChanceInt) / 100;
            double tmpEnemyChance = (criticPorcent * enemyChanceInt) / 100;

            statisticForBattle.chanceCritc = criticPorcent - tmpEnemyChance + tmpMyChance;
        }

        private void ChanceBlock(Attribute statusEnemy, double myChanceInt, double enemyChanceInt)
        {
            double totalChance = (this.Agility + statusEnemy.Agility)
                + ((this.Strength + statusEnemy.Strength)/2);

            int totalThis = this.Agility + (this.Strength / 2);

            double blockPorcent = (totalThis * 100) / totalChance;

            double tmpMyChance = (blockPorcent * myChanceInt) / 100;
            double tmpEnemyChance = (blockPorcent * enemyChanceInt) / 100;

            statisticForBattle.chanceBlock = blockPorcent - tmpEnemyChance + tmpMyChance;
        }

        private double MyChanceIntelligence(Attribute statusEnemy)
        {
            double totalChance = this.Intelligence + statusEnemy.Intelligence;
            return (this.Intelligence * 100) / totalChance;
        }

        private double EnemyChanceIntelligence(Attribute statusEnemy)
        {
            double totalChance = this.Intelligence + statusEnemy.Intelligence;
            return (statusEnemy.Intelligence * 100) / totalChance;
        }

        public void CalculatorChanceToBattle(Attribute statusEnemy)
        {
            double myChanceInt = this.MyChanceIntelligence(statusEnemy);
            double enemyChanceInt = this.MyChanceIntelligence(statusEnemy);

            this.ChanceCritic(statusEnemy, myChanceInt, enemyChanceInt);
            this.ChanceBlock(statusEnemy, myChanceInt, enemyChanceInt);
        }
    }
}
