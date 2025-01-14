namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 70;
            int num2 = 7;
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


            Console.WriteLine("             ");

            float num10 = 70f;
            float num20 = 7f;
            float resp = num10 + num20;
            float resp2 = num10 - num20;
            float resp3 = num10 * num20;
            float resp4 = num10 / num20;


            Console.WriteLine("A soma de {0} + {1} = {2}.", num, num2, resp);
            Console.WriteLine("A subtração de {0} - {1} = {2}.", num, num2, resp2);
            Console.WriteLine("A multiplicação de {0} * {1} = {2}.", num, num2, resp3);
            Console.WriteLine("A divisão de {0} / {1} = {2}.", num, num6, resp4);

        }
    }
}
