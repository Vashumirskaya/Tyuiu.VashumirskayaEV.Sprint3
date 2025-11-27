using Tyuiu.VashumirskayaEV.Sprint3.Task6.V15.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(6, 15);
            Assert.AreEqual(168, result);
        }
    }
}
