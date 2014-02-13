using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2013_TCO_Algorithm_Round_1A___Division_I__Level_One;

namespace TopCoderTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHouseBuilding()
        {
            HouseBuilding target = new HouseBuilding();
            string[] input = { "10", "31" };
            //string[] input = {"5781252", "2471255", "0000291", "1212489"};
            int actual = target.GetMinimum(input);
            Assert.AreEqual(2, actual);
            string[] input1 = { "5781252", "2471255", "0000291", "1212489" };
            actual = target.GetMinimum(input1);
            Assert.AreEqual (53, actual);

            string[] input2 = {"54454","61551"};
            actual = target.GetMinimum(input2);
            Assert.AreEqual(7, actual);

        }
    }
}
