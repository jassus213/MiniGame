using repeat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Spider : IMovavable, IAttack, ICharacterStats, IDuel
    {
        private int _health;
        private double _weight;
        private double _growth;
        private int _dmg;



        public int Health => _health;
        public double Growth => _growth;
        public double Weight => _weight;
        public int Dmg => _dmg;

        public Spider(int health, double growth, double weight, int dmg)
        {
            _health = health;
            _growth = growth;
            _weight = weight;
            _dmg = dmg;

        }
        public int Attack(int dmg, double crit)
        {
            bool chance = false;
            CritCalculator criticalhit = new CritCalculator(chance);

            criticalhit.CritChance();
            if (criticalhit.Chance == false)
            {
                Console.WriteLine($"Паук нанёс {_dmg}");
                return _dmg;
            }

            else
            {
                crit = _dmg * 1.2;
                Console.WriteLine($"Паук нанёс {crit}");
                return (int)crit;
            }
        }

        public void Character(int health, double growth, double weight, int dmg)
        {

            health = 100;
            health = _health;
            growth = 82;
            growth = _growth;
            weight = 15;
            weight = _weight;
            dmg = _dmg;
            dmg = 15;






        }

        public void Move(int diatanceX, int distanceY)
        {
            throw new NotImplementedException();
        }

        public int Duel(int health, int dmg)
        {

            var crit = 50 * 1.1;
            Man man = new Man(100, 63.5, 172.5, 50);
            var dmgman = man.Attack(man.Dmg, Math.Round(crit, 1));
            _health = Health - dmgman;
            return _health;
        }

        public void Spawn(int x, int y)
        {

            var spawncoord = new SpawnCoordinationCalculator(x,y);
            spawncoord.SpawnCalc(x,y);
            Console.WriteLine($"Паук заспавнился на координатах X: {spawncoord.RndCoordX} Y: {spawncoord.RndCoordY}");

        }
    }
}
