using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata.Tests
{
    [TestFixture]
    public class RomanNumeralsConverterTests
    {
        [Test]
        public void Convert_GivenNumber1_ShouldReturnI()
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            var number = "1";
            var expected = "I";
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
