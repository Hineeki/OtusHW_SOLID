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
        /// Этот метод выводит в консоль текст, меняя цвет текста на consoleColor, затем сбрасывает цвет текста.
        /// </summary>
        /// <param name="text">Выводимый текст</param>
        /// <param name="consoleColor">Цвет текста</param>
        public static void ColorWriteLine(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
