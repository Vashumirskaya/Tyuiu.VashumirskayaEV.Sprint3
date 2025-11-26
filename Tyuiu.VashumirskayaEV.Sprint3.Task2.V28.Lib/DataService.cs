using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;
            double c = Math.Cos(1.8);

            do
            {
                double term = Math.Pow(2, k) / (k + 1);
                p *= term * c;
                k++;
            }
            while (k <= stopValue);

            return p;
        }
    }
}
