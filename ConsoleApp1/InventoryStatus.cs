using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InventoryStatus
    {
        
        public bool InventoryStat { get; set; }
        private bool _inventoryStatus;

        public InventoryStatus(bool invstatus)
        {
            _inventoryStatus = invstatus;
        }

        public bool Inventorystatus(bool inventoryopen)
        {
            if (inventoryopen == true)
            {
                
                InventoryStat = true;
                
                return true;
            }
            else
            {
                InventoryStat = false;
                return false;
            }
        }

    }
}
