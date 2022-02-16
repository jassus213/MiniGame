using ConsoleApp1.Inteface;
using ConsoleApp1.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    public class CraftCommand : ICommands
    {
        public string Cmd => "Craft";
        private Craft _crafter;

        public CraftCommand(Craft crafter)
        {
            _crafter = crafter;
        }

        public bool Process(string arguments)
        {
            if (arguments.Contains(Cmd))
            {
                var result = arguments.Split(" ");
                if (result.Count() == 2)
                {
                    if (Enum.TryParse<GameElements>(result[1], true, out var elementType))
                    {
                        _crafter.CraftItem(elementType);

                    }


                }
                else
                {
                    Console.WriteLine("Команда выглядит неверно");
                }

                return true;

            }
            return false;
        }
    }
}
