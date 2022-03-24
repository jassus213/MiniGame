using ConsoleApp1.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TopMove : ICommands
    {

        private IMovavable _man;
        private InventoryStatus _invStatus;


        public string Cmd => "w";

        public TopMove(IMovavable man, InventoryStatus invStatus)
        {
            _man = man;
            _invStatus = invStatus;
        }


        public bool Process(string msg)
        {


            if (msg == Cmd)
            {
                if (_invStatus.InventoryStat == false)
                {
                    _man.Move(0, +1);
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
