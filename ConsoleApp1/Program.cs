using ConsoleApp1;
using ConsoleApp1.Inteface;
using ConsoleApp1.Item;


namespace repeat
{
    class Program
    {

        static void Main()
        {

            Man man = new Man(100, 63.5, 172.5, 50);


            var commandslist = new ICommands[2];
            commandslist[0] = new BackwardMove(man);
            commandslist[1] = new TopMove(man);
            /*commandslist[1] = "s";*/
            
            var txt = Console.ReadLine();
            foreach(var command in commandslist)
            {
                if (command.Process(txt))
                    break;
            }

            
            
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


            var gameItems = new GameItems(new GameItem[] { wood, axe, stone });

            var crafter = new Craft(gameItems);

            var userItems = new UserElements(new Dictionary<GameElements, int>
            {
                {GameElements.Wood , 10 },
                {GameElements.Stone , 10 }
            });

            var craftedAxe = crafter.CraftItem(userItems, GameElements.Axe);

            if(craftedAxe != null)
            {
                userItems.Add(craftedAxe);
            }

      

         



            

            Spider spider = new Spider(100, 80, 30, 15);


            

            
            





            

        }













    }
}








