using System;
using System.Collections.Generic;
using System.Text;

namespace zad3netFrem
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine(DateTime.Now + "-> CPU load: " + provider.CPULoad + " Available RAM: " + provider.AvailableRAM);
        }
    }

}
