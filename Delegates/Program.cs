using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void ProgressReportDelegate(int percentComplete);
    class Program
    {
        //static void Main(string[] args)
        //{

        //    //below class is used for invoking a delegete.
        //    //assign a function to the delegate
        //    ProgressReportDelegate p = WriteProgressToConsole;
        //    p += WriteProgressToFile;
        //    Util.HardWork(p);
        //    //Console.ReadKey();


        //    //Test the delegate by passing delegate as a method.

        //    NotifyDelegate delInstance = new NotifyDelegate(WriteMessage);
        //    SaveFileToDatabase sd = new SaveFileToDatabase();
        //    sd.Start(delInstance);
        //    //Console.ReadKey();

        //    Func<int, int> type = WriteProgressToConsoleInt;
        //    //for (int i = 1; i <= 10; i++)
        //    //{

        //    //    Console.WriteLine(type(i));
        //    //}

        //    //Func<int, int> delInstance1 = new delegate(int i) { return delInstance1(i - 1) + delInstance1(i - 2); };
        //    Func<int, int> fib = null;
        //    fib = (i) => i > 1 ? fib(i - 1) + fib(i - 2) : i;
        //    //for (int i = 1; i < 10; i++)
        //    //{
        //    Console.WriteLine(fib(4));
        //    //}

        //    //nConsole.WriteLine(FibonanniSeries(10));



        //    //test for multicast delegate.
        //    TransaFormer<int> obj = Square;
        //    int result=GenericDelegates.TransForm<int>(new int[] { 1, 2, 3 }, obj);


        //    //Point to Decimal values
        //    TransaFormer<decimal> objDelDecimal = DecimalReturn;
        //    GenericDelegates.TransForm<decimal>(new Decimal[] { 1, 2, 3 }, objDelDecimal);


        //    Console.Read();
        //}

        private static decimal DecimalReturn(decimal param)
        {
            return param * param * param;
        }




        private static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }

        private static int WriteProgressToConsoleInt(int percentComplete)
        {
            Console.WriteLine(percentComplete);
            return percentComplete * percentComplete;
        }

        private static void WriteProgressToFile(int percentComplete)
        {
            System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
        }

        private static void WriteMessage(string text)
        {
            Console.WriteLine(text);
        }

        private static int FibonanniSeries(int i)
        {
            if (i == 0 || i == 1) { return 0; }
            else
            {

                return FibonanniSeries(i - 1) + FibonanniSeries(i - 2);
            }
        }

        //This function is used to test the generic delegates.

        public static int Square(int x)
        {
            return x * x;
        }

    }

    //multicast delegate:
    //these delegates are usually used for long running operations.
    //here we specify the delegate and invoke it in seperate thread, which keep on 
    //inform us about the progress.

    public class Util
    {
        public static void HardWork(ProgressReportDelegate d)
        {
            for (int i = 0; i < 10; i++)
            {
                d(i * 10); // Invoke delegate
                System.Threading.Thread.Sleep(1000); // Simulate hard work
            }
        }
    }

}

//Learnings;

// 1. delegates are used when we go for event driven pattern model.
//2. used for the encapsulation of static methods
//3. One beauty about the delegates is it can be passed as a method to another method(Basically 
//sending an instance of method delegate and which inturn calls the actual function.
//4. Another way of declaring the delegate is by using FUNC<obj,obj>=Method Name.
//we can call the function similar to the delegate
