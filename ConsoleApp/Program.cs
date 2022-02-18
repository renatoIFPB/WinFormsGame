using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp.Windows;
using Menu = ConsoleApp.Windows.Menu;

namespace ConsoleApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //var rwFile = new ReadWriteFile();
            //var lista = new List<Character>();

            //var status1 = new Attribute(20, 20, 20, 20, 20);
            //var status2 = new Attribute(10, 10, 10, 10, 10);
            //var ch1 = new Character("renato", status1);
            //var ch2 = new Character("summuner", status2);

            //string path = "..\\..\\data\\characters.txt";

            //rwFile.WriteCharacter(path, ch1);
            //rwFile.WriteCharacter(path, ch2);
            //var listaFinal = rwFile.ReadListCharacter(path);

            //foreach (var ch in listaFinal)
            //{
            //    Console.WriteLine("a: " + ch.Name);
            //}

            //Console.ReadLine();

            Application.EnableVisualStyles();
            Application.Run(new Menu());
        }

        public void testando()
        {
            var itemStatus = new Attribute(1, 1, 1, 1, 1);
            var armorStatus1 = new Attribute(10, 10, 10, 10, 10);
            var armorStatus2 = new Attribute(3, 3, 3, 3, 3);
            var armorStatus3 = new Attribute(5, 5, 5, 5, 5);
            var status = new Attribute(20, 20, 20, 20, 20);

            var itemEquip1 = new Item("espada longa", 20, 5, 7, "sword-dual", 2, itemStatus);
            var itemEquip2 = new Item("espada curta", 10, 0, 1, "sword", 1, itemStatus);
            var itemEquip3 = new Item("escudo pequeno", 0, 10, 1, "shild", 1, armorStatus2);
            var itemArmor1 = new Item("Armadura pessada", 0, 40, 7, "armor", 0, armorStatus1);
            var itemArmor2 = new Item("Armadura media", 0, 11, 1, "armor", 0, armorStatus2);
            var itemArmor3 = new Item("Calça media", 0, 7, 2, "legs", 0, armorStatus3);

            var isso = new Character("É isso", status);

            Console.WriteLine("\nNome: " + isso.Name + "\nLevel: " + isso.Level
                + "\nExperiencia: " + isso.Experience + "\nDano: " + isso.Damage
                + "\nDefesa:" + isso.Protection + "\nVida" + isso.HpTotal
                + "\nPontos de status: " + isso.CountAttribute + "\nStatus:\n"
                + isso.PrintStatus() + "\nInventario:" + isso.GetStringListInventory()
                + "\nEquipamentos:" + isso.GetStringOfListEquip());

            //isso.EquipItem(itemEquip1);

            isso.EquipItem(itemEquip2);
            isso.EquipItem(itemEquip3);

            //isso.EquipItem(itemArmor1);

            isso.EquipItem(itemArmor2);
            isso.EquipItem(itemArmor3);

            //atributos 12+

            isso.AddItemInInventory(itemArmor1);
            isso.AddItemInInventory(itemEquip1);
            //isso.AddItemInInventory(itemEquip2);
            //isso.AddItemInInventory(itemEquip3);
            //isso.RemoveItemFromInvetory(itemEquip1);
            isso.EquipItem(itemEquip1);

            isso.AddExperience(300);
            var augmentStatus = new Attribute(2, 2, 0, 0, 2);
            //isso.AddAttribute(augmentStatus);

            Console.WriteLine("\nNome: " + isso.Name + "\nLevel: " + isso.Level
                + "\nExperiencia: " + isso.Experience + "\nDano: " + isso.Damage
                + "\nDefesa:" + isso.Protection + "\nVida" + isso.HpTotal
                + "\nPontos de status: " + isso.CountAttribute + "\nStatus:\n"
                + isso.PrintStatus() + "\nInventario:" + isso.GetStringListInventory()
                + "\nEquipamentos:" + isso.GetStringOfListEquip());

            Console.WriteLine("teste=" + (int)102.10);

            Console.ReadLine();
        }
    }
}
