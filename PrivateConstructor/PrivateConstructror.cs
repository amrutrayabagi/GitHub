using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings
{


    //Notes:
    //A private constructor is used for sigleton patterns.
    //where all the members of the class can be declared static.
    //

    public class PrivateConstructror
    {
        public static readonly PrivateConstructror Instance = new PrivateConstructror();
        public int counter = 0;
        const int i = 1000;
        private PrivateConstructror()
        {
            this.counter = 5;
        }

        //private PrivateConstructror ReturnClassObject()
        //{
        //    if (obj == null)
        //    {
        //        return new PrivateConstructror();
        //    }
        //    else
        //    {
        //        return obj;
        //    }
        //}

        //public int IncrementCounter()
        //{
        //    return obj.counter++;
        //}
    }

    //public class InheritedFromPrivateConstructror : PrivateConstructror
    //{
    //    private InheritedFromPrivateConstructror()
    //        : base()
    //    {

    //    }

    //}
}
