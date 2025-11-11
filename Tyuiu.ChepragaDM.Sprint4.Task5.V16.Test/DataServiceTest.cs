using Tyuiu.ChepragaDM.Sprint4.Task5.V16.Lib;

namespace Tyuiu.ChepragaDM.Sprint4.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            int[,] a = {
                            { 5, 7, 6, 6, 5 },
                            { 5, 5, 5, 4, 6 },
                            { 8, 5, 7, 4, 7 },
                            { 7, 6, 7, 4, 7 },
                            { 5, 8, 7, 8, 8 }
            };

            int[,] wait = {
                            { 5, 7, 1, 1, 5 },
                            { 5, 5, 5, 1, 1 },
                            { 1, 5, 7, 1, 7 },
                            { 7, 1, 7, 1, 7 },
                            { 5, 1, 7, 1, 1 }
            };
            int[,] res = ds.Calculate(a);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
