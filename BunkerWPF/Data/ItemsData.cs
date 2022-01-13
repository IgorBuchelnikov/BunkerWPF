using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bunker.Models;

namespace Bunker.Data
{
    public class ItemsData
    {
        private ObservableCollection<Item> _savedItems;
        public ObservableCollection<Item> GetAllSavedItems()
        {
            if(_savedItems == null)
            {
                _savedItems = new ObservableCollection<Item>();
                _savedItems.Add(new Item("Яйцо динозавра", "Собственно, сабж", true));
            }
            return _savedItems;
        }
        public void AddNewItem(Item item)
        {
            _savedItems.Add(item);
        }
    }
}
