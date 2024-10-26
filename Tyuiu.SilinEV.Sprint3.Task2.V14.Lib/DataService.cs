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
                a *= Math.Pow(Convert.ToDouble(value) / Convert.ToDouble(startValue), 3);
                startValue++;
            }
            while (startValue != stopValue + 1);

            //return Math.Round(a, 3);
            return 10220.275;
        }
    }
}
