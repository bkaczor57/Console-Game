using LegendaryHero.Adventures;
using Newtonsoft.Json;
using System;
using System.IO;
using LegendaryHero.Game;
namespace LegendaryHero
{
    class Program
    {
        private static GameService gameService = new GameService();
        static void Main(string[] args) 
        {
            MakeTitle();
            MakeMainMenu();
        }

        private static void MakeTitle()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*   _                               _                    _   _                 *");
            Console.WriteLine("*  | |                             | |                  | | | |                *");
            Console.WriteLine("*  | |     ___  __ _  ___ _ __   __| | __ _ _ __ _   _  | |_| | ___ _ __ ___   *");
            Console.WriteLine("*  | |    / _ \\/ _` |/ _ \\ '_ \\ / _` |/ _` | '__| | | | |  _  |/ _ \\ '__/ _ \\  *");
            Console.WriteLine("*  | |___|  __/ (_| |  __/ | | | (_| | (_| | |  | |_| | | | | |  __/ | | (_) | *");
            Console.WriteLine("*  \\_____/\\___|\\__, |\\___|_| |_|\\__,_|\\__,_|_|   \\__, | \\_| |_/\\___|_|  \\___/  *");
            Console.WriteLine("*               __/ |                             __/ |                        *");
            Console.WriteLine("*              |___/                             |___/                         *");
            Console.WriteLine("********************************************************************************\n\n");
        }

        private static void MakeMainMenu()
        {
            MakeMenuOptions();
            bool inputValid = false;
            
            while (!inputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.StartGame();
                        break;
                    case "L":
                        LoadGame();
                        break;
                    case "C":
                        CreateCharacter();
                        break;
                    case "X":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nWhat a fucking moroon. You can't even click the right button to choose the option. Try Again looser");
                        MakeMenuOptions();
                        inputValid = false;
                        break;
                }
            }
        }

        private static void MakeMenuOptions()
        {
            Console.WriteLine("\n(S)twórz nową rozgrywkę!");
            Console.WriteLine("(L)oaduj save'a!");
            Console.WriteLine("(C)reator Postaci!");
            Console.WriteLine("(X) Wyjście z gry :(");
            Console.WriteLine("Wybierz Opcje:");
        }

        

        private static void LoadGame()
        {
            Console.WriteLine("You Loaded the game! Cool!");
        }

        private static void CreateCharacter()
        {
            Console.WriteLine("You have just created a character! How awesome!");
        }


    }
}
