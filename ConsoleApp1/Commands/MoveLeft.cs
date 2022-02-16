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


        public string Cmd => "a";

        public MoveLeft(IMovavable man)
        {
            _man = man;
        }


        public bool Process(string msg)
        {


            if (msg == Cmd)
            {
                _man.Move(-1, 0);
                return true;
            }
            return false;
        }
    }
}
