using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Candidate type");
            var candidateType = ReadLine();
            InteriewFactory tf = null;
            switch (candidateType)
            {
                case "Developer":
                    tf = new DeveloperFactory();
                    break;
                case "Tester":
                    tf = new TesterFactory();
                    break;
                case "TeamLead":
                    tf = new TeamLeadFactory();
                    break;
            }
            if (tf != null)
                tf.TakeInteview();

            ReadKey();
        }
    }
}
