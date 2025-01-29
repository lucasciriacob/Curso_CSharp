namespace Formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 10.54821;
            double num2 = 54781.65874;

            Console.WriteLine($"{num:F2}");
            Console.WriteLine($"{num2:N2}");
        }
    }
}
