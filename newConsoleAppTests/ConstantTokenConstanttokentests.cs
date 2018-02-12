using Microsoft.VisualStudio.TestTools.UnitTesting;
using newConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newConsoleApp.Tests
{
    [TestClass()]
    public class ConstanttokenAddition
    {
        ConstantToken tokenFive = new ConstantToken(5, false, false);
        ConstantToken tokenThree = new ConstantToken(3, false, false);

        ConstantToken tokenminusFive = new ConstantToken(-5, false, false);
        ConstantToken tokenminusthree = new ConstantToken(-3, false, false);
        ConstantToken tokenExpected;
        ConstantToken tokenActual;

        [TestMethod()]
        public void GetResultconstantfiveaddthree()
        {
            tokenExpected = new ConstantToken(8, false, false);
            tokenActual = tokenFive + tokenThree;
            Console.WriteLine(tokenExpected.GetResult().Print() + " | - | " + tokenActual.GetResult().Print());
            Assert.AreEqual(tokenExpected.GetResult().Print(), tokenActual.GetResult().Print());
        }
        [TestMethod()]
        public void GetResultconstantfiveaddminusthree()
        {
            tokenExpected = new ConstantToken(2, false, false);
            tokenActual = tokenFive + tokenminusthree;
            Console.WriteLine(tokenExpected.GetResult().Print() + " | - | " + tokenActual.GetResult().Print());
            Assert.AreEqual(tokenExpected.GetResult().Print(), tokenActual.GetResult().Print());
        }
        [TestMethod()]
        public void GetResultconstantminusfiveaddminusthree()
        {
            tokenExpected = new ConstantToken(-8, false, false);
            tokenActual = tokenminusFive + tokenminusthree;
            Console.WriteLine(tokenExpected.GetResult().Print() + " | - | " + tokenActual.GetResult().Print());
            Assert.AreEqual(tokenExpected.GetResult().Print(), tokenActual.GetResult().Print());
        }

    }
    [TestClass()]
    public class ConstantTokenSubtraction
    {
        ConstantToken tokenFive = new ConstantToken(5, false, false);
        ConstantToken tokenThree = new ConstantToken(3, false, false);

        ConstantToken tokenminusFive = new ConstantToken(-5, false, false);
        ConstantToken tokenminusthree = new ConstantToken(-3, false, false);
        ConstantToken tokenExpected;
        ConstantToken tokenActual;
        [TestMethod()]
        public void subtractTwoPosiveValues()
        {
            tokenExpected = new ConstantToken(2, false, false);
            tokenActual = tokenFive - tokenThree;
            Console.WriteLine(tokenExpected.GetResult().Print() + " | - | " + tokenActual.GetResult().Print());
            Assert.AreEqual(tokenExpected.GetResult().Print(), tokenActual.GetResult().Print());
        }
        [TestMethod()]
        public void subtractRightNegativeValue()
        {
            tokenExpected = new ConstantToken(8, false, false);
            tokenActual = tokenFive - tokenminusthree;
            Console.WriteLine(tokenExpected.GetResult().Print() + " | - | " + tokenActual.GetResult().Print());
            Assert.AreEqual(tokenExpected.GetResult().Print(), tokenActual.GetResult().Print());
        }
    }
}