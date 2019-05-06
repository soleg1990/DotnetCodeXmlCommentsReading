using System;
using System.Xml;
using JimBlackler.DocsByReflection;

namespace DocsByReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Look in SomeExampleClass.cs to see where all these comments are defined

            {
                Console.WriteLine("Finding documentation attached to a class:");

                XmlElement documentation = DocsByReflection.XMLFromType(typeof(SomeExampleClass));

                Console.WriteLine(documentation["summary"].InnerText.Trim());
                Console.WriteLine(documentation["remarks"].InnerText.Trim());
            }

            {
                Console.WriteLine("Finding documentation attached to a method:");

                XmlElement documentation = DocsByReflection.XMLFromMember(typeof(SomeExampleClass).GetMethod("Square"));

                Console.WriteLine(documentation["summary"].InnerText.Trim());
                Console.WriteLine(documentation["returns"].InnerText.Trim());
            }

            {
                Console.WriteLine("Finding documentation attached to a method:");

                XmlElement documentation = DocsByReflection.XMLFromMember(typeof(SomeExampleClass).GetMethod("SimpleFunction"));

                Console.WriteLine(documentation["summary"].InnerText.Trim());
                Console.WriteLine(documentation["returns"].InnerText.Trim());
            }

             {
                Console.WriteLine("Finding documentation attached to a method with parameters:");

                XmlElement documentation = DocsByReflection.XMLFromMember(typeof(SomeExampleClass).GetMethod("AnotherMethod"));

                Console.WriteLine(documentation["summary"].InnerText.Trim());
                Console.WriteLine(documentation["returns"].InnerText.Trim());
            }
            

            
            {
                Console.WriteLine("Finding documentation attached to a property:");

                XmlElement documentation = DocsByReflection.XMLFromMember(typeof(SomeExampleClass).GetProperty("ExampleProperty"));

                Console.WriteLine(documentation["summary"].InnerText.Trim());
            }

            {
                Console.WriteLine("Finding documentation attached to a field:");

                XmlElement documentation = DocsByReflection.XMLFromMember(typeof(SomeExampleClass).GetField("anExampleField"));

                Console.WriteLine(documentation["summary"].InnerText.Trim());
            }
            
        }
    }
}
