using Tyuiu.VashumirskayaEV.Sprint3.Task2.V28.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.GetMultiplySeries(1, 9);

            double p = 1;
            double c = Math.Cos(1.8);
            for (int k = 1; k <= 9; k++)
            {
                p *= (Math.Pow(2, k) / (k + 1)) * c;
            }

            Assert.AreEqual(p, res, 0.0001);
        }
    }
}
