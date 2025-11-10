using Tyuiu.ChepragaDM.Sprint4.Task0.V2.Lib;

namespace Tyuiu.ChepragaDM.Sprint4.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int wait = 44;
            int res = ds.GetSumOddArrEl(a);
            Assert.AreEqual(wait, res);

        }
    }
}
