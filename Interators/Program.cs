using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interators
{
    class Program : System.Dynamic.DynamicObject
    {
        public override bool TryInvokeMember(System.Dynamic.InvokeMemberBinder binder, object[] args, out object result)
        {
            return base.TryInvokeMember(binder, args, out result);
        }


        static void Fibo(int fibCount)
        {
            for (int i = 0, prvFib = 1, curFib = 1; i < fibCount; i++)
            {
                int newFib = curFib + prvFib;
                //yield return prvFib;
                Console.Write(curFib + " ");
                prvFib = curFib;
                curFib = newFib;
            }
        }

        static void Main(string[] args)
        {
            //foreach (int fib in Fibo(6))
            //    Console.Write(fib + " ");
            Fibo(6);

            Console.WriteLine("Amrut Rayabagi".FirstElement());

            dynamic d = new Program();
            d.NonExistantantMethod();
            Console.ReadLine();
        }


    }


    //This must be specified in the extension static class.
    public static class GenericExtensionClass
    {
        public static T FirstElement<T>(this IEnumerable<T> sequence)
        {

            foreach (T element in sequence)
                return element;
            return sequence.ToList()[0];
        }
    }
}
