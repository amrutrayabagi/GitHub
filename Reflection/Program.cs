using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {

        //Delegate
        delegate int IntFunc(int i);
        static void Main_1(string[] args)
        {

            ////Invoke CalculateSquare and Cube using delegate Normally
            //IntFunc i = DelegateProgram.CalcualteSquare;
            //Console.WriteLine(i(8));
            //i = DelegateProgram.CalcualteCube;
            //Console.WriteLine(i(8));




            ////Call the same using reflection concepts.
            //Delegate t = Delegate.CreateDelegate(typeof(IntFunc), typeof(DelegateProgram), "CalcualteSquare");
            //Console.WriteLine(t.DynamicInvoke(new object[] { 8 }));

            //Delegate t1 = Delegate.CreateDelegate(typeof(IntFunc), typeof(DelegateProgram), "CalcualteCube");
            //Console.WriteLine(t1.DynamicInvoke(new object[] { 8 }));

            //Console.Read();


            //Console.WriteLine("*********Reflection: Enumerating Members of class *********");
            //IEnumerable<MemberInfo> publicMethods = typeof(DelegateProgram).GetTypeInfo().DeclaredMembers();

            string value1 = "123";
            int value2 = 123;


            char[] values1, values2 = new char[value1.Length];
            values1 = value1.ToCharArray();

            for (int i = 0; value2 != 0; value2 /= 10, i++)
                values2[i] = Convert.ToChar(value2 % 10);


            if (values1.Length == values2.Length)
            {
                bool equal = true;
                for (int i = 0; i <= values1.Length - 1; i++)
                {
                    if (values1[i] == values2[i])
                    {
                        continue;
                    }
                    else { equal = false; break; }
                }

                if (equal)
                {
                    for (int lenghtCount = values2.Length; lenghtCount > 0; lenghtCount--)
                    {
                        Console.Write(values2[lenghtCount]);
                    }
                }
                else { Console.Write("0"); }
            }
            else
            {
                Console.Write("0");
            }

        }


    }

    public class DelegateProgram
    {


        public static int CalcualteSquare(int i)
        {
            return i * i;
        }

        public static int CalcualteCube(int i)
        {
            return i * i * i;
        }
    }
}
