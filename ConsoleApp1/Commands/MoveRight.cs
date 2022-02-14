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


        public string Cmd => "s";

        public MoveRight(IMovavable man)
        {
            _man = man;
        }


        public bool Process(string msg)
        {


            if (msg == "s")
            {
                _man.Move(+1, 0);
                return true;
            }
            return false;
        }
    }
}