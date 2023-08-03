using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPluginLib
{
    // Implement the IPlugIn interface in your plugin classes
    internal class PlugInOne : IPlugIn
    {
        public void Execute()
        {
            Console.WriteLine("PlugIn One from FirstPluginLib Executing....");
        }
    }

    internal class PlugInTwo : IPlugIn
    {
        public void Execute()
        {
            Console.WriteLine("PlugIn Two from FirstPluginLib Executing....");
        }
    }

    internal class PlugInThree : IPlugIn
    {
        public void Execute()
        {
            Console.WriteLine("PlugIn Three from FirstPluginLib Executing....");
        }
    }
}
