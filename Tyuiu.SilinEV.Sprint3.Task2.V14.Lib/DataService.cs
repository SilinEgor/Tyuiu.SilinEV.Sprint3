using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SilinEV.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double a = 1;
            do
            {
                a *= Math.Pow(value / startValue, 3);
                value += 1;
            }
            while (a < stopValue);

            return Math.Round(a, 3);
        }
    }
}
