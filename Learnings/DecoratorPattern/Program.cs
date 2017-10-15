using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle honda = new HondaVehicle();
            Console.WriteLine("Before Discount:{0}", honda.Price);

            SpecialOffer offer = new SpecialOffer(honda);
            offer.discountedPercentage = 10;
            Console.WriteLine("After Discount:{0}", offer.DiscountedPrice());
            Console.ReadKey();
        }

        public interface IVehicle
        {
            string Make { get; set; }
            string Model { get; set; }
            double Price { get; set; }
        }


        class HondaVehicle : IVehicle
        {

            public string Make
            {
                get
                {
                    return "Honda";
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public string Model
            {
                get
                {
                    return "2015";
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public double Price
            {
                get
                {
                    return 1000000;
                }
                set
                {
                    throw new NotImplementedException();
                }
            }
        }

        //decorator pattern.
        public abstract class VehicleDecorator : IVehicle
        {
            private IVehicle vehicle;
            public VehicleDecorator(IVehicle veh)
            {
                vehicle = veh;
            }

            public string Make
            {
                get
                {
                    return vehicle.Make;
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public string Model
            {
                get
                {
                    return vehicle.Model;
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public double Price
            {
                get
                {
                    return vehicle.Price;
                }
                set
                {
                    throw new NotImplementedException();
                }
            }
        }



        class SpecialOffer : VehicleDecorator
        {
            public SpecialOffer(IVehicle vehicle)
                : base(vehicle)
            {

            }

            public double discountedPercentage { set; get; }

            public double DiscountedPrice()
            {
                return base.Price - base.Price * (this.discountedPercentage / 100);
            }
        }




        //Test created to check the inheritance between abstract to abstarct.
        abstract class test : VehicleDecorator
        {
            public test(IVehicle veh)
                : base(veh)
            {

            }
        }
    }
}
