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
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoverityTestbed
{
    [TestClass]
    public class CSharp6Tests
    {
        [TestMethod]
        public void NullConditionalOperator_WithNull_ReturnsNull()
        {
            var value = default(string);

            Assert.AreEqual(default(string), value?.Substring(0, Math.Min(value.Length, 42)));
        }

        [TestMethod]
        public void NameofOperator_ForClassName_ReturnsClassName()
        {
            Assert.AreEqual("CSharp6Tests", nameof(CSharp6Tests));
        }

        [TestMethod]
        public void InterpolatedString_MatchesFormattedString()
        {
            var sut = $"This test method is contained in class {nameof(CSharp6Tests)}";

            var expectedResult = string.Format(CultureInfo.InvariantCulture, "This test method is contained in class {0}", nameof(CSharp6Tests));

            Assert.AreEqual(expectedResult, sut);
        }

        private string expressionBodiedField => "Foo";

        private string ExpressionBodiedMethod(string value) => new string(value.Reverse().ToArray());

        [TestMethod]
        public void ExpressionBodiedField_ReturnsValue()
        {
            Assert.AreEqual("Foo", expressionBodiedField);
        }

        [TestMethod]
        public void ExpressionBodiedField_ReturnsResult()
        {
            Assert.AreEqual("Foo", ExpressionBodiedMethod("ooF"));
        }
    }
}
