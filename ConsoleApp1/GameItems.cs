using ConsoleApp1.Inteface;
using ConsoleApp1.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GameItems// : IItems
    {
        private HashSet<GameItem> _items;
        public IReadOnlySet<GameItem> Items => _items;


        public GameItems(GameItem[] items)
        {
            _items = new HashSet<GameItem>(items);

        }


        public GameItem Find(GameElements type)
        {
            foreach(var item in _items)
            {
                if (item.Type == type)
                    return item;
            }

            return null;
        }

        public void AddItems(GameItem item)
        {
            _items.Add(item);
        }



        public void RemoveItems()
        {
            throw new NotImplementedException();
        }
    }
}
