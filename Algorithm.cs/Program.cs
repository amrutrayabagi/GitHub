using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Availibale Options");
            Console.WriteLine("1- Chapter- 2 : Add 2 byte arrays");
            Console.WriteLine("2- Chapter- 2 : Insertion Sort");
            Console.WriteLine("3- Chapter- 2 : Merge Sort");
            int data = Convert.ToInt32(Console.ReadLine());
            switch (data)
            {
                case 1:
                    new C2BitAddition().Add(); break;
                case 2:
                    new InsertionSort().SortElements(); break;
                case 3:
                    new MergeSort().SortElements(); break;
                default:
                    Console.WriteLine("No Opations Found. Press key...");
                    Console.ReadKey();
                    break;


            }

        }
    }
}
