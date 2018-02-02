using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Lab10
{
    [TestFixture]
    class Tests
    {
        [Test]
        public static void testInitial()
        {
            Movie movie1 = new Movie("John Wick", "Action");
            string expected = "John Wick";
            string actual = movie1.getTitle();
            Assert.AreEqual(expected, actual, "Title doesn't match");

        }

        [Test]
        public static void testGetInput()
        {
            int expectedInput = 100;
            int actualInput = 100;
            Assert.AreEqual(expectedInput, actualInput, "No Match");
        }

        [Test]
        public static void testAgain()
        {
            string expected = "y";
            string actual = "y";
            Assert.AreEqual(expected, actual, "input doesn't match");
        }
    }
}
