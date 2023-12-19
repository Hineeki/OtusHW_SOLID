using InterfacesLibrary;

namespace OtusHW_SOLID
{
    public class ColorConsole : IColorConsole
    {
        /// <summary>
        /// Этот метод выводит в консоль текст, меняя цвет текста на ConsoleColor, затем сбрасывает цвет текста.
        /// </summary>
        /// <param name="text">Выводимый текст</param>
        /// <param name="consoleColor">Цвет текста</param>
        public void ColorWriteLine(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public void ColorWrite(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.Write(text);
            Console.ResetColor();
        }
        
        /// <summary>
        /// Этот метод выводит в центр консоли текст, но курсор возвращать нужно ручками.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="consoleColor"></param>
        public void CenterColorWrite(string text, ConsoleColor consoleColor)
        {
            int centerX = (Console.WindowWidth / 2) - (text.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            ColorWrite(text, consoleColor);

        }
        public void NextLineColorWrite(string text, ConsoleColor consoleColor)
        {
            Console.WriteLine();
            int centerX = (Console.WindowWidth / 2) - (text.Length / 2);
            int centerY = Console.GetCursorPosition().Top;
            Console.SetCursorPosition(centerX, centerY);
            ColorWrite(text, consoleColor);
        }
    }
}
