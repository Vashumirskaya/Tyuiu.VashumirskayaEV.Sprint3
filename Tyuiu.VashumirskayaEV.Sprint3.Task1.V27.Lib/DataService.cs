using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                multiplySeries *= 1 / Math.Pow(value, 3 * k);
                k++;
            }

            return Math.Round(multiplySeries, 1);
        }
    }
}
