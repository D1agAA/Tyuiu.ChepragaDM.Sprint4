using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChepragaDM.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            string[] a = Array.FindAll(array, w => w.Length > 5);
            return a;
        }
    }
}
