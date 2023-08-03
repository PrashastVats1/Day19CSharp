using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReflectionPracticalEx
{
    internal class PlugInTwo : IPlugIn
    {
        public void Execute()
        {
            Console.WriteLine("PlugIn Two Executing....");
        }
    }
}
