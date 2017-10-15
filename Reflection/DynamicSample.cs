using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class DynamicSample
    {
        static void Main_1(string[] args)
        {
            var dynMethod = new DynamicMethod("AmruthMethod", typeof(DynamicSample), new Type[] { typeof(string), typeof(string) });
            ILGenerator ilGenerator = dynMethod.GetILGenerator();
            ilGenerator.EmitWriteLine("Amruth Rayabagi");
            ilGenerator.Emit(OpCodes.Ret);

        }
    }
}
