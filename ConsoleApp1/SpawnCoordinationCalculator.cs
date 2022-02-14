using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SpawnCoordinationCalculator
    {
        private int _rndcoordX;
        private int _rndcoordY;

        public int RndCoordX => _rndcoordX;
        public int RndCoordY => _rndcoordY;

        public SpawnCoordinationCalculator(int rndcoordX, int rndcoordY)
        {
            _rndcoordX = rndcoordX;
            _rndcoordY = rndcoordY;
        }

        public void SpawnCalc(int x, int y)
        {
            
            var xcoordination = x + 10;
            var ycoordination = y + 10;
            var randomize = new Random();
            var rndcoordX = randomize.Next(x, xcoordination);
            var rndcoordY = randomize.Next(y, ycoordination);
            _rndcoordX = rndcoordX;
            _rndcoordY = rndcoordY;

            //спавн максимум на 10 коордиант от игрока вперёд
            
        }
        
    }
}
