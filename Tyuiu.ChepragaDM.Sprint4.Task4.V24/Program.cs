using Tyuiu.ChepragaDM.Sprint4.Task4.V24.Lib;
namespace Tyuiu.ChepragaDM.Sprint4.Task4.V24
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод c клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 5 до 9. Замените четные элементы *");
            Console.WriteLine("* массива на 1                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Введите количество строк массива: ");
            int str = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов массива: ");
            int stb = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[str, stb];
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
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