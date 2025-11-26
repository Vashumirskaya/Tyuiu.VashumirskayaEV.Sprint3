using Tyuiu.VashumirskayaEV.Sprint3.Task4.V8.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();

            double result = service.Calculate(-5, 5);

            Assert.IsTrue(!double.IsNaN(result) && !double.IsInfinity(result));
        }
    }
}
