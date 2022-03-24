using ConsoleApp1.Inteface;
using ConsoleApp1.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    class CanCraft : ICommands
    {
        private UserElements _userItems;
        private GameItem[] _craftableElements;
        private CraftTable _craftTable;
        
        
        public string Cmd => "variants";

        public CanCraft(UserElements userItems, GameItem[] craftableElements)
        {
            _userItems = userItems;
            _craftableElements = craftableElements;

            _craftTable = new CraftTable(craftableElements);
        }

        public bool Process(string arguments)
        {
            if (arguments == Cmd)
            {
                _craftTable.ShowCraftableItems(_userItems);
                return true;
            }
            return false;
        }
    }
}
