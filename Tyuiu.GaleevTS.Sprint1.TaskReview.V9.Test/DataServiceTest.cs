using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaleevTS.Sprint1.TaskReview.V9.Lib;

namespace Tyuiu.GaleevTS.Sprint1.TaskReview.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(22022.78, res);

        }
    }
}
