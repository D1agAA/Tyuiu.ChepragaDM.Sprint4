using Tyuiu.ChepragaDM.Sprint4.Task7.V24.Lib;
namespace Tyuiu.ChepragaDM.Sprint4.Task7.V24
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"651827384219648\".                  *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных      *");
            Console.WriteLine("* чисел.                                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int str = 5;
            int stb = 3;
            int[,] a = new int[str, stb];
            string s = "651827384219648";
            int index = 0;

            Console.WriteLine("\nМассив: ");

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    Console.Write($"{s[index]} \t");
                    index++;
                }
                Console.WriteLine();

            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(str, stb, s);

            Console.WriteLine(res);













            Console.ReadKey();
        }
    }
}