using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp.Windows
{
    public partial class InventoryGame : Form
    {
        Character ch;
        List<Item> itens;
        List<Item> equips;

        public InventoryGame() => 
            InitializeComponent();

        public InventoryGame(Object objCh)
        {
            InitializeComponent();
            listEquip.Click += new EventHandler(this.ShowStatusEquip);
            listInventory.Click += new EventHandler(this.ShowStatusItem);

            ch = (Character)objCh;
            pictureCharacter.Image = Image.FromFile(ch.image);
            this.DefineLevelArea();
            this.DefineAttributeArea();
            this.DefineHpArea();

            this.AttLists();
        }

        private void AttLists()
        {
            listEquip.Items.Clear();
            listInventory.Items.Clear();
            equips = ch.GetListEquip();
            foreach (var item in equips)
            {
                listEquip.Items.Add(item.Name);
            }
            itens = ch.GetListInventory();
            foreach (var item in itens)
            {
                listInventory.Items.Add(item.Name);
            }
        }

        private void ShowStatusEquip(object sender, EventArgs e)
        {
            var ind = listEquip.SelectedIndex;

            if (ind >= 0 && listEquip.CanSelect)
            {
                valueLevelEquip.Text = equips[ind].Level.ToString();
                valueHpEquip.Text = equips[ind].HpTotal.ToString();
                valueDmgEquip.Text = equips[ind].Damage.ToString();
                valueProtectEquip.Text = equips[ind].Protection.ToString();
                valueStrEquip.Text = equips[ind].Strength.ToString();
                valueDexEquip.Text = equips[ind].Dexterity.ToString();
                valueAgilEquip.Text = equips[ind].Agility.ToString();
                valueIntEquip.Text = equips[ind].Intelligence.ToString();
                valueConstEquip.Text = equips[ind].Constitution.ToString();
            }
        }
        private void ShowStatusItem(object sender, EventArgs e)
        {
            var ind = listInventory.SelectedIndex;

            if (ind >=0 && listInventory.CanSelect)
            {
                valueLevelItem.Text = itens[ind].Level.ToString();
                valueHpItem.Text = itens[ind].HpTotal.ToString();
                valueDmgItem.Text = itens[ind].Damage.ToString();
                valueProtectItem.Text = itens[ind].Protection.ToString();
                valueStrItem.Text = itens[ind].Strength.ToString();
                valueDexItem.Text = itens[ind].Dexterity.ToString();
                valueAgilItem.Text = itens[ind].Agility.ToString();
                valueIntItem.Text = itens[ind].Intelligence.ToString();
                valueConstItem.Text = itens[ind].Constitution.ToString();
            }
        }

        private void DefineLevelArea()
        {
            level.Text = ch.Level.ToString();
            progressXp.Value = (int)ch.XpPercent();
            percent.Text = ch.XpPercent().ToString() + " %";
        }

        private void DefineAttributeArea()
        {
            valueStrength.Text = ch.Strength.ToString();
            valueDexterity.Text = ch.Dexterity.ToString();
            valueAgility.Text = ch.Agility.ToString();
            valueIntelligence.Text = ch.Intelligence.ToString();
            valueConstitution.Text = ch.Constitution.ToString();
        }

        private void DefineHpArea()
        {
            var hpCurrent = ch.HpCurrent;
            var hpTotal = ch.HpTotal;

            valueTotalHp.Text = hpCurrent.ToString() + " / " + hpTotal.ToString();
            progressHp.Value = (hpCurrent * 100) / hpTotal;
        }

        private void buttonEquipItem_Click(object sender, EventArgs e)
        {
            var ind = listEquip.SelectedIndex;

            if (ind >= 0 && listEquip.CanSelect)
            {
                ch.EquipItem(itens[ind]);
                this.AttLists();
            }
        }

        private void InventoryGame_Load(object sender, EventArgs e) { }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var menuGame = new MenuGame();
            this.Visible = false;
            menuGame.ShowDialog();
            this.Close();
        }
    }
}
