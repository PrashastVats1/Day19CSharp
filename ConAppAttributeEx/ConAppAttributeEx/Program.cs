using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
using System.Runtime.InteropServices;

namespace ConAppAttributeEx
{
    //Task1: Create a Custom Attribute
    [AttributeUsage(AttributeTargets.Class, AllowMultiple =false)]
    public class CustomInfoAttribute : Attribute
    {
        public string ClassName { get; }
        public int VersionNumber { get; }
        public string AdditionalInfo { get; }
        public CustomInfoAttribute(string className, int versionNumber, string additionalInfo)
        {
            ClassName = className;
            VersionNumber = versionNumber;
            AdditionalInfo = additionalInfo;
        }
    }
    //Task2: Reflection on Custom Attribute
    [CustomInfo("MyClass",1,"This is a custom attribute example.")]
    public class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("Welcome to My Method");
        }
    }
    //Task3: Dynamic Method Invocation
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {

            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by 0");
                return 0;
            }
            return a / b;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task2: Reflection on Custom Attribute
            Type myClassType = typeof(MyClass);
            var customAttribute = myClassType.GetCustomAttribute<CustomInfoAttribute>();

            Console.WriteLine("Task 2: Reflection on Custom Attribute");
            Console.WriteLine($"Class Name: {customAttribute.ClassName}");
            Console.WriteLine($"Version Number: {customAttribute.VersionNumber}");
            Console.WriteLine($"Additional Info: {customAttribute.AdditionalInfo}");

            //Task3: Dynamic Method Invocation
            var calculator = new Calculator();
            Console.WriteLine("\nTask 3: Dynamic Method Invocation");
            Console.WriteLine("Available Methods: Add, Subtract, Multiply, Divide");
            Console.WriteLine("Enter method name");
            string methodName = Console.ReadLine();

            MethodInfo method = typeof(Calculator).GetMethod(methodName);
            if (method != null)
            {
                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = int.Parse(Console.ReadLine());
                int result = (int)method.Invoke(calculator, new object[] { num1, num2 });
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid method name");
            }
            Console.ReadKey();
        }
    }
}
