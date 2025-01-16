namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sua primeira nota: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sua segunda nota: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A sua média é, {0}.", (num + num2) / 2);

        }
    }
}
