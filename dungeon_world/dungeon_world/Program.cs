using System;
using System.Threading;

namespace dungeon_world
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("|────────────────────────────────────────────────────────────────────────────────────────────────────|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|---------------------------------------------WELCOME TO---------------------------------------------|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|------------  _____                                      __          __        _     _  ------------|");
            Console.WriteLine("|------------ |  __ \\                                     \\ \\        / /       | |   | | ------------|");
            Console.WriteLine("|------------ | |  | |_   _ _ __   __ _  ___  ___  _ __    \\ \\  /\\  / /__  _ __| | __| | ------------|");
            Console.WriteLine("|------------ | |  | | | | | '_ \\ / _` |/ _ \\/ _ \\| '_ \\    \\ \\/  \\/ / _ \\| '__| |/ _` | ------------|");
            Console.WriteLine("|------------ | |__| | |_| | | | | (_| |  __/ (_) | | | |    \\  /\\  / (_) | |  | | (_| | ------------|");
            Console.WriteLine("|------------ |_____/ \\____|_| |_|\\___ |\\___|\\___/|_| |_|     \\/  \\/ \\___/|_|  |_|\\____| ------------|");
            Console.WriteLine("|------------                     __ / |                                                 ------------|");
            Console.WriteLine("|------------                    | ___/                                                  ------------|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|────────────────────────────────────────────────────────────────────────────────────────────────────|");
            Console.WriteLine();
            Console.Write("Press any key to continue... ");
            Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Generating Story... ");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Creating World... ");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Killing Goblins... ");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("|──────────────────────────────────────|");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("|----- __  __                     -----|");
            Console.WriteLine("|-----|  \\/  |                    -----|");
            Console.WriteLine("|-----| \\  / |  ___  _ __   _   _ -----|");
            Console.WriteLine("|-----| |\\/| | / _ \\| '_ \\ | | | |-----|");
            Console.WriteLine("|-----| |  | ||  __/| | | || |_| |-----|");
            Console.WriteLine("|-----|_|  |_| \\___||_| |_| \\__,_|-----|");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("|──────────────────────────────────────|");
            Console.WriteLine("|1. New Game                           |");
            Console.WriteLine("|2. Load Game                          |");
            Console.WriteLine("|3. Credits                            |");
            Console.WriteLine("|4. Exit                               |");
            Console.WriteLine("|──────────────────────────────────────|");
            Console.Write("Choose a menu option: ");
            int menuoption;
            menuoption = Int32.Parse(Console.ReadLine());
            switch(menuoption)
            {
                case 1:
                {
                    newGame();
                    break;
                }
                case 2:
                {
                    //loadGame();
                    break;
                }
                case 3:
                {
                    //creditsGame();
                    break;
                }
                case 4: { Environment.Exit(0); break; }
            }

            Console.ReadLine();

        }
        public static void newGame()
        {
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("|──────────────────────────────────────────────────────────────────|");
            Console.WriteLine("|------------------------CHARACTER CREATION------------------------|");
            Console.WriteLine("|──────────────────────────────────────────────────────────────────|");
            Console.WriteLine("|CHARACTER CLASS|");
            Console.WriteLine("|1. Bard        |");
            Console.WriteLine("|1. Druid       |");
            Console.WriteLine("|1. Warrior     |");
            Console.WriteLine("|1. Bard        |");
            Console.WriteLine("|1. Bard        |");
            Console.WriteLine("|1. Bard        |");
            Console.WriteLine("|1. Bard        |");
            Console.WriteLine("|1. Bard        |");
            Console.WriteLine("|1. Bard        |");
        }
    }
}
