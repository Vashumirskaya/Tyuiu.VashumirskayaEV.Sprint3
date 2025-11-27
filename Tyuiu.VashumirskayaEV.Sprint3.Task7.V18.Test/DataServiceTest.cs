using Tyuiu.VashumirskayaEV.Sprint3.Task7.V18.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(11, result.Length);
            Assert.AreEqual(0.0, result[5]);
            Assert.AreEqual(6.73, result[0], 0.01);
        }
    }
}
