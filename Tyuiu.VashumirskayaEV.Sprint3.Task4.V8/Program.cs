using Tyuiu.VashumirskayaEV.Sprint3.Task4.V8.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task4.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание: Произведение значений функции на отрезке                       *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y = (x / sin(x)) + 0.5                                          *");
            Console.WriteLine("* При x = 0 — прервать цикл. Полученные значения перемножить.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начало диапазона (startValue): ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона (stopValue): ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine($"Произведение значений функции на отрезке = {result}");

            Console.ReadKey();
        }
    }
}
