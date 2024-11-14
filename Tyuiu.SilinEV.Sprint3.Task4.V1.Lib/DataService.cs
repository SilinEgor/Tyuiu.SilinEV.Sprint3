using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SilinEV.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            double a = 0;

            for (int i = startValue; a <= stopValue; startValue++)
            {
                if (startValue == 0)
                {
                    break;
                }
                a += Math.Sin(startValue) / startValue;
            }

            return Math.Pow(a, 3);
        }
    }
}
