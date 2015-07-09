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

            bool actualResult = hsCore.IO.IsChildOfParent(parent, child);
            Assert.AreEqual(true, actualResult);

        }
    }
}
