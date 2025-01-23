namespace Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o final do intervalo: ");
            int final = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=final; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
