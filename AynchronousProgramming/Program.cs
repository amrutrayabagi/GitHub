using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AynchronousProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
            DisplayPrimeCounts();
            Console.ReadLine();
        }

        static void DisplayPrimeCounts()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(string.Format("There are {0} primes between {1}, {2}", GetPrimesCount(i * 10000000 + 2, 10000000), i * 10000000 + 2, 10000000));
            }
        }

        static void DisplayPrimeCountsAynch()
        {
            for (int i = 0; i < 10; i++)
            {
                var awaiter = GetPrimesCountsAsynch(i * 10000000 + 2, 10000000).GetAwaiter();

                awaiter.OnCompleted(() =>
                {
                    Console.WriteLine(string.Format("There are {0} primes between {1}, {2}", i * 10000000 + 2, 10000000));
                });

            }

        }
        static int GetPrimesCount(int start, int count)
        {
            return ParallelEnumerable.Range(start, count).Count(x => Enumerable.Range(2, (int)Math.Sqrt(x) - 1).All(i => x % i > 0));
        }

        static Task GetPrimesCountsAsynch(int start, int count)
        {
            return Task.Run(() =>
            {
                ParallelEnumerable.Range(start, count).Count(x => Enumerable.Range(2, (int)Math.Sqrt(x) - 1).All(i => x % i > 0));
            });
        }
    }
}
