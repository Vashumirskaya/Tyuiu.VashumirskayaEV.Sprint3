using Tyuiu.VashumirskayaEV.Sprint3.Task5.V10.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 5;

            double expected = ds.GetSumSumSeries(5, 1, 1, 3, 10);
            double result = ds.GetSumSumSeries(5, 1, 1, 3, 10);

            Assert.Equal(expected, result);
        }
    }
}
