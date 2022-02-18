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
    public partial class MenuGame : Form
    {
        Character ch;

        public MenuGame()
        {
            InitializeComponent();
        }

        public MenuGame(Object objCh)
        {
            InitializeComponent();
            ch = (Character)objCh;
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            var inv = new InventoryGame((Object)ch);
            this.Visible = false;
            inv.ShowDialog();
            this.Close();
        }

        private void MenuGame_Load(object sender, EventArgs e) { }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Visible = false;
            menu.ShowDialog();
            this.Close();
        }
    }
}
