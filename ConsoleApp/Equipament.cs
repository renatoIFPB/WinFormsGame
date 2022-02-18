using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [Serializable]
    class Equipament
    {
        private List<Item> Armor = new List<Item>();
        private List<Item> Weapon = new List<Item>();

        public Equipament()
        {
            var itemStatus = new Attribute(0, 0, 0, 0, 0);
            var itemEquip = new Item("Punhos", 0, 0, 0, "punhos", 2, itemStatus);
            Weapon.Add(itemEquip);
        }

        public Item AddArmor(Item item)
        {
            var tmpArmor = new List<Item>(Armor);
            foreach (var i in tmpArmor)
            {
                if (i.Type == item.Type)
                {
                    Armor.Remove(i);
                    Armor.Add(item);
                    return i;
                }   
            }
            Armor.Add(item);
            return null;
        }

        public List<Item> AddWeapon(Item item)
        {
            var oldWeapon = new List<Item>(Weapon);
            var tmpWeapon = new List<Item>(Weapon);
            if (item.WeaponTwonHands == 1)
            {
                foreach (var i in tmpWeapon)
                {
                    if (i.Type == item.Type || i.WeaponTwonHands == 2)
                      {
                        Weapon.Remove(i);
                        Weapon.Add(item);

                        oldWeapon.Clear();
                        oldWeapon.Add(i);

                        return oldWeapon;
                    }
                }
                Weapon.Add(item);
                return this.NewItemVoid();
            }
            Weapon.Clear();
            Weapon.Add(item);
            
            return oldWeapon;
        }

        public override string ToString()
        {
            string tmpString = "";
            
            foreach (var i in Weapon)
            {
                tmpString += "\n\t" + i.Name;
            }
            foreach (var i in Armor)
            {
                tmpString += "\n\t" + i.Name;
            }
            return tmpString;
        }

        public List<Item> GetFullListEquip()
        {
            var listFull = new List<Item>(Armor);
            foreach (var item in Weapon)
            {
                listFull.Add(item);
            }

            return listFull;
        }
    
        private List<Item> NewItemVoid()
        {
            var itemStatus = new Attribute(0, 0, 0, 0, 0);
            var itemEquip = new Item("Void", 0, 0, 0, "void", 2, itemStatus);
            List<Item> tmpListVoid = new List<Item>();
            tmpListVoid.Add(itemEquip);

            return tmpListVoid;
        }
    }
}
