using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    public class FlyweightFactory
    {
        private Hashtable _flyweights = new Hashtable();

        public Flyweight GetFlyweight(string key)
        {
            if (_flyweights.Contains(key))
            {
                return _flyweights[key] as Flyweight;
            }
            else
            {
                ConcreteFlyweight newFlyweight = new ConcreteFlyweight();

                // Set properties of new flyweight here.

                _flyweights.Add(key, newFlyweight);
                return newFlyweight;
            }
        }
    }

    public interface Flyweight
    {
        void StatefulOperation(object o);


    }
    public class ConcreteFlyweight : Flyweight
    {
        public void StatefulOperation(object o)
        {
            Console.WriteLine(o);
        }
    }

    public class UnsharedFlyweight : Flyweight
    {
        private object _state;

        public void StatefulOperation(object o)
        {
            _state = o;
            Console.WriteLine(o);
        }

    }
}
