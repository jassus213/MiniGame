using ConsoleApp1;
using ConsoleApp1.Commands;
using ConsoleApp1.Inteface;
using ConsoleApp1.Item;


namespace repeat
{
    class Program
    {

        static void Main()
        {

            Man man = new Man(100, 63.5, 172.5, 50);

            Spider spider = new Spider(100, 80, 30, 15);

            InventoryStatus inventoryStatus = new InventoryStatus(false) ;

            var amethyst = new GameItem(GameElements.Amethyst, new Dictionary<GameElements, int>
            {
                {GameElements.Amethyst, 1 }
            });

            var wood = new GameItem(GameElements.Wood, new Dictionary<GameElements, int>
            {
                {GameElements.Wood , 1 }
            });

            var stone = new GameItem(GameElements.Stone, new Dictionary<GameElements, int>
            {
                {GameElements.Stone , 1 }
            });


            var axe = new GameItem(GameElements.Axe, new Dictionary<GameElements, int>
            {
                {GameElements.Wood , 2 },
                {GameElements.Stone , 3  }
            });

            var pickaxe = new GameItem(GameElements.PickAxe, new Dictionary<GameElements, int>
            {
                {GameElements.Wood , 2 },
                {GameElements.Stone , 3 }
            });



            var userItems = new UserElements(new Dictionary<GameElements, int>
            {
                {GameElements.Wood , 10 },
                {GameElements.Stone , 10 },
                {GameElements.Amethyst, 1 }
            });


            var gameItems = new GameItems(new GameItem[] { wood, axe, stone, pickaxe });
            var crafter = new Craft(gameItems, userItems);


           


            


            var commandslist = new List<ICommands>
            {
                new BackwardMove(man),
                new TopMove(man, inventoryStatus.InventoryStat),
                new MoveLeft(man),
                new MoveRight(man),
                new InventoryOpen(userItems, inventoryStatus),
                new InventoryClose(userItems, inventoryStatus),
                new CraftCommand(crafter),
                new CoordsMan(man),
                new CanCraft(userItems, new [] { pickaxe, axe })

            };


            /*commandslist[1] = "s";*/











            while (true)
            {
                var txt = Console.ReadLine();
                foreach (var command in commandslist)
                {
                    if (command.Process(txt))
                        break;
                }
            }





























            













        }













    }
}
 








