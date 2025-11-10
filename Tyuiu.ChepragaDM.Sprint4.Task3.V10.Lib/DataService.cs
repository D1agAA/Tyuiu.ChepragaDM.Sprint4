using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChepragaDM.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int str = array.GetUpperBound(0) + 1;
            int stb = array.Length / str;

           
            int max = array[2, 0];

            for (int j = 0; j < stb; j++)
            {
                if (array[2, j] > max)
                {
                    max = array[2, j];
                }
            }
            return max;
        }
    }
}
