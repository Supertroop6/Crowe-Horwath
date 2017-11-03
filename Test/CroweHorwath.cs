using CroweHorwath;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CroweHorwath
    {
        [TestMethod]
        public void HelloWorldTest()
        {
            //Arange
            HelloWorld helloWorld = new HelloWorld();

            //Act
            string message = helloWorld.SayGreeting();

            //Assert
            Assert.AreEqual(Messages.Greeting, message);
            Assert.AreNotEqual(Messages.Greeting, message + "1");
        }
    }
}
