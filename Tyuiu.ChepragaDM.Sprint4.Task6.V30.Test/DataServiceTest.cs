using Tyuiu.ChepragaDM.Sprint4.Task6.V30.Lib;

namespace Tyuiu.ChepragaDM.Sprint4.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] a = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            string[] wait = { "Береза" };
            string[] res = ds.Calculate(a);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
