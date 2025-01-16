namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", num);
            }

            else
            {
                Console.WriteLine("O número {0} é ímpar.", num);

            }
        }
    }
}
