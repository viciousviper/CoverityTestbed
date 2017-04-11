using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class AnalysisQuirks
    {
        public void Analyze_DictionaryTryGetValue()
        {
            var dict = new Dictionary<int, string> { [1] = "One", [2] = "Two", [3] = "Three" };

            var result = default(string);
            if (!dict.TryGetValue(3, out result)) {
                result = "Undefined";
                Console.WriteLine(result);
            }

            if (!dict.TryGetValue(2, out string result2)) {
                result2 = "Undefined";
                Console.WriteLine(result2);
            }
        }
    }
}
