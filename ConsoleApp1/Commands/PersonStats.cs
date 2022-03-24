using ConsoleApp1.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    public class PersonStats : ICommands
    {
        public string Cmd => "stats";
        private Man _man;
        public PersonStats(Man man)
        {
            _man = man;
        }

        public bool Process(string arguments)
        {
            if (Cmd == arguments)
            {
                Console.WriteLine($"ManStats: Рост {_man.Growth} Вес {_man.Weight} Здоровье {_man.Health}");
                Console.WriteLine($"Местоположеине: {_man.X} {_man.Y}");
                return true;


            }
            return false;
        }
    }
}
