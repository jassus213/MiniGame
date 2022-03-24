using ConsoleApp1.Inteface;

namespace ConsoleApp1
{
    class BackwardMove : ICommands
    {

        private IMovavable _man;
        private InventoryStatus _inventoryStatus;
        

        public string Cmd => "s";

        public BackwardMove(IMovavable man, InventoryStatus inventoryStatus)
        {
            _man = man;
            _inventoryStatus = inventoryStatus;
        }
        

        public bool Process(string msg)
        {


            if (msg == Cmd)
            {
                if (_inventoryStatus.InventoryStat == false)
                {
                    _man.Move(0, -1);
                    return true;
                }
                else
                {
                    Console.WriteLine("Вы не можете это сделать, т.к открыт инвентарь.");
                    return false;
                }
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
            
            if (button == "spawn")
            {

                int x = man.X;
                int y = man.Y;
                spider.Spawn(x, y);

            }*/
        }

       
    }
}
