using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SilinEV.Sprint3.Task6.V22.Lib
{
    public class DataService : ISprint3Task6V22
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int a = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        a++;
                    }
                }
            }

            return a;
        }
    }
}
