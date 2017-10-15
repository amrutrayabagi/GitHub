using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Inteview
    {
        public abstract void InProcess();
    }

    public class TeamLeadInteview : Inteview
    {
        public override void InProcess()
        {
            Console.WriteLine("Team Lead Inteview is compelted!");
        }
    }

    public class DeveloperInteview : Inteview
    {
        public override void InProcess()
        {
            Console.WriteLine("Developer Inteview is compelted!");
        }
    }

    public class TesterInteview : Inteview
    {
        public override void InProcess()
        {
            Console.WriteLine("TesterInteview is compelted!");
        }
    }

    public abstract class InteriewFactory
    {

        public abstract void TakeInteview();
    }

    public class DeveloperFactory : InteriewFactory
    {
        public override void TakeInteview()
        {
            new DeveloperInteview().InProcess();
        }
    }

    public class TeamLeadFactory : InteriewFactory
    {
        public override void TakeInteview()
        {
            new DeveloperInteview().InProcess();
        }
    }

    public class TesterFactory : InteriewFactory
    {
        public override void TakeInteview()
        {
            new DeveloperInteview().InProcess();
        }
    }


}
