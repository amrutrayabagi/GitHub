using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class DelegateToStaticFunction
    {
        public delegate void LoggerHandler(string message);

        //this function accepts the parameter as function name which logs to the console.writeline

        public void LogMessages(LoggerHandler delObj, string msg)
        {
            if (delObj != null)
            {
                Console.WriteLine("Calling the function to be invoked..!");
                delObj(msg);
                Console.WriteLine("Calling the function Completed..!");
            }
        }

    }

    public class DelegateToStaticFunctionClassToBeTested
    {
        public static void LogMessage(string message)
        {
            //Console.WriteLine("Static Log Message function is being called from delegate!!!!");
            Console.WriteLine(message + "!!!!!!!");
        }

        //public static void Main()
        //{
        //    DelegateToStaticFunction classObj = new DelegateToStaticFunction();

        //    // Note: I am pointing my delegate to explicity hook to the function LogMessage of this class.
        //    //hence whenever i call this functon it calls the Logmessage function to reach out. 
        //    DelegateToStaticFunction.LoggerHandler delObj = new DelegateToStaticFunction.LoggerHandler(LogMessage);


        //    // Now pass the above delegate to the function we have written in the class DelegateToStaticFunction,
        //    //now we are passing a delegate reference as the parameter to the above function, 
        //    //this function will interrally call the hooked function(LogMessage) from the functon LogMessages();
        //    //1. Point a delegate to function to be invoked.
        //    //2. Directly can be called using the delegate reference.
        //    //3. if we dont want to call the function using this deleate, then make the function as static and call this function using the parent delegate parameterized function.


        //    classObj.LogMessages(delObj, "First call to static fucntion using delegate");







        //    //Second example.
        //    //here now we have used a file stream writer to log the messages.
        //    //This has a function LogMessages and accepting a parameter of type string and which is similar to the type of delegate we have used.
        //    //Now we can reference the same delegate to point to this FileLogger fucntion method and can be called as shown above.
        //    //We dont need to change anything in the delegate class to change it to file Logger function.

        //    FileLogger fs = new FileLogger("DelegateFile", "C:\\delegateFile.txt");
        //    delObj += new DelegateToStaticFunction.LoggerHandler(fs.LogMessages);
        //    classObj.LogMessages(delObj, "call to file logger fucntion using delegate");





        //    //Example 3: Use DelegateToStaticFunctionUsingEvents, these are triggerd using the events rather than the delegates as shown below:
        //    DelegateToStaticFunctionUsingEvents delWithEvent = new DelegateToStaticFunctionUsingEvents();
        //    delWithEvent.LogEvent += DelegateToStaticFunctionClassToBeTested.LogMessage;
        //    delWithEvent.LogEvent += fs.LogMessages;
        //    delWithEvent.LogMessages(" called using the event ");



        //    fs.CloseHandlers();
        //    Console.Read();
        //}

    }


    public class FileLogger
    {
        FileStream fs;
        StreamWriter sw;
        public FileLogger(string FileName, string filePath)
        {
            fs = new FileStream(filePath, FileMode.Create);
            sw = new StreamWriter(fs);
        }

        public void LogMessages(string messages)
        {
            sw.Write(messages);
        }

        public void CloseHandlers()
        {
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }







    //above functinality of DelegateToStaticFunction class can be achived using events.
    //we have to declare an event and type should be of Delegate.
    //Instead of having a function LogMessages with delegate parameter,we can use the event to raise the function as below:

    public class DelegateToStaticFunctionUsingEvents
    {
        public delegate void LoggerHandler(string message);

        public event LoggerHandler LogEvent;
        //this function accepts the parameter as function name which logs to the console.writeline

        public void LogMessages(string Message)
        {
            Console.WriteLine("Calling the function to be invoked..!");
            LogEvent(Message);
            Console.WriteLine("Calling the function Completed..!");
        }

    }


}
