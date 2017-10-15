using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CreationPattern_Prototype_Cloning_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTobeCloned firstInstance = new ClassTobeCloned();
            ClassTobeCloned clonedObject = (ClassTobeCloned)firstInstance.Clone();
            WriteLine($"firstName : {clonedObject.firstName}");
            ReadKey();
        }
    }


    class ClassTobeCloned : ICloneable
    {
        public string firstName => "Amrut Rayabagi";
        public string LastName => "Rayabagi";
        public string Age => "31";

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
