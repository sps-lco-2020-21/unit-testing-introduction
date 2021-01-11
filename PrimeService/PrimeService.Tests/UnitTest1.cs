using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeService.Lib;

namespace PrimeService.Tests
{
    // note that the class library project needs to be referenced from the tests projects 

    // this decorator indicates that this class contains test methods 
    [TestClass]
    public class UnitTest1
    {
        // not all methods in the class need to contain tests, but if they do they should have 
        // this decorator 
        [TestMethod]
        public void TestMethod1()
        {
            // create the new object to be tested
            PrimeChecker pc = new PrimeChecker();
            // make one or more assertions about the object's current state 
            // the AreEqual method takes two arguments: 
            // - the first is the expected value 
            // - the second is the actual value 
            Assert.AreEqual(true, pc.IsPrime(1));
        }
        [TestMethod]
        public void TestMethod2()
        {
            PrimeChecker pc = new PrimeChecker();
            // if it's a Boolean we can use the IsTrue (or IsFalse) method instead
            Assert.IsTrue(pc.IsPrime(2));

        }
        [TestMethod]
        public void TestMethod4()
        {
            PrimeChecker pc = new PrimeChecker();
            // we can add an optional string which will be displayed in the event of a failed test 
            Assert.AreEqual(false, pc.IsPrime(4), "4 is not a prime number");

        }

        [TestMethod]
        public void TestMethod5()
        {
            PrimeChecker pc = new PrimeChecker();
            // we can set the bar lower - this is to confirm that it's not null, not a specific value, for example. 
            Assert.IsNotNull(pc.IsPrime(5));

        }
    }
}
