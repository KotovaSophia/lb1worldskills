internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите число n: ");
        double n = Convert.ToDouble(Console.ReadLine());
        double res = 0;

        if (Math.Abs(x) <= 1)
        {
            for (double i = 0; i <= n; i++)
            {
                res += ((Math.Pow(-1, n + 1)) * (Math.Pow(x, (2 * n + 1)))) / (2 * n + 1);
            }
            Console.WriteLine(res);
        }
        else
        {
            Console.WriteLine("Модуль x > 1");
        }
    }
}