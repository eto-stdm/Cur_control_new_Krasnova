using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cur_control_new_Krasnova;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RectPositive()
        {
            var page = new PerimFigur();
            Assert.IsTrue(page.CalculateRect("34", "23"));
            Assert.IsTrue(page.CalculateRect("2344", "312"));
            Assert.IsTrue(page.CalculateRect("2", "2"));
        }

        [TestMethod]
        public void RectNegative()
        {
            var page = new PerimFigur();
            Assert.IsFalse(page.CalculateRect("0", "23"));
            Assert.IsFalse(page.CalculateRect("-2344", "312"));
            Assert.IsFalse(page.CalculateRect("wed", "ad"));
        }

        [TestMethod]
        public void CriclePositive()
        {
            var page = new PerimFigur();
            Assert.IsTrue(page.CalculateCircle("3"));
            Assert.IsTrue(page.CalculateCircle("9"));
            Assert.IsTrue(page.CalculateCircle("3432"));
        }

        [TestMethod]
        public void CricleNegative()
        {
            var page = new PerimFigur();
            Assert.IsFalse(page.CalculateCircle("-1"));
            Assert.IsFalse(page.CalculateCircle("0"));
            Assert.IsFalse(page.CalculateCircle("wd23"));
        }

        [TestMethod]
        public void TriangPositive()
        {
            var page = new PerimFigur();
            Assert.IsTrue(page.CalculateTriang("12", "23", "2"));
            Assert.IsTrue(page.CalculateTriang("23", "12", "98"));
            Assert.IsTrue(page.CalculateTriang("5", "123", "23"));
        }

        [TestMethod]
        public void TriangNegative()
        {
            var page = new PerimFigur();
            Assert.IsFalse(page.CalculateTriang("-34", "23", "-2"));
            Assert.IsFalse(page.CalculateTriang("34", "0", "2"));
            Assert.IsFalse(page.CalculateTriang("wed", "wrw", "2"));
        }
    }
}
