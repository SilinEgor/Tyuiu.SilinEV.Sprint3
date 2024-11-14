using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SilinEV.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[stopValue - startValue + 1];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = startValue; j <= stopValue; j++)
                {
                    if (j == 0)
                    {
                        a[i] = 0.0;
                    }
                    else
                    {
                        a[i] = ((2 * j - 3) / (Math.Cos(j) + j)) + 5; 
                    }
                }
            }

            return a;
        }
    }
}
