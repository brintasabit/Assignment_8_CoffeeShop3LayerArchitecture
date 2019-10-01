using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop3LayerArchitecture.Bill;
using CoffeeShop3LayerArchitecture.Model;

namespace CoffeeShop3LayerArchitecture
{
    public partial class Items : Form
    {
        Item _item = new Item();
        ItemManager _itemManager = new ItemManager();
        
        public Items()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            dataGridViewItem.DataSource = _itemManager.ShowItem();
        }
    }
}
