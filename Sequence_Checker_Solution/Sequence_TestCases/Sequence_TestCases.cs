using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers.Calculation;

namespace Sequence_TestCases
{
    [TestClass]
    public class Sequence_TestCases
    {

        string inputString = string.Empty;
        string expectedOutput = string.Empty;

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(System.FormatException))]
        public void String_Not_In_Correct_Format()
        {
            inputString = "a b c d 123 23";
            var result = Arithmetic.GetIncreasingSequence(inputString);

        }
    }
}
