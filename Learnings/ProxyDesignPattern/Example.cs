using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyDesignPattern
{
    class Example
    {
        static void Main()
        {
            ProxyDriver pObj = new ProxyDriver(new Driver("Chota Amrut", 15));
            pObj.DriveCar();

            pObj = new ProxyDriver(new Driver("Amrut", 28));
            pObj.DriveCar();
            Console.ReadKey();
        }


        //pObj;


        //pObj = new ProxyDriver(new Driver("Amrut", 28));
    }

    interface Icar
    {
        void DriveCar();
    }

    //actual Object class.

    class DriveCar : Icar
    {

        void Icar.DriveCar()
        {
            Console.WriteLine("You are driving car!");
        }
    }

    class ProxyDriver : Icar
    {
        private Driver driver;
        private Icar realCar;

        public ProxyDriver(Driver driver)
        {
            this.driver = driver;
            realCar = new DriveCar();
        }

        public void DriveCar()
        {
            if (this.driver.Age < 16)
            {
                Console.WriteLine("Your age is less than required age");
            }
            else
            {
                realCar.DriveCar();
            }
        }
    }

    class Driver
    {
        public Driver(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
