using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Classes_Linking
{
    class Items
    {
        public int itemId { get; set; }
        public string itemName { get; set; }
    }
    class ItemStorage
    {
        public int StorageId { get; set; }
        public string StorageName { get; set; }
        public ItemStorage(int id, string name)
        {
            StorageId = id;
            StorageName = name;
        }
        public Items FindItem(int i)
        {
            Items item = new Items()
            {
                itemId = i,
                itemName = "Iphone"
            };
            return item;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var itemStore = new ItemStorage(22, "Ankit");
            var item = itemStore.FindItem(22);
            Console.WriteLine("Values are : {0} , {1} and {2}", item.itemName, itemStore.StorageName , item.itemId);
        }
    }
}
