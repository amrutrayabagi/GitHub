using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.cs
{
    public class InsertionSort
    {
        public void SortElements()
        {
            int[] elements = { 10, 3, 2, 8, 4, 3 };
            int min = elements[0];
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (elements[j] < elements[j - 1])
                    {
                        int temp = elements[j];
                        elements[j] = elements[j - 1];
                        elements[j - 1] = temp;
                    }
                }
            }


            Console.WriteLine("Sorted Array");
            for (int i = 0; i < elements.Length - 1; i++)
            {
                Console.Write(elements[i] + " ");
            }

            Console.Read();
        }
    }
}
