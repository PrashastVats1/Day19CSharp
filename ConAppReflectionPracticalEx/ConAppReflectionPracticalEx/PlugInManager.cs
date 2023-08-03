using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConAppReflectionPracticalEx
{
    public class PlugInManager
    {
        List<IPlugIn> plugins;
        public PlugInManager()
        {
            plugins = new List<IPlugIn>();
        }
        public void LoadPlugins(string pluginDirectory = null)
        {
            string path = pluginDirectory ?? AppDomain.CurrentDomain.BaseDirectory;
            var pluginFiles = Directory.GetFiles(path, ".dll");
            foreach(var file  in pluginFiles)
            {
                Assembly assembly = Assembly.Load(file);
                var pluginTypes = assembly.GetTypes().Where(type => typeof(IPlugIn).IsAssignableFrom(type));
                foreach (var pluginType in pluginTypes)
                {
                    IPlugIn plugIn = (IPlugIn)Activator.CreateInstance(pluginType);
                    plugins.Add(plugIn);
                }
            }
        }
        public void ExecutePlugIns()
        {
            Console.WriteLine("Executing plugins");
            foreach(var plugin in plugins)
            {
                plugin.Execute();
            }
        }
    }
}
