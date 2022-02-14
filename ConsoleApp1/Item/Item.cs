using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Item
{
    public class GameItem
    {

        private Dictionary<GameElements, int> _parts;
        public IDictionary<GameElements, int> Parts => _parts;
        public GameElements Type { get; }

        public GameItem(GameElements type ,IDictionary<GameElements, int> parts)
        {
            _parts = new Dictionary<GameElements, int>(parts);
            Type = type;
        }




    }
}
