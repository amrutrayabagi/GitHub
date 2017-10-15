using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate T TransaFormer<T>(T param);
    public class GenericDelegates
    {
        public static void TransForm<T>(T[] values, TransaFormer<T> objDel)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = objDel.Invoke(values[i]);
            }

        }
    }
}
