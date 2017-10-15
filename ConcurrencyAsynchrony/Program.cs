using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConcurrencyAsynchrony
{
    class Program
    {
        static System.Threading.SynchronizationContext _synchObject;
        static void Main(string[] args)
        {
            bool _done = false;

            _synchObject = System.Threading.SynchronizationContext.Current;

            Thread t = new Thread(PrintOnDifferentThread);
            t.Name = "Child Thread";
            t.Start();
            // t.Join();

            Console.WriteLine("Thread " + t.Name + " Ended");
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(string.Format("{0}", "X"));
            }


            ThreadStart action = () => { if (_done) Console.WriteLine("Its done"); _done = true; };
            new Thread(action).Start();
            _done = true;


            new Thread(() => { Console.WriteLine("amrut"); }).Start();


           


            Console.Read();
        }

        static void PrintOnDifferentThread()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(string.Format("{0}", i.ToString(System.Globalization.NumberFormatInfo.CurrentInfo)));
            }

            _synchObject.Post((x) => { Console.WriteLine("djsfkajdskfjasdlkf"); }, null);

        }
    }
}
