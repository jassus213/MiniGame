using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CritCalculator
    {
        private bool _chance;
        public bool Chance => _chance;
        public CritCalculator(bool chance)
        {
            _chance = chance;
        }
        public bool CritChance()
        {
            Random rnd = new Random();
            int procents = rnd.Next(0, 100);
            if (procents <= 20)

                _chance = true;
            else
                _chance = false;

            return _chance;
        }
    }
}
