
using System.Security.Cryptography;
using Tyuiu.ChepragaDM.Sprint4.Task3.V10.Lib;


namespace Tyuiu.ChepragaDM.Sprint4.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 8. Найдите максимальный     *");
            Console.WriteLine("* элемент 3 строки массива                                                *");
            Console.WriteLine("*                                                                         *");

            int[,] a = {
                            { 5, 7, 6, 6, 5 },
                            { 5, 5, 5, 4, 6 },
                            { 8, 5, 7, 4, 7 },
                            { 7, 6, 7, 4, 7 },
                            { 5, 8, 7, 8, 8 }
            };

            int str = a.GetUpperBound(0) + 1;
            int stb = a.Length / str;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    Console.Write($"{a[i, j]} \t");
                }
                Console.WriteLine();
               
            }


            Console.WriteLine();
            Console.WriteLine();

            int res = ds.Calculate(a);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}