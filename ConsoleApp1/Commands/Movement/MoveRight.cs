using ConsoleApp1.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    class MoveRight : ICommands
    {

        private IMovavable _man;
        private InventoryStatus _invStatus;


        public string Cmd => "d";

        public MoveRight(IMovavable man, InventoryStatus inventoryStatus)
        {
            _man = man;
            _invStatus = inventoryStatus;
        }


        public bool Process(string msg)
        {


            if (msg == Cmd)
            {
                if (_invStatus.InventoryStat == false)
                {
                    _man.Move(+1, 0);
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