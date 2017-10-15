using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.cs
{
    public class C2BitAddition
    {
        public void Add()
        {
            byte[] firstArr = { 1, 0, 1, 0, 1, 0 };
            byte[] decondArr = { 1, 1, 1, 1, 1, 1 };
            byte[] finalArray = new byte[firstArr.Length + 1];
            byte extra = 0;
            for (int i = firstArr.Length - 1; i >= 0; i--)
            {
                int finalResult = firstArr[i] + decondArr[i] + extra;
                switch (finalResult)
                {
                    case 0:
                        finalArray[i+1] = 0;
                        extra = 0;
                        break;
                    case 1:

                        finalArray[i + 1] = 1;
                        extra = 0;
                        break;
                    case 2:

                        finalArray[i + 1] = 0;
                        extra = 1;
                        break;
                    case 3:

                        finalArray[i + 1] = 1;
                        extra = 1;
                        break;
                }
                //if (firstArr[i] == 1 && decondArr[i] == 1)
                //{
                //    extra = 1;
                //}
                //extra = Convert.ToByte((extra + firstArr[i] + decondArr[i]) % 2);
                //finalArray[i + 1] = Convert.ToByte((firstArr[i] + decondArr[i]) % 2);
            }
            finalArray[0] = extra;
            foreach (byte data in finalArray)
            {
                Console.Write(" " + data);

            }
            Console.Read();
        }

    }
}
