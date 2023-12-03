using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW_SOLID
{
    static class ColorConsole
    {
        /// <summary>
        /// Этот метод выводит в консоль текст, меняя цвет текста на ConsoleColor, затем сбрасывает цвет текста.
        /// </summary>
        /// <param name="text">Выводимый текст</param>
        /// <param name="consoleColor">Цвет текста</param>
        public static void ColorWriteLine(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void ColorWrite(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.Write(text);
            Console.ResetColor();
        }
        
        //Неудобный метод, можно написать только одну строку
        public static void CenterColorWrite(string text, ConsoleColor consoleColor)
        {
            int centerX = (Console.WindowWidth / 2) - (text.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            ColorWrite(text, consoleColor);

        }
        public static void NextLineColorWrite(string text, ConsoleColor consoleColor)
        {
            Console.WriteLine();
            int centerX = (Console.WindowWidth / 2) - (text.Length / 2);
            int centerY = Console.GetCursorPosition().Top;
            Console.SetCursorPosition(centerX, centerY);
            ColorWrite(text, consoleColor);
        }

    }
}
