using repeat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Man : IMovavable, ICharacterStats, IAttack, IDuel
    {

        public int Savexmovement;
        public int Saveymovement;

        public int X => _x;
        public int Y => _y;
        public int Health => _health;
        public double Weight => _weight;
        public double Growth => _growth;
        public int Dmg => _dmg;

        private int _x;
        private int _y;
        private int _health;
        private double _growth;
        private double _weight;
        private int _dmg;
        private Spider _spider;
        


       
        
        


        public Man(int health, double weight, double growth, int dmg)
        {

            _health = health;
            _growth = growth;
            _weight = weight;
            _dmg = dmg;
            




        }



        public void Move(int distanceX, int distanceY)
        {


            for (var i = 0; i < Math.Abs(distanceX); i++)
            {
                if (distanceX > 0)
                    _x++;
                else
                    _x--;

            }



            for (var i = 0; i < Math.Abs(distanceY); i++)
            {
                if (distanceY > 0)
                    _y++;
                else
                    _y--;
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

        public int Attack(int dmg, double crit)
        {

            bool chance = false;
            CritCalculator criticalhit = new CritCalculator(chance);

            criticalhit.CritChance();
            if (criticalhit.Chance == false)
            {

                Console.WriteLine($"Вы нанесли: {dmg}");
                return dmg;

            }

            else
            {
                Console.WriteLine($"Вы нанесли: {crit}");
                return (int)crit;
            }




        }
        public int Regeneration(int health)
        {
            if (health != 100)
            {
                if (health >= 85)
                {
                    _health = 100;
                    return health;
                }
                else
                {
                    _health = Health + 15;
                    return _health;
                }
            }
            else 
            {
                Console.WriteLine("Вы здоровы");
                return health;
            }
            return health;
        }

        public int Duel(int health, int dmg)
        {

            var crit = 15 * 1.2;
            
            var dmgspider = _spider.Attack(_spider.Dmg, Math.Round(crit, 1));
            _health = health - dmgspider;
            return Health;
        }
    }

}
