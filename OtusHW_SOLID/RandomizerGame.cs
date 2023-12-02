using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW_SOLID
{
    public class RandomizerGame
    {
        public int Answer { get; }

        public RandomizerGame()
        {
            Random random = new Random();
            Answer = random.Next(1,10);
        }

        public void Run()
        {
            ColorConsole.ColorWriteLine("Я загадал целое число от 1 до 10 (включительно), " +
                                        "попробуйте угадать его. У Вас 3 попытки.", ConsoleColor.Green);
            for (int i = 0; i < 3; i++)
            {
                switch (ResponceProcessing())
                {
                    case 0:
                        ColorConsole.ColorWriteLine("Вы угадали, поздравляю!", ConsoleColor.Green);
                        break;
                    case 1:
                        ColorConsole.ColorWriteLine("Вы не угадали, попробуйте снова^_^", ConsoleColor.DarkGreen);
                        if (i == 2)
                        {
                            ColorConsole.ColorWriteLine("Ответ: "+Answer.ToString(), ConsoleColor.DarkGreen);
                        }
                        break;
                    case 2:
                        ColorConsole.ColorWriteLine("Вы не угадали, попробуйте снова^_^", ConsoleColor.DarkGreen);
                        if (i == 2)
                        {
                            ColorConsole.ColorWriteLine("Ответ: " + Answer.ToString(), ConsoleColor.DarkGreen);
                        }
                        break;
                }
            }

        }
        private int ResponceProcessing()
        {
            var responce = int.Parse(Console.ReadLine());
            if (responce < Answer)
            {
                ColorConsole.ColorWriteLine("Введённое число меньше ответа.", ConsoleColor.DarkGreen);
                return 1;
            }
            else if (responce > Answer)
            {
                ColorConsole.ColorWriteLine("Введённое число больше ответа.", ConsoleColor.DarkGreen);
                return 2;
            }
            else { return 0; }
        }
    }
}
