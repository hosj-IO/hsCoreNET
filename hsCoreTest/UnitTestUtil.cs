﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hsCoreTest
{
    [TestClass]
    public class UnitTestUtil
    {
        [TestMethod]
        public void SoftToString_NullParameter()
        {
            const string expectedResult = "";

            string actualResult = hsCore.Util.SoftToString(null);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void SoftToString_StringParameter()
        {
            const string expectedResult = "hsCore";
            const string parameter = "hsCore";

            string actualResult = hsCore.Util.SoftToString(parameter);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void SoftToString_BoolParameter()
        {
            const string expectedResult = "False";
            bool parameter = false;

            string actualResult = hsCore.Util.SoftToString(parameter);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void RandomIntGenerator_MinAndMaxGood()
        {
            int min = 1;
            int max = 2;

            int actualResult = hsCore.Math.RandomIntGenerator(min, max);
            Assert.IsTrue(hsCore.Math.IsIntegerBetween(actualResult,min,max,true));
        }

        [TestMethod]
        public void IsIntegerBetween_GoodParameters()
        {
            int min = 1;
            int max = 3;
            int target = 2;
            bool equalIncluded = false;

            bool expectedResult = true;
            bool actualResult = hsCore.Math.IsIntegerBetween(target, min, max, equalIncluded);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void IsChildOfParent_ChildIsFamily()
        {
            string child = "C:\\hsCore\\1\\2\\3";
            string parent = "C:\\hscore\\";

            bool actualResult = hsCore.IO.IsChildOfParent(child,parent);
            Assert.AreEqual(true, actualResult);

        }

        [TestMethod]
        public void IsDecimalFiveCorrect()
        {
            decimal five = new decimal(1.49183);
            Assert.AreEqual(hsCore.Math.GetDecimalCount(five),5);
        }

        [TestMethod]
        public void IsDecimalTenCorrect()
        {
            decimal ten = new decimal(1.4918349183);
            Assert.AreEqual(hsCore.Math.GetDecimalCount(ten), 10);
        }

        [TestMethod]
        public void IsDecimalNineIncorrect()
        {
            decimal nine = new decimal(1.491834918);
            Assert.AreNotEqual(hsCore.Math.GetDecimalCount(nine), 10);
        }
    }
}
