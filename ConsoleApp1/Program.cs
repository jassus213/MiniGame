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

            Spider spider = new Spider(100, 80, 30, 15, man);

            InventoryStatus inventoryStatus = new InventoryStatus(false);

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

            var stick = new GameItem(GameElements.Stick, new Dictionary<GameElements, int>()
            {
                {GameElements.Wood, 2 }
            });

            var axe_wooden = new GameItem(GameElements.Axe_wooden, new Dictionary<GameElements, int>
            {
                {GameElements.Wood , 2 },
                {GameElements.Stick , 3 }
            });

            var pickaxe_wooden = new GameItem(GameElements.PickAxe_wooden, new Dictionary<GameElements, int>
            {
                {GameElements.Wood , 3 },
                {GameElements.Stick , 2 }
            });
            var shovel_wooden = new GameItem(GameElements.Shovel_wooden, new Dictionary<GameElements, int>
            {
                {GameElements.Wood , 2 },
                {GameElements.Stick , 2 }
            });





            var userItems = new UserElements(new Dictionary<GameElements, int>
            {
                {GameElements.Wood , 10 },
                {GameElements.Stone , 10 },
                {GameElements.Amethyst, 1 }
            });


            var gameItems = new GameItems(new GameItem[] { wood, axe_wooden, stone, pickaxe_wooden });
            var crafter = new Craft(gameItems, userItems);








            var commandslist = new List<ICommands>
            {
                new BackwardMove(man, inventoryStatus),
                new TopMove(man, inventoryStatus),
                new MoveLeft(man, inventoryStatus),
                new MoveRight(man, inventoryStatus),
                new InventoryOpen(userItems, inventoryStatus),
                new InventoryClose(userItems, inventoryStatus),
                new CraftCommand(crafter),
                new CoordsMan(man),
                new PersonStats(man),
                new HealPerson(man),
                new CanCraft(userItems, new [] { pickaxe_wooden, axe_wooden, shovel_wooden })

            };














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









