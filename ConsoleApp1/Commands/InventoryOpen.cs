using ConsoleApp1.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{

    public class InventoryOpen : ICommands
    {
        


        private UserElements _items;
        private InventoryStatus _inventoryStat;



        public InventoryOpen(UserElements items, InventoryStatus inventoryStatus)
        {
            _items = items;
            _inventoryStat = inventoryStatus;

        }

        public string Cmd => "inv_open";



        public bool Process(string arguments)
        {

            
            
            

            if (Cmd == arguments)
            {

                if (_inventoryStat.InventoryStat == false)
                {
                    
                    _inventoryStat.InventoryStat = true;
                    
                    
                    
                    var allItemsUser = _items.Elements;
                    foreach (var itemid in allItemsUser)
                    {
                        Console.WriteLine($"Имеется: {itemid.Key}, в количестве {itemid.Value}");




                    }
                }
                else
                {
                    Console.WriteLine("Инвентарь и так открыт");
                }



                return true;
            }
            return false;

        }



    }

}
