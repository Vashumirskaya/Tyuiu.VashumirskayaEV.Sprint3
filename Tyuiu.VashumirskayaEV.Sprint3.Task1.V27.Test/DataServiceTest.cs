using Newtonsoft.Json.Linq;
using Tyuiu.VashumirskayaEV.Sprint3.Task1.V27.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.173;

            Assert.AreEqual(wait, res);
        }
    }
}
