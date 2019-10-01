using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop3LayerArchitecture.Repository;
namespace CoffeeShop3LayerArchitecture.Bill
{
    class ItemManager
    {
        ItemRepository _itemRepository=new ItemRepository();
        public DataTable ShowItem()
        {
            return _itemRepository.ShowItem();
        }
    }
}
