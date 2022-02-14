using ConsoleApp1.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UserElements
    {
        private Dictionary<GameElements, int> _elements;


        public UserElements(IDictionary<GameElements, int> items)
        {
            _elements = new Dictionary<GameElements, int> (items);
        }

        public int Find(GameElements type)
        {
            if (_elements.ContainsKey(type))
                return _elements[type];
            return 0;
        }

        public void Add(GameItem item)
        {
            if (!_elements.ContainsKey(item.Type))
                _elements.Add(item.Type, 1);
            else
            {
                var quantity = _elements[item.Type];
                _elements[item.Type] = quantity++;
            }
        }

        public bool Remove(GameElements type, int value)
        {
            if (!_elements.ContainsKey(type))
                return false;

            var quantity = _elements[type];
            if (quantity >= value)
            {
                _elements[type] = quantity - value;
                return true;
            }


            return false;
        }
    }
}
