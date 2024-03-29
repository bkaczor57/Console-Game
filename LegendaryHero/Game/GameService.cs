﻿using LegendaryHero.Adventures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryHero.Game
{
    class GameService
    {
        public void StartGame()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}adventures";
            var initialAdventure = new Adventure();
            if (File.Exists($"{basePath}\\initial.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("initial.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());
                }

                Console.WriteLine($"Adventure :{initialAdventure.Title}");
                Console.WriteLine($"Description :{initialAdventure.Description}");
                Console.WriteLine($"CompletionXPReward:{initialAdventure.CompletionXPReward}");
            }


            Console.WriteLine("You started the game! Great Job!");

        }
    }
}
