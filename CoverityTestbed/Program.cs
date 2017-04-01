using System;
using System.Linq;
using System.Globalization;

namespace CoverityTestbed
{
    class Program
    {
        private class Item
        {
            public int Key { get; set; }

            public string Value { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Coverity!");
            Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "CLR version is {0}", Environment.Version));
            Console.WriteLine($"This is a string interpolation on CLR version {Environment.Version}");
            Console.ReadLine();

            var sorted = new System.Collections.Generic.SortedList<int, Item>();
            sorted.Add(3, new Item() { Key = 3, Value = "Blue" });
            sorted.Add(0, new Item() { Key = 2, Value = "White" });
            sorted.Add(2, new Item() { Key = 2, Value = "Green" });
            sorted.Add(4, new Item() { Key = 2, Value = "Black" });
            sorted.Add(1, new Item() { Key = 1, Value = "Red" });

            Console.Out.WriteLine(string.Join(", ", sorted.Values.Select(v => v.Value)));
            Console.Read();
        }
    }
}
