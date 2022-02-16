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


        public string Cmd => "w";

        public TopMove(IMovavable man)
        {
            _man = man;
        }


        public bool Process(string msg)
        {


            if (msg == Cmd)
            {
                _man.Move(0, +1);
                return true;
            }
            return false;
        }
    }
}
