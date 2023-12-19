namespace OtusHW_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorConsole colorConsole = new ColorConsole();
            while (true)
            {
                try
                {
                    var randomizer = new RandomizerGame(colorConsole);
                    randomizer.Run();
                    randomizer.ColorConsole.NextLineColorWrite("Хотите продолжить?", ConsoleColor.Blue);
                    randomizer.ColorConsole.NextLineColorWrite("Y/N ?", ConsoleColor.Blue);
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
                catch (FormatException)
                {
                    Console.Clear();
                    colorConsole.ColorWriteLine("Вы ввели арабскую цифру/целое число?", ConsoleColor.Yellow);
                    Console.WriteLine("Нажмите ENTER чтобы продолжить.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
