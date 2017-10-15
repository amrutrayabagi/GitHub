using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Structural_BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Plain shirt object
            Shirt collorShirt = new CollorShirt();
            WriteLine($"Description :{collorShirt._description} Price :{collorShirt.Price()} ");

            DesignerShirt shirt = new DesignerShirt(collorShirt);
            WriteLine($"Description :{shirt._description} Price :{shirt.Price()} ");


            TraiditonalShirt tshirt = new TraiditonalShirt(collorShirt);
            WriteLine($"Description :{tshirt._description} Price :{tshirt.Price()} ");

            Read();
        }
    }

    public abstract class Shirt
    {
        public abstract string _description { get; }

        public abstract double Price();
    }


    public class CollorShirt : Shirt
    {
        public override string _description
        {
            get
            {
                return "Collor Shirt";
            }
        }

        public override double Price()
        {
            return 150;
        }
    }

    public class RoundNeckShirt : Shirt
    {
        public override string _description
        {
            get
            {
                return "Round Neck Shirt";
            }
        }

        public override double Price()
        {
            return 140;
        }
    }


    abstract public class ShirtDecorator
    {
        abstract public string _description { get; }
    }

    //Designer shirt decorator class
    public class DesignerShirt : ShirtDecorator
    {
        Shirt _shirt;

        public DesignerShirt(Shirt shirt)
        {
            _shirt = shirt;
        }

        public override string _description
        {
            get
            {
                return _shirt._description + "Designer";
            }
        }

        public double Price()
        {
            return _shirt.Price() + 50;
        }
    }

    //Designer shirt decorator class
    public class TraiditonalShirt : ShirtDecorator
    {
        Shirt _shirt;

        public override string _description
        {
            get
            {
                return _shirt._description + "Traditional"; 
            }
        }

        public TraiditonalShirt(Shirt shirt)
        {
            _shirt = shirt;
        }

        public double Price()
        {
            return _shirt.Price() + 100;
        }
    }
}
