namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sua primeira nota: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sua segunda nota: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = num + num2;
            double media = num3 / 2;
            Console.WriteLine("A sua média é, {0}.", media);
            
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

