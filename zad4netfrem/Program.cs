using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4netfrem
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider dataProvider = new SystemDataProvider();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            dataProvider.Attach(consoleLogger);
            dataProvider.GetCPULoad();
            dataProvider.GetAvailableRAM();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
