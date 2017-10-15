//reference Site: http://www.dotnet-tricks.com/Tutorial/designpatterns/23JE110913-Command-Design-Pattern---C#.html

//    Command Design Pattern - C#
//Posted By : Shailendra Chauhan, 11 Sep 2013 Updated On : 23 Mar 2014
// Total Views : 27,839     Version Support : All C# & .Net

//  Keywords : when to use command design pattern, command pattern with example in .net, real life example of command pattern
//Command pattern falls under Behavioral Pattern of Gang of Four (GOF) Design Patterns in .Net. The command pattern is commonly used in the menu systems of many applications such as Editor, IDE etc. In this article, I would like share what is command pattern and how is it work?
//What is Command Pattern
//In this pattern, a request is wrapped under an object as a command and passed to invoker object. Invoker object pass the command to the appropriate object which can handle it and that object executes the command. This handles the request in traditional ways like as queuing and callbacks.
//This pattern is commonly used in the menu systems of many applications such as Editor, IDE etc.
//Command Pattern - UML Diagram & Implementation
//The UML class diagram for the implementation of the command design pattern is given below:

//The classes, interfaces and objects in the above UML class diagram are as follows:
//Client
//This is the class that creates and executes the command object.
//Invoker
//Asks the command to carry out the action.
//Command
//This is an interface which specifies the Execute operation.
//ConcreteCommand
//This is a class that implements the Execute operation by invoking operation(s) on the Receiver.
//Receiver
//This is a class that performs the Action associated with the request.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace CommandPatternExample
{
    class Client
    {
        static void Main1(string[] args)
        {
            Invoker invObject = new Invoker();

            //decide the output method based on the command parameter.
            //1-Console
            //2-File

            Console.WriteLine("Enter the output method");
            string outputType = Console.ReadLine();
            Ireciever recObject;
            switch (outputType)
            {
                case "1": recObject = new ConsoleReciever(); break;
                case "2": recObject = new FileReciever(); break;
                default: recObject = new ConsoleReciever(); break;
            }

            ConcreteCommand concreteObject = new ConcreteCommand(recObject);

            //Set the invoker Command object to Invoker Class.
            invObject.command = concreteObject;
            invObject.ExecuteCommand();
            Console.ReadKey();
        }
    }
    //This will be invoker class.
    //This is used from clients to execute any command class which is inherinting ICommand interface.
    class Invoker
    {
        public ICommand command { get; set; }

        public void ExecuteCommand()
        {
            command.ExecuteCommand();
        }

    }


    interface ICommand
    {
        //Specifying the properties.
        //int MyProperty { get; set; }

        //Specify the local variables.
        void ExecuteCommand();
    }

    //actual object to trigger the reciever.
    class ConcreteCommand : ICommand
    {
        Ireciever lcReciever;
        public ConcreteCommand(Ireciever reciever)
        {
            lcReciever = reciever;
        }

        public void ExecuteCommand()
        {
            lcReciever.ExecuteCommand();
        }
    }


    //Actual Reciver class to execute the command object.
    //This will be triggered from the ConcretecommandClass.

    interface Ireciever
    {
        void ExecuteCommand();
    }

    class ConsoleReciever : Ireciever
    {
        public void ExecuteCommand()
        {
            Console.WriteLine("Command is being executed....!");
            Console.WriteLine("Execution is completed....!");
        }
    }


    class FileReciever : Ireciever
    {
        public void ExecuteCommand()
        {
            //Log the same result to the file.
            File.WriteAllLines("fileOutput", new string[] { "File Command is being executed....!", "File Execution is completed....!" });
        }
    }






}
