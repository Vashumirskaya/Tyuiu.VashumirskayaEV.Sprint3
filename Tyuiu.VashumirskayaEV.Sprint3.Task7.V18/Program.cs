using Tyuiu.VashumirskayaEV.Sprint3.Task7.V18.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вычисление значений функции по заданному диапазону                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции F(x) =     *");
            Console.WriteLine("* (2x - 3) / (cos(x) + x) + 5 для x из диапазона [-5, 5], с шагом 1.      *");
            Console.WriteLine("* При делении на ноль вернуть значение 0. Значения округлить до двух      *");
            Console.WriteLine("* знаков после запятой.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Диапазон x: [-5, 5], шаг = 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            double[] result = ds.GetMassFunction(-5, 5);
            Console.WriteLine("x | F(x)");
            Console.WriteLine("------------");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"x = {-5 + i} | F(x) = {result[i]}");
            }

            Console.ReadKey();
        }
    }
}
