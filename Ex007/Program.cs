namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual sua nota total: ");
            double media = Convert.ToDouble(Console.ReadLine());
            if (media >= 6)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else if (media < 6 && media >= 5)
            {
                Console.WriteLine("Aluno em recuperação!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado!");
            }
        }
    }
}

