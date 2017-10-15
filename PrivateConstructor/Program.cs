using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateConstructror obj = PrivateConstructror.Instance;
            Console.WriteLine(obj.counter);
            Console.WriteLine(obj.counter++);
            Console.WriteLine(obj.counter++);
            Console.Read();
        }
    }
}
