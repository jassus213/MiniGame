using ConsoleApp1.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    class MoveLeft : ICommands
    {

        private IMovavable _man;
        private InventoryStatus _inventoryStatus;


        public string Cmd => "a";

        public MoveLeft(IMovavable man, InventoryStatus inventoryStatus)
        {
            _man = man;
            _inventoryStatus = inventoryStatus;
        }


        public bool Process(string msg)
        {


            if (msg == Cmd)
            {
                if (_inventoryStatus.InventoryStat == false)
                {
                    _man.Move(-1, 0);
                    return true;

                }
                else
                {
                    Console.WriteLine("Вы не можете это сделать, т.к открыт инвентарь.");
                    return false;
                }
                
            }
            return false;
        }
    }
}
