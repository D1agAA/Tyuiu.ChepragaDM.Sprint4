using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChepragaDM.Sprint4.Task7.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] a = new int[n, m];

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i,j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            int res = 1;
            for(int i = 0;i < n; i++)
            {
                for(int j = 0;  j < m; j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        res *= a[i, j];
                    }

                }
            }
            return res;
        }
    }
}
