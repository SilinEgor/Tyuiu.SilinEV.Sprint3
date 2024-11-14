using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SilinEV.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            double a = 0;

            for (int i = startValue; i < stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                a += Math.Sin(i) / i;
            }

            return Math.Round(a, 3);
        }
    }
}
