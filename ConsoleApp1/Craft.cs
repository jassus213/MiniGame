using ConsoleApp1.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Craft
    {
        private GameItems _allgameitems;
        private UserElements _gameItems;

        public Craft(GameItems allgameitems,UserElements gameItems)
        {
            _allgameitems = allgameitems;
            _gameItems = gameItems;
            
        }

        public bool CraftItem(GameElements type)
        {

            var existElement = _allgameitems.Find(type);
            if (existElement != null)
            {
                if (existElement.Parts.Count == 1)
                    return false;
                foreach (var parts in existElement.Parts)
                {
                    if (!_gameItems.Remove(parts.Key, parts.Value))
                        return false; ;

                }
                _gameItems.Add(existElement);
                return true;
            }

            return false;

        }


    }
}
