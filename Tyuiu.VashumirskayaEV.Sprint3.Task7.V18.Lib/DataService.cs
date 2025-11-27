using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VashumirskayaEV.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                double x = startValue + i;
                double value;

                try
                {
                    value = (2 * x - 3) / (Math.Cos(x) + x) + 5;
                }
                catch (DivideByZeroException)
                {
                    value = 0; 
                }

                result[i] = Math.Round(value, 2); 
            }

            return result;
        }
    }
}
