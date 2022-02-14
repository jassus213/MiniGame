using ConsoleApp1.Inteface;

namespace ConsoleApp1
{
    class BackwardMove : ICommands
    {

        private IMovavable _man;
        

        public string Cmd => "s";

        public BackwardMove(IMovavable man)
        {
            _man = man;
        }
        

        public bool Process(string msg)
        {


            if (msg == "s")
            {
                _man.Move(0, -1);
                return true;
            }
            return false;

            /*if (msg == "w")
            {s
                man.Move(1, 0);
                man._savexmovement++;
            }

            if (button == "d")
            {
                man.Move(0, 1);
                man._saveymovement++;
            }

          

            if (button == "s")
            {
                man.Move(-1, 0);
                man._savexmovement++;
            }

            if (button == "q")
            {
                return;
            }
            if (button == "m")
            {
                int x = man.X;
                int y = man.Y;

                var result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                Console.WriteLine(result);
            }
            if (button == "st")
            {


                man.Character(man.Health, man.Weight, man.Growth, man.Dmg);
                Console.WriteLine($"ManStats: Рост {man.Growth} Вес {man.Weight} Здоровье {man.Health}");
                Console.WriteLine($"Местоположеине: {man.X} {man.Y}");
            }

            if (button == "duel")
            {
                Console.WriteLine($"Началась Дуэль между ГГ и Пауком");

                button = Console.ReadLine();
                if (button == "at")
                {

                    Console.WriteLine($"Здоровье Персонажа: {man.Health}  Здоровье Паука: {spider.Health}");


                    man.Duel(man.Health, man.Dmg);
                    spider.Duel(spider.Health, spider.Dmg);


                    Console.WriteLine($"Здоровье Персонажа: {man.Health}  Здоровье Паука: {spider.Health}");


                }

            }
            if (button == "med")
            {
                var health = man.Health;
                man.Regeneration(health);
                Console.WriteLine($"Ваше здоровье теперь {man.Health}");
            }
            if (button == "spawn")
            {

                int x = man.X;
                int y = man.Y;
                spider.Spawn(x, y);

            }*/
        }

       
    }
}
