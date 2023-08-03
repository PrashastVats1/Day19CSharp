using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConAppAssignment22_Reflections
{
    internal class Program
    {
        //Map Properties from Source to Destination using Reflection
        static void MapProperties<T, U>(T source, U destination)
        {
            Type sourceType = typeof(T);
            Type destinationType = typeof(U);

            PropertyInfo[] sourceProperties = sourceType.GetProperties();
            PropertyInfo[] destinationProperties = destinationType.GetProperties();

            foreach (var sourceProperty in sourceProperties)
            {
                PropertyInfo destinationProperty = Array.Find(destinationProperties, p => p.Name == sourceProperty.Name && p.PropertyType == sourceProperty.PropertyType);
                if (destinationProperty != null && destinationProperty.CanWrite)
                {
                    destinationProperty.SetValue(destination, sourceProperty.GetValue(source));
                }
                else
                {
                    Console.WriteLine($"Ignoring property: {sourceProperty.Name}");
                }
            }
            foreach (var destinationProperty in destinationProperties)
            {
                PropertyInfo sourceProperty = Array.Find(sourceProperties, p => p.Name == destinationProperty.Name && p.PropertyType == destinationProperty.PropertyType);
                if (sourceProperty == null)
                {
                    Console.WriteLine($"Ignoring property: {destinationProperty.Name}");
                }
            }
        }


        static void Main(string[] args)
        {
            //Creating an instance of the destination class
            Destination destination = new Destination();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the properties for the Source class");
                    Console.Write("ID: \t");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Name: \t");
                    string name = Console.ReadLine();
                    Console.Write("Age: \t");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Gender: \t");
                    string gender = Console.ReadLine();

                    //Create an instance of Source class and set user input values
                    Source source = new Source()
                    {
                        Id = id,
                        Name = name,
                        Age = age,
                        Gender = gender
                    };
                    //Dynamic Property Mapping implemeted using reflection
                    MapProperties(source, destination);
                    //Values of Properties in Destination class are displayed
                    Console.WriteLine("Destination Properties");
                    Console.WriteLine($"ID: \t{destination.Id}");
                    Console.WriteLine($"Name: \t{destination.Name}");
                    Console.WriteLine($"Age: \t{destination.Age}");
                    Console.WriteLine($"Salary: \t{destination.Salary}");
                }
                catch ( Exception ex )
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine("Do you wish to continue? Y/N");
                string continueInput = Console.ReadLine();
                if (continueInput.ToUpper() != "Y")
                    break;
            }
        }
    }
}
