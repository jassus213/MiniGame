using ConsoleApp1.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    public class HealPerson : ICommands
    {
        public string Cmd => "heal";
        private Man _man;

        public HealPerson(Man man)
        {
            _man = man;
        }

        public bool Process(string arguments)
        {
            if (Cmd == arguments)
            {
                
                    
                    var health = _man.Health;
                    _man.Regeneration(health);
                    Console.WriteLine($"Ваше здоровье {_man.Health}");
                    return true;

                  
                    
            }
            return false;
        }
    }
}
