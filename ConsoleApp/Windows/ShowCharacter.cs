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
    public partial class ShowCharacter : Form
    {
        public ShowCharacter()
        {
            InitializeComponent();
            ListCharacters.Items.Clear();
            ListCharacters.Click += new EventHandler(this.ShowStatus);
            
            var readFile = new ReadWriteFile();
            var listCh = readFile.ReadListCharacter("..\\..\\data\\characters.txt");

            foreach (var ch in listCh)
            {
                ListCharacters.Items.Add(ch.Name + "      " + ch.Level);
            }
        }

        private void ListCharacter_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Back_Click(object sender, EventArgs e) 
        {
            var menu = new Menu();
            this.Visible = false;
            menu.ShowDialog();
            this.Close();
        }

        private void ShowStatus(object sender, EventArgs e)
        {
            var ind = ListCharacters.SelectedIndex;
            if (ind >= 0 && ListCharacters.CanSelect)
            {
                var ch = ReadFileReturnCharacterIndex(ind);

                valueStrength.Text = ch.Strength.ToString();
                valueAgility.Text = ch.Agility.ToString();
                valueDexterity.Text = ch.Dexterity.ToString();
                valueIntelligence.Text = ch.Intelligence.ToString();
                valueConstitution.Text = ch.Constitution.ToString();
                valueHp.Text = ch.HpCurrent.ToString();
                valueExperience.Text = ch.Experience.ToString();
                valueCoin.Text = ch.Coin.ToString();
            }
        }

        private Character ReadFileReturnCharacterIndex(int ind)
        {
            var readFile = new ReadWriteFile();
            var listCh = readFile.ReadListCharacter("..\\..\\data\\characters.txt");

            return listCh[ind];
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void Itens_Click(object sender, EventArgs e) { }

        private void play_Click(object sender, EventArgs e)
        {
            var ind = ListCharacters.SelectedIndex;
            if (ind >= 0 && ListCharacters.CanSelect)
            {
                var ch = ReadFileReturnCharacterIndex(ind);
                var inv = new MenuGame((Object)ch);
                this.Visible = false;
                inv.ShowDialog();
                this.Close();
            }
        }

        private void ShowCharacter_Load(object sender, EventArgs e) { }
    }
}
