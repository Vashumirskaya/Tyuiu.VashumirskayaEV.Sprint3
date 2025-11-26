using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                    break;

                double y = (x / Math.Sin(x)) + 0.5;
                result *= y;
            }

            return Math.Round(result, 3);
        }
    }
}
