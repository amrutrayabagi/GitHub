using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            SingletonNormalWay obj = SingletonNormalWay.GetInstance();
            obj.ReturnMessage();



            StaticClass obj1 = StaticClass.ReturnIsntance();
            obj1.ReturnMessage();


            Experiment exp = new Experiment();
            exp.SayHello();

            Console.Read();

        }
    }




    public sealed class SingletonNormalWay
    {
        private static SingletonNormalWay instance;
        private static object sysnhObj = new object();

        private SingletonNormalWay()
        {
        }

        public static SingletonNormalWay GetInstance()
        {
            if (instance == null)
            {
                lock (sysnhObj)
                {
                    instance = new SingletonNormalWay();
                    return instance;
                }
            }
            else
            {
                return instance;
            }
        }

        public string ReturnMessage()
        {
            Console.WriteLine("This message is from singleton normal class");
            return string.Empty;
        }
    }

    //This example is equivalent of the singleton pattern which 
    //user locks and instance creation of the type 
    //In Singlerton we have to control the object state and also the object locking 
    //for not to intialize it again.
    public sealed class StaticClass
    {
        private static StaticClass InstanceOfThisClass;
        private StaticClass() { }

        public static StaticClass ReturnIsntance()
        {
            InstanceOfThisClass = new StaticClass();
            return InstanceOfThisClass;
        }

        public string ReturnMessage()
        {
            Console.WriteLine("This message is from StaticClass singleton Class");
            return string.Empty;
        }
    }



    //Static Constructor and dead lock example:

    public class Experiment
    {
        static Experiment instance;

        static Experiment()
        {
            instance = new Experiment();
            Console.WriteLine("Initializing the instance on different thread");

            Thread th1 = new Thread(() => instance.InitialzeInstance());
            th1.Start();
            th1.Join();
            Console.WriteLine("Initialzation comppleted");
        }

        private void InitialzeInstance()
        {
            //all iniatiizton goes here
        }
        public void SayHello()
        {
            Console.WriteLine("Hello World");
        }
    }


    //Learnings:

//    Some important point regarding static constructor from C# Language Specification and C# Programmer's Reference :

//1) The static constructor for a class executes before any instance of the class is created.
//2) The static constructor for a class executes before any of the static members for the class are referenced.
//3) The static constructor for a class executes after the static field initializers (if any) for the class.
//4) The static constructor for a class executes at most one time during a single program instantiation
//5) A static constructor does not take access modifiers or have parameters.
//6) A static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced. 
//7) A static constructor cannot be called directly.
//8) The user has no control on when the static constructor is executed in the program. 
//9) A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.


}
