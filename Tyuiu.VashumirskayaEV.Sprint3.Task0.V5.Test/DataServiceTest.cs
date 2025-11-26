using Tyuiu.VashumirskayaEV.Sprint3.Task0.V5.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.GetSumSeries(1, 10);
            double wait = 81.083;

            Assert.AreEqual(wait, res);
        }
    }
}
