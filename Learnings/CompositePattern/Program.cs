
//http://www.dofactory.com/net/composite-design-pattern

//Participants

//    The classes and objects participating in this pattern are:

//    Component   (DrawingElement)
//        declares the interface for objects in the composition.
//        implements default behavior for the interface common to all classes, as appropriate.
//        declares an interface for accessing and managing its child components.
//        (optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate. 
//    Leaf   (PrimitiveElement)
//        represents leaf objects in the composition. A leaf has no children.
//        defines behavior for primitive objects in the composition. 
//    Composite   (CompositeElement)
//        defines behavior for components having children.
//        stores child components.
//        implements child-related operations in the Component interface. 
//    Client  (CompositeApp)
//        manipulates objects in the composition through the Component interface. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class Program
    {
        static void Main_1(string[] args)
        {

            Composite objA = new Composite("A");
            objA.add(new Composite("B"));
            objA.add(new Composite("C"));

            objA.Get("B").add(new LeafNode("D"));
            objA.Get("B").add(new LeafNode("E"));


            objA.Get("C").add(new LeafNode("F"));

            objA.display(1);
            Console.ReadKey();
        }

        abstract class Component
        {
            public Component(string name)
            {
                this.name = name;
            }

            public string name { get; set; }

            public abstract void add(Component child);
            public abstract void Remove(Component child);
            public abstract Component Get(string child);
            public abstract void display(int depth);
        }

        class Composite : Component
        {

            public Composite(string name)
                : base(name)
            {

            }

            List<Component> childObjects = new List<Component>();

            public override void add(Component child)
            {
                childObjects.Add(child);
            }

            public override void Remove(Component child)
            {
                childObjects.Remove(child);
            }

            public override void display(int depth)
            {
                Console.WriteLine(new String('-', depth) + name);
                foreach (Component obj in childObjects)
                {
                    obj.display(depth + 2);
                }
            }

            public override Component Get(string child)
            {

                Component obj = (from e in childObjects where e.name == child select e).FirstOrDefault();
                return obj;
            }
        }

        class LeafNode : Component
        {
            public LeafNode(string name) : base(name) { }
            public override void add(Component child)
            {
                Console.WriteLine("You cannot add items to the leaf node ");
            }

            public override void Remove(Component child)
            {
                Console.WriteLine("You cannot remove items to the leaf node ");
            }

            public override void display(int depth)
            {
                Console.WriteLine("--Leaf:{0}", name);
            }

            public override Component Get(string child)
            {
                return this;
            }
        }
    }
}
