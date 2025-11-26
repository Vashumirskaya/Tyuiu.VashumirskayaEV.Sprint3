using Tyuiu.VashumirskayaEV.Sprint3.Task3.V26.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Вариант 26 | Выполнила: Вашумирская Е.В.";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Цикл foreach                                                       *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант 26                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Подсчитать количество букв 'e' в строке: have a nice time               *");
            Console.WriteLine("***************************************************************************");

            string str = "have a nice time";
            char ch = 'e';

            int result = ds.GetCharCount(str, ch);

            Console.WriteLine("Результат: " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
