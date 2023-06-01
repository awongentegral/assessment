using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsAssessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAssessment.Tests
{
    [TestClass()]
    public class MyWordClassTests
    {
        [TestMethod()]
        public void GetWordFromTextShouldReturnWord3()
        {
            //Arrange
            string retVal = string.Empty;
            // Act 2
            retVal = MyWordClass.GetWordFromText("one;two three", 2);
            // Assert 2
            Assert.AreEqual("three", retVal);
        }

        [TestMethod()]
        public void GetWordFromTextShouldReturnWord2()
        {
            //Arrange
            string retVal = string.Empty;
            // Act 1
            retVal = MyWordClass.GetWordFromText("one two three", 2);
            // Assert 1
            Assert.AreEqual("two", retVal);
        }


        [TestMethod()]
        public void GetWordFromTextShouldReturnWord1()
        {
            //Arrange
            string retVal = string.Empty;
            // Act 2
            retVal = MyWordClass.GetWordFromText("one;two three", 2);
            // Assert 2
            Assert.AreEqual("three", retVal);
        }

        [TestMethod()]
        public void GetWordFromTextShouldThowArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            { MyWordClass.GetWordFromText("one", 2); });
        }

        [TestMethod()]
        public void GetWordFromTextShouldThowArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            { MyWordClass.GetWordFromText(null, 1); });
        }

        [TestMethod()]
        public void ReverseTest1()
        {
            //Arrange
            string retVal = string.Empty;
            // Act 2
            retVal = MyWordClass.Reverse("one");
            // Assert 2
            Assert.AreEqual("eno", retVal);
        }

        [TestMethod()]
        public void ReverseTest2()
        {
            //Arrange
            string retVal = string.Empty;
            // Act 2
            retVal = MyWordClass.Reverse("abcd dcba");
            // Assert 2
            Assert.AreEqual("abcd dcba", retVal);
        }

        [TestMethod()]
        public void ReverseTest3()
        {
            //Arrange
            string retVal = string.Empty;
            // Act 2
            retVal = MyWordClass.Reverse(string.Empty);
            // Assert 2
            Assert.AreEqual(string.Empty, retVal);
        }
    }
}