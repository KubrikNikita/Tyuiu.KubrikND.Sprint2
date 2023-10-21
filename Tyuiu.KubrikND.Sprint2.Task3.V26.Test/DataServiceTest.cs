using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint2.Task3.V26.Lib;

namespace Tyuiu.KubrikND.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        
            [TestMethod]
            public void ValidCondition1()
            {
                DataService ds = new DataService();
                double x = 1;
                double res = ds.Calculate(x);
                double wait = 7.851;
                Assert.AreEqual(wait, res);
            }
            [TestMethod]
            public void ValidCondition2()
            {
                DataService ds = new DataService();
                double x = 0;
                double res = ds.Calculate(x);
                double wait = 1.666;
                Assert.AreEqual(wait, res);
            }
            [TestMethod]
            public void ValidCondition3()
            {
                DataService ds = new DataService();
                double x = -1;
                double res = ds.Calculate(x);
                double wait = -6.7134;
                Assert.AreEqual(wait, res);
            }
            [TestMethod]
            public void ValidCondition4()
            {
                DataService ds = new DataService();
                double x = -31;
                double res = ds.Calculate(x);
                double wait = -247.968;
            }
        
    }
}
