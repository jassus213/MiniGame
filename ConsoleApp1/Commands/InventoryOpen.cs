using ConsoleApp1.Inteface;
using ConsoleApp1.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InventoryOpen : ICommands
    {
        private UserElements _items;
        
       


        public InventoryOpen(UserElements items)
        {
            _items = items;
            
        }

        public string Cmd => "inv";

        public void OpenProcess(GameItems gameitems)
        {
           
        }
        
        public bool Process(string arguments)
        {

            if (Cmd == arguments)
            {
                var allitems = _items.Elements;
                foreach (var itemid in allitems)
                {
                    Console.WriteLine($"Имеется: {itemid.Key}, в количестве {itemid.Value}");
                }

                return true;
            }
            return false;
            
        }

       

    }
}
