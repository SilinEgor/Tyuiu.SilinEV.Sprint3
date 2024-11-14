using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SilinEV.Sprint3.Task3.V14.Lib
{
    public class DataService : ISprint3Task3V14
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string a = "";
            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    a += "’";
                }
                else
                {
                    a += c;
                }
            }
            return a;
        }
    }
}
