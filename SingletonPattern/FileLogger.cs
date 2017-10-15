using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class FileLogger
    {
        private static readonly Lazy<FileLogger> logger = new Lazy<FileLogger>(() => new FileLogger());
        public static FileLogger GetInstance() => logger.Value;

        public void PrintLogger()
        {
            for (int i = 1; i <= 50; i++) { Console.WriteLine("File Logger started!...."); }
            Console.WriteLine("File Logger ends!....");
        }

    }
}
