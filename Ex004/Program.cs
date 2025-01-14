namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            float num6, resposta;
            num6 = 7f;
            int num3 = num + num2;
            int num4 = num - num2;
            int num5 = num * num2;
            resposta = num / num6;

            Console.WriteLine("A soma de {0} + {1} = {2}.", num, num2, num3);
            Console.WriteLine("A subtração de {0} - {1} = {2}.", num, num2, num4);
            Console.WriteLine("A multiplicação de {0} * {1} = {2}.", num, num2, num5);
            Console.WriteLine("A divisão de {0} / {1} = {2}.", num, num6, resposta);
    }
    }
}
