
//Chain of Responsibility Design Pattern - C#
//Posted By : Shailendra Chauhan, 16 Jul 2013 Updated On : 05 Feb 2014
// Total Views : 26,443     Version Support : All C# & .Net
 
//  Keywords : when to use chain of responsibility design pattern, chain of responsibility pattern with example in .net, real life example of chain of responsibility pattern
//Chain of Responsibility pattern falls under Behavioral Design Patterns of Gang of Four (GOF) Design Patterns in .Net. The chain of responsibility pattern is used to process a list or chain of various types of request and each of them may be handle by a different handler. In this article, I would like share what is chain of responsibility pattern and how is it work?
//What is Chain of Responsibility Pattern
//The chain of responsibility pattern is used to process a list or chain of various types of request and each of them may be handle by a different handler. This pattern decouples sender and receiver of a request based on type of request.
//In this pattern, normally each receiver (handler) contains reference to another receiver. If one receiver cannot handle the request then it passes the same to the next receiver and so on.
//Chain of Responsibility Pattern - UML Diagram & Implementation
//The UML class diagram for the implementation of the chain of responsibility design pattern is given below:

//The classes, interfaces and objects in the above UML class diagram are as follows:
//Client
//This is the class that generates the request and passes it to the first handler in the chain of responsibility.
//Handler
//This is the abstract class that contains a member that holds the next handler in the chain and an associated method to set this successor. It also has an abstract method that must be implemented by concrete classes to handle the request or pass it to the next object in the pipeline.
//ConcreteHandlerA & ConcreteHandlerB
//These are concrete handlers classes inherited from Handler class. These include the functionality to handle some requests and pass others to the next item in the chain of request.
//http://www.dotnet-tricks.com/Tutorial/designpatterns/HHM5160713-Chain-of-Responsibility-Design-Pattern---C#.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    class Program1
    {
        static void Main(string[] args)
        {

            //define the handlers.
            Handler firstHandler = new FirstHandler();
            Handler secondHandler = new SecondHandler();


            //Assign the first handler successor to the Second Handler.
            firstHandler.SetNextSuccessor(secondHandler);

            Console.WriteLine("Input your request");
            string request = Console.ReadLine();
            firstHandler.HandleRequest(Convert.ToInt16(request));
            Console.ReadKey();
        }



        public abstract class Handler
        {
            protected Handler successor;

            public abstract void HandleRequest(int request);

            public void SetNextSuccessor(Handler nextSuccessor)
            {
                successor = nextSuccessor;
            }
        }


        public class FirstHandler : Handler
        {
            public override void HandleRequest(int request)
            {
                if (request == 1)
                {
                    Console.WriteLine("yes this has to be served by First Handler!");
                }
                else
                {
                    Console.WriteLine("Dude this is not my cup of tee. You must find my boss or successor.!");
                    Console.WriteLine("Wait a second. i will redirect you!");
                    successor.HandleRequest(request);
                }
            }
        }

        class SecondHandler : Handler
        {
            public override void HandleRequest(int request)
            {
                if (request > 1)
                {
                    Console.WriteLine("Your request is being handled.");
                    Console.WriteLine("Request is done.");
                }
                else
                {
                    Console.WriteLine("Dude this is not my cup of tee. You must find my boss or successor.!");
                    Console.WriteLine("I am sorry, i dont have my successors. I am the BOSSSS!");
                }
            }
        }
    }
}
