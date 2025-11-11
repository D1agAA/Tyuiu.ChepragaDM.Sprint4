using Tyuiu.ChepragaDM.Sprint4.Task5.V16.Lib;
namespace Tyuiu.ChepragaDM.Sprint4.Task5.V16
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов заполненный         *");
            Console.WriteLine("* случайными значениями в диапазоне от -6 до 3в. Замените положительные   *");
            Console.WriteLine("* элементы массива на 1                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество строк массива: ");
            int str = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов массива: ");
            int stb = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[,] a = new int[str, stb];
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    
                    a[i, j] = r.Next(-6, 3);
                }
                Console.WriteLine();

            }

            Console.WriteLine("\nМассив: ");

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    Console.Write($"{a[i, j]} \t");
                }
                Console.WriteLine();

            }

            Console.WriteLine();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(a);


            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine();

            }


            Console.ReadKey();
        }
    }
}