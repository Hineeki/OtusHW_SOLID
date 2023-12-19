using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLibrary
{
    public interface IRandomizerGame
    {
        public int Answer { get; }

        public IColorConsole ColorConsole { get; }

        public void Run();

        public int ResponceProcessing();
    }
}
