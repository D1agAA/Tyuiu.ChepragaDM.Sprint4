using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChepragaDM.Sprint4.Task5.V16.Lib
{

    public class DataService : ISprint4Task5V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int str = matrix.GetUpperBound(0) + 1;
            int stb = matrix.Length / str;




            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }

                }

            }
            return matrix;
        }
    }
}
