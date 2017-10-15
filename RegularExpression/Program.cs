using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string para = "Amrut Rayabagi timken electronic city. Name is amrut. Address is banashankari.";

            Regex wordCounter = new Regex(@"\b(\w|[-'])+\b");

            var result = wordCounter.Match(para);
            Console.Read();
        }
    }
}
