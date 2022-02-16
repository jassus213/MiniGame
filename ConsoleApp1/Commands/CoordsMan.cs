using ConsoleApp1.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    class CoordsMan : ICommands
    {
        private Man _man;



        public CoordsMan(Man man)
        {
            _man = man;
        }
        public string Cmd => "coord";

        public bool Process(string arguments)
        {
            if (arguments == Cmd)
            {
                int x = _man.X;
                int y = _man.Y;

                var result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                Console.WriteLine(Math.Round(result, 1));
                return true;
            }
            return false;
        }
    }
}
