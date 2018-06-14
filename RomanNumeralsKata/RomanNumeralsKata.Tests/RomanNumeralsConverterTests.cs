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
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void Convert_GivenNumber1_2_Or_3_ShouldAppendIAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Convert_GivenNumber4_ShouldReturnIV()
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            var number = 4;
            var expected = "IV";
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Convert_GivenNumber5_ShouldReturnV()
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            var number = 5;
            var expected = "V";
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        public void Convert_GivenNumber6_7_Or_8_ShouldAppendIAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Convert_GivenNumber9_ShouldReturnIX()
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            var number = 9;
            var expected = "IX";
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Convert_GivenNumber10_ShouldReturnIX()
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            var number = 10;
            var expected = "X";
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, "X")]
        [TestCase(14, "XIV")]
        [TestCase(19, "XIX")]
        public void Convert_GivenTeenNumber_ShouldAppendAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, "XX")]
        [TestCase(26, "XXVI")]
        [TestCase(29, "XXIX")]
        public void Convert_GivenTwentysCompoundNumber_ShouldAppendAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(30, "XXX")]
        [TestCase(34, "XXXIV")]
        [TestCase(38, "XXXVIII")]
        public void Convert_GivenThirtysCompoundNumber_ShouldAppendAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(40, "XL")]
        [TestCase(43, "XLIII")]
        [TestCase(47, "XLVII")]
        public void Convert_GivenFortysCompoundNumber_ShouldAppendAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(50, "L")]
        [TestCase(56, "LVI")]
        [TestCase(59, "LIX")]
        public void Convert_GivenFiftysCompoundNumber_ShouldAppendAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(60, "LX")]
        [TestCase(66, "LXVI")]
        [TestCase(69, "LXIX")]
        [TestCase(70, "LXX")]
        [TestCase(80, "LXXX")]
        public void Convert_GivenSixtysCompoundNumber_ShouldAppendAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(90, "XC")]
        [TestCase(93, "XCIII")]
        [TestCase(98, "XCVIII")]
        public void Convert_GivenNintysCompoundNumber_ShouldAppendAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, "C")]
        [TestCase(200, "CC")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(900, "CM")]
        public void Convert_GivenHundreds_ShouldAppendAccordingly(int number, string expected)
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Convert_GivenNumber1000_ShouldReturnM()
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            var number = 1000;
            var expected = "M";
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Convert_GivenNumber1990_ShouldReturnMCMXC()
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            var number = 1990;
            var expected = "MCMXC";
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Convert_GivenNumber2008_ShouldReturnMMVIII()
        {
            //Arrange
            var sut = new RomanNumeralsConverter();
            var number = 2008;
            var expected = "MMVIII";
            //Act
            var actual = sut.Convert(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
