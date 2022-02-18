using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [Serializable]
    class Item : SpecificAttribute
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public int WeaponTwonHands { get; set; }

        public Item(Item item, Attribute status) : base(status)
        {
            Name = item.Name;
            Price = item.Price;
            Type = item.Type;
            WeaponTwonHands = item.WeaponTwonHands;
        }

        public Item(string name, double damage, double protection, double price,
            string type, int weaponTwonHands, Attribute status) : base(status)
        {
            Name = name;
            Damage = damage;
            Protection = protection;
            Price = price;
            Type = type;
            WeaponTwonHands = weaponTwonHands;
        }
    }
}
