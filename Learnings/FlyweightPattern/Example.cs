using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    class Example
    {
        static void Main()
        {
            Ishape obj;
            obj = ShapeFactory.GetObject("Circle");
            obj.PrintShape();


            obj = ShapeFactory.GetObject("Rectangle");
            obj.PrintShape();
            Console.ReadKey();
        }
    }

    interface Ishape
    {
        void PrintShape();
    }



    class Cirle : Ishape
    {
        public void PrintShape()
        {
            Console.WriteLine("cirle is printed");
        }
    }

    class Rectangle : Ishape
    {
        public void PrintShape()
        {
            Console.WriteLine("Rectange is printed");
        }
    }

    class ShapeFactory
    {
        static Dictionary<string, Ishape> objectCollection = new Dictionary<string, Ishape>();

        public static Ishape GetObject(string objectKey)
        {
            if (objectCollection.ContainsKey(objectKey)) { return objectCollection[objectKey] as Ishape; }

            switch (objectKey)
            {
                case "Circle":
                    objectCollection.Add("Circle", new Cirle()); break;
                case "Rectangle":
                    objectCollection.Add("Rectangle", new Rectangle()); break;
                default:
                    Console.WriteLine("Dont have object of your interest!.");
                    break;
            }
            return objectCollection[objectKey] as Ishape;
        }
    }

}

