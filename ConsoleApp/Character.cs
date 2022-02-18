using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [Serializable]
    class Character : SpecificAttribute
    {
        public string Name { get; set; }
        public int HpCurrent { get; private set; }
        public double Experience { get; private set; }
        public int CountAttribute { get; private set; }
        public int Coin { get; private set; }
        private Equipament Equip = new Equipament();
        private Inventory Inventory = new Inventory();
        public string image = "..\\..\\data\\images\\warrior.jpg";
        
        public Character(string name, Attribute status)
        {
            Name = name;
            HpTotal = 30;
            UpLevel();
            this.UpdateAllAttributeByAttribute(status);
            HpCurrent = HpTotal;
        }

        public void AddExperience(double xp)
        {
            Experience += xp;
            CountLevel(Experience);
        }

        public double XpPercent()
        {
            return (this.Experience * 100)/this.XpForUp();
        }

        public void AddAttribute(Attribute status)
        {
            int countTmp = status.CountAttribute();
            if ( countTmp <= CountAttribute )
            {
                this.AugmentAttribute(status);
                CountAttribute -= countTmp;
            }
        }

        private void CountLevel(double xp)
        {
            double countXp = this.XpForUp();

            while (Experience > countXp) {
                UpLevel();
                countXp = Level * 50;
                CountAttribute += 3;
                Experience -= countXp;
                HpCurrent = HpTotal;
            }
        }

        public double XpForUp()
        {
            return (Level + (Level % 3)) * 50;
        }

        public void UndergoDamage(int damage)
        {
            Random numRandom = new Random();
            int damage_tmp = damage - (int)Protection;

            if (damage_tmp > 0 &&
               numRandom.Next(1, 100) > this.statisticForBattle.chanceBlock)
            {
                ReduceHp(damage_tmp);
            }
        }

        public int CalculatorDamage()
        {
            Random numRandom = new Random();
            var tmpDamage = this.Damage;

            if (numRandom.Next(1, 100) <= this.statisticForBattle.chanceCritc)
            {
                tmpDamage += this.Damage;
            }
            return (int)tmpDamage;
        }

        private void ReduceHp(int damage) =>
            HpCurrent -= damage;

        public void EquipItem(Item item)
        {
            Inventory.RemoveItem(item);
            if (item.WeaponTwonHands == 0)
            {
                Item oldArmor = Equip.AddArmor(item);
                
                this.AddAllAttributeByItemSpecificAttribute(
                    this.ConvertItemInSpecificAttribute(item));

                if (oldArmor != null)
                {
                    Inventory.AddItem(oldArmor);
                    this.RemoveAllAttributeByItemSpecificAttribute(
                        this.ConvertItemInSpecificAttribute(oldArmor));
                }
                return;
            }
            List<Item> oldWeapon = Equip.AddWeapon(item);
            Console.WriteLine("-------------------");
            foreach (var oldItem in oldWeapon)
            {
                this.AddAllAttributeByItemSpecificAttribute(
                        this.ConvertItemInSpecificAttribute(oldItem));
                if (oldItem.Name != "Void")
                {
                    Console.WriteLine("Item = " + oldItem.Name);
                    Inventory.AddItem(oldItem);
                    this.RemoveAllAttributeByItemSpecificAttribute(
                    this.ConvertItemInSpecificAttribute(oldItem));
                }
            }
            Console.WriteLine("-------------------");
        }

        private SpecificAttribute ConvertItemInSpecificAttribute(Item item)
        {
            return new SpecificAttribute(item);
        }

        public void AddItemInInventory(Item item) =>
            Inventory.AddItem(item);

        public void RemoveItemFromInvetory(Item item) =>
            Inventory.RemoveItem(item);

        public string GetStringListInventory()
        {
            return Inventory.ToString();
        }

        public string GetStringOfListEquip()
        {
            return Equip.ToString();
        }

        public List<Item> GetListEquip()
        {
            return Equip.GetFullListEquip();
        }
        public List<Item> GetListInventory()
        {
            return Inventory.GetFullListInventory();
        }
    }
}
