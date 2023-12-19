using InterfacesLibrary;

namespace OtusHW_SOLID
{
    public class RandomizerGame : IRandomizerGame
    {
        public int Answer { get; }

        public IColorConsole ColorConsole { get; }

        public RandomizerGame(IColorConsole colorConsoleClass)
        {
            Random random = new Random();
            Answer = random.Next(1,10);
            ColorConsole = colorConsoleClass;
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
                        return;
                    case 1:
                        if (i == 2)
                        {
                            Console.Clear();
                            ColorConsole.CenterColorWrite("GAME OVER", ConsoleColor.Red);
                            ColorConsole.NextLineColorWrite("Ответ: " + Answer.ToString(), ConsoleColor.DarkGreen);
                        }
                        else
                        {
                            ColorConsole.ColorWriteLine("Вы не угадали, попробуйте снова^_^", ConsoleColor.DarkGreen);
                        }
                        break;
                    case 2:
                        if (i == 2)
                        {
                            Console.Clear();
                            ColorConsole.CenterColorWrite("GAME OVER", ConsoleColor.Red);
                            ColorConsole.NextLineColorWrite("Ответ: " + Answer.ToString(), ConsoleColor.DarkGreen);
                        }
                        else
                        {
                            ColorConsole.ColorWriteLine("Вы не угадали, попробуйте снова^_^", ConsoleColor.DarkGreen);
                        }
                        break;
                }
            }

        }

        public int ResponceProcessing()
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
