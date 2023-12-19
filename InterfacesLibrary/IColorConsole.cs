namespace InterfacesLibrary
{
    public interface IColorConsole
    {
        public void ColorWriteLine(string text, ConsoleColor consoleColor);

        public void ColorWrite(string text, ConsoleColor consoleColor);

        public void CenterColorWrite(string text, ConsoleColor consoleColor);

        public void NextLineColorWrite(string text, ConsoleColor consoleColor);
    }
}
