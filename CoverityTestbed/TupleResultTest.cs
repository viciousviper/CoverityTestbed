using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoverityTestbed
{
    public class TupleResultTest
    {
        public (int, string) CreateTuple()
        {
            return (42, "Hello, World!");
        }

        public void UseTuple()
        {
            (var myInt, var myString) = CreateTuple();

            var otherInt = myInt + 2;
            var otherString = myString.Reverse();
        }
    }
}
