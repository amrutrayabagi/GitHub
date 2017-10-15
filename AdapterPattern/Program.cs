using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBike cycle = new BtweenBike();
            cycle.IncreaseAcceleration(1);
            cycle.IncreaseAcceleration(1);
            cycle.IncreaseAcceleration(1);
            cycle.IncreaseAcceleration(1);
            cycle.IncreaseAcceleration(1);
            cycle.Break();

            //Client wants to use Ibike INteface but wants to control MarutiSuzikiBoleno car. 
            //For this we have implemened CarAdapter for marutisuziki but implements IBike.

            IBike carControl = new CarAdapter();
            carControl.IncreaseAcceleration(1);
            carControl.IncreaseAcceleration(1);
            carControl.IncreaseAcceleration(1);
            carControl.IncreaseAcceleration(1);
            carControl.IncreaseAcceleration(1);
            carControl.IncreaseAcceleration(1);
            carControl.IncreaseAcceleration(1);
            carControl.IncreaseAcceleration(1);
            carControl.IncreaseAcceleration(1);
            carControl.Break();

            ReadKey();


        }
    }

    interface Car
    {

        int currentSpeed { get; set; }
        int MaxSpeed { get; }
        int NumberOfGears { get; }

        void Accelerate(int step);

        void ApplyBreakSequential(int step);

        void ApplyDiskBread();

    }

    public class MarutiSuzikiBoleno : Car
    {
        public int currentSpeed { get; set; }

        public int MaxSpeed
        {
            get
            {
                return 400;
            }
        }

        public int NumberOfGears
        {
            get
            {
                return 5;
            }
        }

        public void Accelerate(int step)
        {
            if (currentSpeed > MaxSpeed)
            {
                currentSpeed = MaxSpeed;
                return;
            }
            currentSpeed += step * 10;
            WriteLine($"Car crusing at {currentSpeed} KMPH");
        }

        public void ApplyBreakSequential(int step)
        {
            if (currentSpeed <= 0)
            {
                currentSpeed = 10;
                return;
            }
            currentSpeed -= step * 10;
            WriteLine($"Car crusing at {currentSpeed} KMPH");
        }

        public void ApplyDiskBread()
        {
            currentSpeed = 0;
            WriteLine($"Car slowed down to {currentSpeed} KMPH");
        }

    }

    interface IBike
    {
        void IncreaseAcceleration(int step);
        void Break();
    }

    public class BtweenBike : IBike
    {
        int speed;
        public void Break()
        {
            Console.WriteLine("Bike is stopped");
        }

        public void IncreaseAcceleration(int step)
        {
            speed += step * 5;
            WriteLine($"Bike running at {speed} KMPH");
        }
    }


    public class CarAdapter : MarutiSuzikiBoleno, IBike
    {
        public void Break()
        {
            base.ApplyDiskBread();
        }

        public void IncreaseAcceleration(int step)
        {
            base.Accelerate(step);
        }
    }
}
