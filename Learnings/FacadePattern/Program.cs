
//The Facade pattern is a common software design pattern used to create a simple unified interface for a set of interfaces in a system. The Facade interface is a higher-level interface that allows easier control of a set of subsystem interfaces without affecting the subsystem interfaces. Today I'll demonstrate how to implement the Facade pattern in the .NET Framework.

//The test scenario is a set of vehicle sub controllers, which include an engine controller, traction control controller, transmission controller, and a tachometer controller. Each of these subsystems have their own API. To create a vehicle would require creating each of these controllers and making sure each controller is used appropriately to create a functioning system. To simply this API, I'll use the Facade pattern to create one Facade class -- VehicleFacade -- that's responsible for creation and orchestration of each vehicle subsystem. In this way, the end user only has to know the details of the Facade interface.

//I start by creating a new C# console application, then a Controllers directory in the project. First I add the IEngineController, which defines the contract for an engine:


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VSMFacadePattern;
using VSMFacadePattern.Controllers;
using VSMFacadePattern.Controllers;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFacade vehicle = new VehicleFacade(
                new EngineController(),
                new TransmissionController(),
                new TractionControlController(),
                new TachometerController());
            vehicle.Start();

            for (int i = 0; i < 20; i++)
            {
                System.Threading.Thread.Sleep(100);
                vehicle.Accelerate();
            }
        }
    }
}

namespace VSMFacadePattern.Controllers
{
    public interface IEngineController
    {
        bool Running { get; }
        void Start();
        void Stop();
    }

    public class EngineController : IEngineController
    {
        public bool Running { get; private set; }

        public void Start()
        {
            Running = true;
            Console.WriteLine("Engine started");
        }

        public void Stop()
        {
            Running = false;
            Console.WriteLine("Engine stopped");
        }
    }

    public interface ITachometerController
    {
        int Rpm { get; set; }
        int Limit { get; }
    }


    public class TachometerController : ITachometerController
    {
        public int Rpm { get; set; }
        public int Limit { get; private set; }

        public TachometerController()
        {
            Limit = 5000;
        }
    }

    public interface ITransmissionController
    {
        int Gear { get; set; }
        int MaxGear { get; set; }
        void ShiftUp();
        void ShiftDown();
    }

    public class TransmissionController : ITransmissionController
    {
        public int Gear { get; set; }
        public int MaxGear { get; set; }

        public void ShiftUp()
        {
            if (Gear < MaxGear)
            {
                Gear++;
                Console.WriteLine(string.Format("Shifted up to gear {0}", Gear));
            }
        }

        public void ShiftDown()
        {
            if (Gear > 0)
            {
                Gear--;
                Console.WriteLine(string.Format("Shifted down to gear {0}", Gear));
            }
        }
    }


    public interface ITractionControlController
    {
        bool Enabled { get; set; }
        void Enable();
        void Disable();
    }

    public class TractionControlController : ITractionControlController
    {
        public bool Enabled { get; set; }

        public void Enable()
        {
            Enabled = true;
            Console.WriteLine("Traction controled enabled");
        }

        public void Disable()
        {
            Enabled = false;
            Console.WriteLine("Traction control disabled");
        }
    }
}


namespace VSMFacadePattern
{
    public interface IVehicleFacade
    {
        void Start();
        void Accelerate();
        void Brake();
        void Off();
    }

    public class VehicleFacade : IVehicleFacade
    {
        private readonly IEngineController _engineController;
        private readonly ITransmissionController _transmissionController;
        private readonly ITractionControlController _tractionControlController;
        private readonly ITachometerController _tachometerController;

        public VehicleFacade(IEngineController engineController, ITransmissionController transmissionController,
            ITractionControlController tractionControlController, ITachometerController tachometerController)
        {
            _engineController = engineController;
            _transmissionController = transmissionController;
            _tractionControlController = tractionControlController;
            _tachometerController = tachometerController;
        }

        public void Start()
        {
            _engineController.Start();
            _tractionControlController.Enable();
        }

        public void Accelerate()
        {
            _tachometerController.Rpm += 500;
            if (_tachometerController.Rpm >= _tachometerController.Limit || _transmissionController.Gear == 0)
            {
                _transmissionController.ShiftUp();
            }
        }

        public void Brake()
        {
            _tachometerController.Rpm -= 500;
            if (_tachometerController.Rpm <= 1500)
                _transmissionController.ShiftDown();
        }

        public void Off()
        {
            Brake();
            _tractionControlController.Disable();
            _engineController.Stop();
        }
    }
}



