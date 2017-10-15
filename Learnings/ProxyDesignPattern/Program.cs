//In computer programming, the proxy pattern is a software design pattern.

//A proxy, in its most general form, is a class functioning as an interface to something else. The proxy could interface to anything: a network connection, a large object in memory, a file, or some other resource that is expensive or impossible to duplicate.

//A well-known example of the proxy pattern is a reference counting pointer object.

//In situations where multiple copies of a complex object must exist, the proxy pattern can be adapted to incorporate the flyweight pattern in order to reduce the application's memory footprint. Typically, one instance of the complex object and multiple proxy objects are created, all of which contain a reference to the single original complex object. Any operations performed on the proxies are forwarded to the original object. Once all instances of the proxy are out of scope, the complex object's memory may be deallocated.

//Contents  [hide] 
//1 Usage
//2 Possible Usage Scenarios
//3 Example
//3.1 C++
//3.2 C#
//3.3 Java
//4 See also
//5 References
//6 External links
//Usage[edit]
//The proxy design pattern allows you to provide an interface to other objects by creating a wrapper class as the proxy. The wrapper class, which is the proxy, can add additional functionality to the object of interest without changing the object's code. Below are some of the common examples in which the proxy pattern is used,

//Adding security access to an existing object. The proxy will determine if the client can access the object of interest.
//Simplifying the API of complex objects. The proxy can provide a simple API so that the client code does not have to deal with the complexity of the object of interest.
//Providing interface for remote resources, such as web service or REST resources.
//Coordinating expensive operations on remote resources by asking the remote resources to start the operation as soon as possible before accessing the resources.
//Adding a thread-safe feature to an existing class without changing the existing class's code.
//In short, the proxy is the object that is being called by the client to access the real object behind the scene.

//Possible Usage Scenarios[edit]
//Remote Proxy – Represents an object locally which belongs to a different address space. Think of an ATM implementation, it will hold proxy objects for bank information that exists in the remote server.

//Virtual Proxy – In place of a complex or heavy object, use a skeleton representation. When an underlying image is huge in size, just represent it using a virtual proxy object and on demand load the real object. You feel that the real object is expensive in terms of instantiation and so without the real need we are not going to use the real object. Until the need arises we will use the virtual proxy.

//Protection Proxy – Are you working on an MNC? If so, we might be well aware of the proxy server that provides us internet by restricting access to some sort of websites like public e-mail, social networking, data storage etc. The management feels that, it is better to block some content and provide only work related web pages. Proxy server does that job. This is a type of proxy design pattern.

//http://en.wikipedia.org/wiki/Proxy_pattern
//http://www.dotnet-tricks.com/Tutorial/designpatterns/P40W140713-Proxy-Design-Pattern---C#.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main1(string[] args)
        {
            ProxyObject pObj = new ProxyObject();
            pObj.PerformTask();
            Console.ReadKey();
        }

        interface Isubject
        {
            void PerformTask();
        }


        class RealObject : Isubject
        {

            public void PerformTask()
            {
                Console.WriteLine("Your request is called via proxy object!.");
            }
        }

        class ProxyObject : Isubject
        {
            RealObject realObj;
            public void PerformTask()
            {
                if (realObj == null) { realObj = new RealObject(); }
                realObj.PerformTask();
            }
        }
    }
}
