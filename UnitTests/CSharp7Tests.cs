/*
The MIT License(MIT)

Copyright(c) 2017 IgorSoft

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoverityTestbed
{
    [TestClass]
    public class CSharp7Tests
    {
        private (int, string) ReturnTuple()
        {
            return (42, "Hello, World!");
        }

        [TestMethod]
        public void TupleValueFunction_ReturnsTuple()
        {
            var sut = ReturnTuple();

            Assert.IsInstanceOfType(sut, typeof(ValueTuple<int, string>));
        }

        [TestMethod]
        public void TupleValueFunction_ReturnsDecomposableResult()
        {
            (var sutInt, var sutString)  = ReturnTuple();

            Assert.IsInstanceOfType(sutInt, typeof(int));
            Assert.IsInstanceOfType(sutString, typeof(string));

            Assert.AreEqual(42, sutInt);
            Assert.AreEqual("Hello, World!", sutString);
        }

        [DataTestMethod]
        [DataRow(0, 0, DisplayName = "Zero")]
        [DataRow(1, 1, DisplayName = "One")]
        [DataRow(2, 4, DisplayName = "Two")]
        [DataRow(3, 9, DisplayName = "Three")]
        public void DataTestMethod_IsExecutedForEachDataRow(int baseValue, int squareValue)
        {
            Assert.AreEqual(squareValue, baseValue * baseValue);
        }
    }
}
