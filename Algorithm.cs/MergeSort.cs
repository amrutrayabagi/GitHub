using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.cs
{
    public class MergeSort
    {
        public void SortElements()
        {
            int[] elements = { 10, 3, 2, 8, 4, 3 };
            MergeSortSequence(elements, 1, elements.Length);


            Console.WriteLine("Sorted Array");
            for (int i = 0; i < elements.Length - 1; i++)
            {
                Console.Write(elements[i] + " ");
            }

            Console.Read();
        }

        public void MergeSortSequence(int[] Elements, int startingIndex, int endingIndex)
        {
            int middleIndex = (startingIndex + endingIndex) / 2;
            int[] leftArray = new int[middleIndex + 1];
            int[] rightArray = new int[endingIndex - middleIndex + 1];
            leftArray[middleIndex] = -999;
            rightArray[endingIndex - middleIndex] = -999;

            for (int i = 0; i < middleIndex; i++)
            {
                leftArray[i] = Elements[i];
            }
            int h = 0;
            for (int j = middleIndex; j < endingIndex; j++)
            {
                rightArray[h] = Elements[j];
                h++;
            }
            int s = 0, t = 0;

            for (int k = 0; k < endingIndex - 1; k++)
            {
                if (leftArray[s] == -999)
                {
                    for (int ele = t; ele <= t; ele++)
                    {
                        Elements[k] = rightArray[ele];
                    }
                    break;
                }
                else if (rightArray[t] == -999)
                {
                    for (int ele = s; ele <= s; ele++)
                    {
                        Elements[k] = leftArray[ele];
                    }
                    break;
                }

                if (leftArray[s] <= rightArray[t])
                {
                    Elements[k] = leftArray[s];
                    s++;
                }
                else
                {
                    Elements[k] = rightArray[t];
                    t++;
                }


            }
            Console.Write("Sorted Array");
            for (int k = 0; k < endingIndex - 1; k++)
            {
                Console.Write(Elements[k] + " ");
            }
            Console.Read();
        }


    }
}