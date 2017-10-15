using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            //during run time, type casting occurs from the base class to the derived class.
            //Instance will be built based on this situation.
            AbstractDemo obj = new DerivedAbstract();
            obj.ReturnString();
        }
    }


    public class AbstractDemo : Program
    {
        public AbstractDemo()
        {

        }
        public virtual string ReturnString()
        {
            return "AbstractDemo";
        }
    }

    public class DerivedAbstract : AbstractDemo
    {
        public override string ReturnString()
        {
            return "amrut rayabagi";
        }
    }


}
