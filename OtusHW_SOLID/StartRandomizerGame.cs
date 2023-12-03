using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW_SOLID
{
    static class StartRandomizerGame
    {
        public static void StartGame()
        {
            while (true)
            {
                var randomizer = new RandomizerGame();
                randomizer.Run();
                ColorConsole.NextLineColorWrite("Хотите продолжить?", ConsoleColor.Blue);
                ColorConsole.NextLineColorWrite("Y/N ?", ConsoleColor.Blue);
                var responce = Console.ReadLine().ToUpper();
                if (responce == ConsoleKey.N.ToString())
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
