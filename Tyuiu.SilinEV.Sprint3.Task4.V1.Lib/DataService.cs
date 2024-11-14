using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SilinEV.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            double a = 0, s = startValue, d = stopValue;

            for (int i = startValue; i <= stopValue; i++)
            {
                if (a == 0)
                {
                    break;
                }
                a += Math.Pow(Math.Sin(i) / i, 3);
            }
            return a;
        }
    }
}
