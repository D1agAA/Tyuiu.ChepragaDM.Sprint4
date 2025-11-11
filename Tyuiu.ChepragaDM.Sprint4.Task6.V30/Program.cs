using Tyuiu.ChepragaDM.Sprint4.Task6.V30.Lib;
namespace Tyuiu.ChepragaDM.Sprint4.Task6.V30
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Береза\", \"Дуб\", \"Клён\", \"Сосна\",  *");
            Console.WriteLine("* \"Пихта\", \"Осина\"], используя класс Array, выведите элементы массива,*");
            Console.WriteLine("* длина которых больше 5 символов.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var w = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i <= w.Length - 1; i++)
            {
                Console.WriteLine(w[i]);
            }

            string[] res = ds.Calculate(w);

            



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            for (int i = 0; i <= res.Length - 1; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();
        }
    }
}