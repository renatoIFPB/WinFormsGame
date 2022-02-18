using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp.Windows
{
    [Serializable]
    public partial class CreateCharacter : Form
    {
        private int MaximumAttributes = 20;

        public CreateCharacter() => 
            InitializeComponent();

        private void CreateCharacter_Load(object sender, EventArgs e) { }

        private void Cancel_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Visible = false;
            menu.ShowDialog();
            this.Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            var rwFile = new ReadWriteFile();
            var character = new Character(NewName.Text, this.CreateAttribute());
            this.AddItem(character);
            rwFile.WriteCharacter("..\\..\\data\\characters.txt", character);
            this.Close();
        }

        private Attribute CreateAttribute()
        {
            var attribute = new Attribute((int)StrengthValue.Value, (int)DexterityValue.Value,
                (int)AgilityValue.Value, (int)IntelligenceValue.Value, (int)ConstitutionValue.Value);
            return attribute;
        }

        private void NewName_TextChanged(object sender, EventArgs e) { }

        private void Name_Click(object sender, EventArgs e) { }

        private void StrengthValue_ValueChanged(object sender, EventArgs e) =>
            ControlerIncreaseAttribute();

        private void DexterityValue_ValueChanged(object sender, EventArgs e) =>
            ControlerIncreaseAttribute();

        private void AgilityValue_ValueChanged(object sender, EventArgs e) =>
            ControlerIncreaseAttribute();

        private void IntelligenceValue_ValueChanged(object sender, EventArgs e) =>
            ControlerIncreaseAttribute();

        private void ConstitutionValue_ValueChanged(object sender, EventArgs e) =>
            ControlerIncreaseAttribute();

        private void ControlerIncreaseAttribute()
        {
            CountAttributes.Text = MaximumAttributes.ToString();
            int tmp = TotalAttributesIncrease();
            CountAttributes.Text = (MaximumAttributes - tmp).ToString();
            if (TotalAttributesIncrease() >= MaximumAttributes)
            {
                StrengthValue.Maximum = StrengthValue.Value;
                DexterityValue.Maximum = DexterityValue.Value;
                AgilityValue.Maximum = AgilityValue.Value;
                IntelligenceValue.Maximum = IntelligenceValue.Value;
                ConstitutionValue.Maximum = ConstitutionValue.Value;
            }
            else
            {
                StrengthValue.Maximum += 1;
                DexterityValue.Maximum += 1;
                AgilityValue.Maximum += 1;
                IntelligenceValue.Maximum += 1;
                ConstitutionValue.Maximum += 1;
            }
        }
        private int TotalAttributesIncrease()
        {
            int tmp = 0;
            tmp += (int)StrengthValue.Value;
            tmp += (int)DexterityValue.Value;
            tmp += (int)AgilityValue.Value;
            tmp += (int)IntelligenceValue.Value;
            tmp += (int)ConstitutionValue.Value;

            return tmp;
        }
        private void Constitution_Click(object sender, EventArgs e) { }

        private void Intelligence_Click(object sender, EventArgs e) { }

        public void AddItem(Object obj)
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

            var ch = (Character)obj;

            ch.AddItemInInventory(itemEquip2);
            ch.AddItemInInventory(itemEquip3);
            ch.AddItemInInventory(itemArmor1);
            ch.EquipItem(itemEquip1);
            ch.EquipItem(itemArmor2);
            ch.EquipItem(itemArmor3);

        }
    }
}
