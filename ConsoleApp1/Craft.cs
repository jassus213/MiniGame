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
        
        public Craft(GameItems allgameitems)
        {
            _allgameitems = allgameitems;
        }
        
        public GameItem CraftItem(UserElements gameitems, GameElements type)
        {

            var existElement = _allgameitems.Find(type);
            if(existElement != null)
            {
                foreach(var parts in existElement.Parts)
                {
                    if  (!gameitems.Remove(parts.Key, parts.Value))
                        return null;

                }
                return existElement; 
            }

            return null;

        }


    }
}
