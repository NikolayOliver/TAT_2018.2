using System;
using NUnit.Framework;

namespace Task_Dev_3
{
    [TestFixture]
    public class NumberConverterTest
    {
        [TestCase(48, 20, "28")]
        [TestCase(48, 2, "110000")]
        [TestCase(48, 11, "44")]
        [TestCase(0, 15, "0")]
        [TestCase(Int32.MaxValue, 20, "1DB1F927")]
        [Test]
        public void ConverterTest(int number, int newBase, string result)
        {
            NumberConverter numberinNewBase = new NumberConverter(number, newBase);
            string actual = numberinNewBase.Converter();
            Assert.AreEqual(result, actual);
        }

        [TestCase(-1, 20)]
        [TestCase(48, 1)]
        [TestCase(48, 21)]
        [Test]
        public void NumberConverter_ArgumentOutOfRengeException(int number,int newBase)
        {
            NumberConverter numberInNewBase = new NumberConverter(number, newBase);
            Assert.Throws<ArgumentOutOfRangeException>
            (
               () => numberInNewBase.Converter()
            );
        }
    }
}
