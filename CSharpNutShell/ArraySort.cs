using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNutShell
{
    public class ArraySort
    {
        int[] Numbers = { 1, 5, 2, 8, 9, 22 };

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Sort()
        {
            Array.Sort(Numbers);
            Console.WriteLine("Sorted Array");
            foreach (int item in Numbers)
            {
                Console.WriteLine(" " + item);
            }
        }
    }
}
