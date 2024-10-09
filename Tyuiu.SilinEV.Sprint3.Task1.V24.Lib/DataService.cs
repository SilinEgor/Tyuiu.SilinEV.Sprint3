using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SilinEV.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double a = 0;

            while (startValue != 13)
            {
                a += Math.Pow(2 / (6 + Math.Pow(value, startValue)), startValue);
                startValue++;
            }

            return Math.Round(a, 3);
        }
    }
}
