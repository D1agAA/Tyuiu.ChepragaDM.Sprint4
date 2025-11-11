using Tyuiu.ChepragaDM.Sprint4.Task7.V24.Lib;

namespace Tyuiu.ChepragaDM.Sprint4.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int str = 5;
            int stb = 3;
            int[,] a = new int[str, stb];
            string s = "651827384219648";
            DataService ds = new DataService();
            int res = ds.Calculate(str, stb, s);
            int wait = 1179648;
            Assert.AreEqual(wait, res);
        }
    }
}
