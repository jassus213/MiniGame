using ConsoleApp1.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{

    public class InventoryClose : ICommands
    {
        private UserElements _items;
        private InventoryStatus _inventoryStatus;




        public InventoryClose(UserElements items, InventoryStatus inventoryStatus)
        {
            _items = items;
            _inventoryStatus = inventoryStatus;

        }

        public string Cmd => "inv_close";



        public bool Process(string arguments)
        {

            
           
            
            if (Cmd == arguments)
            {
                if (_inventoryStatus.InventoryStat == true)
                {

                    _inventoryStatus.InventoryStat = false;
                    
                    
                    

                    Console.WriteLine("Инвентарь Закрыт");
                }
                else
                {
                    Console.WriteLine("Инвентарь и так закрыт");
                }



                return true;
            }
            return false;

        }



    }

}
