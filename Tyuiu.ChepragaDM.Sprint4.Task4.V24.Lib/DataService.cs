using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChepragaDM.Sprint4.Task4.V24.Lib
{
    public class DataService : ISprint4Task4V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            int str = matrix.GetUpperBound(0) + 1;
            int stb = matrix.Length / str;


           

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 1;
                    }
                     
                }
                
            }
            return matrix;
        }
    }
}
