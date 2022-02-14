using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inteface
{
    interface ICommands
    {
        string Cmd { get; }
        bool Process(string arguments);
    }
}
