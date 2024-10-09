using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SilinEV.Sprint3.Task0.V9.Lib
{
    public class DataService : ISprint3Task0V9
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double a = 0;
            
            for (Convert.ToInt32(startValue); startValue <= stopValue; startValue++)
            {
                a += Math.Pow(1 / (3 + Math.Pow(value, startValue)), startValue);
            }

            return Math.Round(a, 3);
        }
    }
}
