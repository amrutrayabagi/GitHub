using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger file = FileLogger.GetInstance();
            file.PrintLogger();
            Console.Read();


            FileLogger file1 = FileLogger.GetInstance();
            file1.PrintLogger();
            Console.Read();
        }
    }
}
