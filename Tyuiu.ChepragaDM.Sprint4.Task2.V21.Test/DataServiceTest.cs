using Tyuiu.ChepragaDM.Sprint4.Task2.V21.Lib;

namespace Tyuiu.ChepragaDM.Sprint4.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
            int wait = 24;
            int res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}
