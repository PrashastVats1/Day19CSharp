using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReflectionExOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EventInfo[] events = new EventInfo[args.Length];
            //FieldInfo[] fields;
            //MemberInfo[] members;
            //MethodInfo[] methods;
            //ConstructorInfo[] constructor;

            Type type = typeof(OurClass);
            PropertyInfo[] properties = type.GetProperties();
            MethodInfo[] methodInfos = type.GetMethods();
            Console.WriteLine("Properties in Our Class");
            foreach(var prop in properties)
            {
                Console.WriteLine("Property: " + prop.Name);
            }
            Console.WriteLine("Methods in Our Class");
            foreach(var method in methodInfos)
            {
                Console.WriteLine("Methods: " + method.Name);
            }
            Console.ReadKey();
        }
    }
}
