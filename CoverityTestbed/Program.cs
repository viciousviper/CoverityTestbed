using System;
using System.Globalization;

namespace CoverityTestbed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Coverity!");
            Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "CLR version is {0}", Environment.Version));
            Console.WriteLine($"This is a string interpolation on CLR version {Environment.Version}");
            Console.ReadLine();
        }
    }
}
