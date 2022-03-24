using ConsoleApp1.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CraftTable
    {

        private GameItem[] _gameItems;
        
        
        public CraftTable(GameItem[] gameItems)
        {
            _gameItems = gameItems;
        }

        public bool ShowCraftableItems(UserElements userElements)
        {
            foreach (var elements in _gameItems)
            {
                foreach (var userElement in userElements.Elements)
                {
                    if (elements.Parts.ContainsKey(userElement.Key))
                    {
                        if (userElement.Value < elements.Parts[userElement.Key])
                            return false;

                    }
                    else
                        return false;
                   
                }
            }
            return false;
        }
    }
}
