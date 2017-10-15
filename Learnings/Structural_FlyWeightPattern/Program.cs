using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Structural_FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            //for (int counter = 0; counter < number; counter++)
            //    Console.WriteLine(" \n" + Fibonacci(counter));

            new FibFactory().Run(number);
            Read();

        }

        static int Fibonacci(int n)
        {
            if (n == 0) { return 0; };
            if (n == 1) { return 1; };
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }

    public class FibGenearte
    {
        int _fibNumber;
        public int FibNumber
        {
            get
            {
                return _fibNumber;
            }
        }

        public FibGenearte(int n)
        {
            _fibNumber = Fib(n);
        }

        private int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
    }


    public class FibFactory
    {
        private Dictionary<int, FibGenearte> fibNumbers = new Dictionary<int, FibGenearte>();

        public void Run(int n)
        {

            for (int i = 0; i < n; i++)
            {
                if (fibNumbers.Where(x => x.Value.FibNumber == i).Count() > 0)
                {
                    WriteLine(fibNumbers.First(x => x.Value.FibNumber == i));
                }
                else
                {
                    fibNumbers[i] = new FibGenearte(i);
                    WriteLine(fibNumbers[i].FibNumber);
                }
            }
        }
    }

}
