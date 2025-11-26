using Tyuiu.VashumirskayaEV.Sprint3.Task3.V26.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "have a nice time";
            char ch = 'e';

            int result = ds.GetCharCount(str, ch);

            Assert.AreEqual(3, result);
        }
    }
}
