using Tyuiu.VashumirskayaEV.Sprint3.Task2.V28.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Вашумирская Е.В. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл do…while                                                     *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант 28                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить произведение ряда по формуле                                  *");
            Console.WriteLine("* p = П (2^k / (k+1)) * cos(1.8), k = 1..9                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(1, 9);
            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}
