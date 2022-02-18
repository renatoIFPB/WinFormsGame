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
    public partial class Market : Form
    {
        Character ch;
        List<Item> itens;
        List<Item> market;

        public Market()
        {
            InitializeComponent();
        }

        public Market(Object objCh)
        {
            listItens.Click += new EventHandler(this.ShowStatusItem);

            InitializeComponent();

            ch = (Character)objCh;
        }
        private void Market_Load(object sender, EventArgs e) { }

        private void ShowStatusItem(object sender, EventArgs e)
        {
            var ind = listItens.SelectedIndex;

            if (ind >= 0 && listItens.CanSelect)
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
        private void ShowStatusMarket(object sender, EventArgs e)
        {
            var ind = listItens.SelectedIndex;

            if (ind >= 0 && listItens.CanSelect)
            {
                valueLevelMarket.Text = itens[ind].Level.ToString();
                valueHpMarket.Text = itens[ind].HpTotal.ToString();
                valueDmgMarket.Text = itens[ind].Damage.ToString();
                valueProtectMarket.Text = itens[ind].Protection.ToString();
                valueStrMarket.Text = itens[ind].Strength.ToString();
                valueDexMarket.Text = itens[ind].Dexterity.ToString();
                valueAgilMarket.Text = itens[ind].Agility.ToString();
                valueIntMarket.Text = itens[ind].Intelligence.ToString();
                valueConstMarket.Text = itens[ind].Constitution.ToString();
            }
        }
    }
}
