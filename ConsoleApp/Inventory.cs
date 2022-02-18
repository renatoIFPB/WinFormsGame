using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [Serializable]
    class Inventory
    {
        private List<Item> Bag = new List<Item>();

        public Inventory() { }

        public Inventory(double weightTotal, Item item) =>
            this.Bag.Add(item);

        public void AddItem(Item item) =>
            this.Bag.Add(item);

        public void RemoveItem(Item item) =>
            this.Bag.Remove(item);

        public override string ToString()
        {
            string tmpString ="";
            foreach (var i in this.Bag)
            {
                tmpString += "\n\t"+i.Name;
            }
            return tmpString;
        }

        public List<Item> GetFullListInventory()
        {
            return this.Bag;
        }

    }
}
