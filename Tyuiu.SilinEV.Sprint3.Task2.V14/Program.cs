using Tyuiu.SilinEV.Sprint3.Task2.V14.Lib;

DataService ds = new DataService();
int a = Convert.ToInt32(Console.ReadLine());
int s = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ds.GetMultiplySeries(a, s, d));
Console.ReadKey();