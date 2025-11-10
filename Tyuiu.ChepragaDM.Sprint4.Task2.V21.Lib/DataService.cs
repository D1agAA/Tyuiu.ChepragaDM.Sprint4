using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChepragaDM.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            int u = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    u *= array[i];
                }
            }
            return u;
        }
    }
}
