using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class DLR
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToStringX("xxyyyzzzzzzz".GroupBy(x => x)));
            Console.WriteLine(ToStringX(new int[] { 1, 23, 5, 6, 7, 7, 8, 8, 98, 9, 9 }.GroupBy(x => x)));
            Console.WriteLine(ToStringX(new string[] { "Amruth", "Amruth2" , "Amruth1" , "Amruth" , "Amruth2" , "Amruth3" , "Amruth1" , "Amruth" }.GroupBy(x => x)));
            Console.ReadKey();
        }

        private static string PrintGroupKey<Tkey, TElement>(IGrouping<Tkey, TElement> x)
        {
            return "Grouping Key " + x.Key + " is: ";
        }

        private static string PrintGroupKey(object value)
        {
            return null;
        }



        public static string ToStringX(object value)
        {
            if (value == null) return "<null>";
            if (value is string) return (string)value;
            if (value.GetType().IsPrimitive) return value.ToString();
            StringBuilder sb = new StringBuilder();
            var key = PrintGroupKey((dynamic)value);
            if (key != null)
            {
                sb.Append(key + " ");
            }
            if (value is IEnumerable)
            {
                foreach (object element in (IEnumerable)value)
                {
                    sb.Append(ToStringX(element) + " ");
                }
            }
            if (sb.Length == 0) sb.Append(value.ToString());

            return "\r\n" + sb.ToString();
        }
    }
}
