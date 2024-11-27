using System;
using ClassLibrary1;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1 { Name = "testing" };
            Console.WriteLine("Hello, says " + class1.Name);
            Console.ReadKey();
        }
    }
}
