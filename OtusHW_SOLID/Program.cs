namespace OtusHW_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var randomizer = new RandomizerGame();
                randomizer.Run();
            }
            catch (ArgumentNullException)
            {
                ColorConsole.ColorWriteLine("Вы ничего не ввели.", ConsoleColor.Yellow);
            }
            catch (FormatException)
            {
                ColorConsole.ColorWriteLine("Вы ввели арабскую цифру/целое число?", ConsoleColor.Yellow);
            }
            Console.ReadLine();
        }
    }
}
