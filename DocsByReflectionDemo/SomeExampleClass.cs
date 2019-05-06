using System;

namespace DocsByReflectionDemo
{
    /// <summary>
    /// An example C# class
    /// </summary>
    /// <remarks>
    /// This class illustrates how a class can be marked up with inline C# comments
    /// </remarks>
    class SomeExampleClass
    {
        /// <summary>
        /// The contructor for the class
        /// </summary>
        public SomeExampleClass()
        {

        }

        /// <summary>
        /// Calculates the square of an integer
        /// </summary>
        /// <seealso cref="AnotherMethod"/>
        /// <param name="param">The number to generate the square of</param>
        /// <returns>The square of the parameter</returns>
        static public int Square(int param)
        {
            return param * param;
        }

        /// <summary>
        /// A function that does very little
        /// </summary>
        /// <returns>A string containing "Hello World"</returns>
        public string SimpleFunction()
        {
            return "HelloWorld";
        }

        /// <summary>
        /// A method that joins two strings
        /// </summary>
        /// <param name="input0">The first string</param>
        /// <param name="input1">The second string</param>
        /// <returns>The strings combined</returns>
        static public string AnotherMethod(string input0, string input1)
        {
            return (input0 + input1).ToLower();
        }

        /// <summary>
        /// An example of a property
        /// </summary>
        public int ExampleProperty
        {
            get { return somePrivateVar; }
            set { somePrivateVar = value; }
        }

        /// <summary>
        /// lol
        /// </summary>
        private int somePrivateVar;

        /// <summary>
        /// An example public field
        /// </summary>
        public int anExampleField = 99;
    }

    /// <summary>
    /// Base class
    /// </summary>
    public class Base
    {
        /// <summary>
        /// Id property
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// BaseField property
        /// </summary>
        public string BaseField { get; set; }
    }

    /// <summary>
    /// Child class
    /// </summary>
    public class Child : Base
    {
        /// <summary>
        /// ChildDate property
        /// </summary>
        public DateTime? ChildDate { get; set; }
    }


    /// <summary>
    /// IJob interface
    /// </summary>
    public interface IJob
    {
        /// <summary>
        /// Work method
        /// </summary>
        /// <param name="param"></param>
        void Work(string param);

        void WorkWithoutCommentInChild();
    }


    /// <summary>
    /// TestEnum enum
    /// </summary>
    enum TestEnum
    {
        /// <summary>
        /// Value1
        /// </summary>
        Value1 = 0,
        /// <summary>
        /// Value2
        /// </summary>
        Value2 = 1,
        /// <summary>
        /// Value3
        /// </summary>
        Value3 = 2
    }

}
