using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReflectionPracticalEx
{
    internal class PlugInOne : IPlugIn
    {
        public void Execute()
        {
            Console.WriteLine("PlugIn One Executing....");
        }
    }
}
