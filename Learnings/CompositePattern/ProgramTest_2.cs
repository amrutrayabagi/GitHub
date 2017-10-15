using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class ProgramTest_2
    {
        static void Main(string[] args)
        {

        }
    }

    interface IComponent<T> {
        void Add(T item);

        void Remove(T item);

        
    }
}
