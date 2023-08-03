using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReflectionPracticalEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlugInManager manager = new PlugInManager();
            manager.LoadPlugins("D:\\Mphasis\\Live Session\\Day19\\ConAppReflectionPracticalEx\\FirstPluginLib\\bin\\Debug\\");
            manager.ExecutePlugIns();
            Console.ReadKey();
        }
    }
}
