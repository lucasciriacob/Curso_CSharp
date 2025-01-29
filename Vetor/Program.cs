namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[5];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;
            
            Console.WriteLine(num[0]);

            int[] n = new int[3] { 1, 2, 3 };
            Console.WriteLine(n[0]);
            Console.WriteLine();

            int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(numero[0]);

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(numero[i] + " " + i);
            }
            

            double[] reais = { 4.5, 3.2, 7.85, 10.64, -5.34, -2.1 };

            for (int i = 0; i < reais.Length; i++)
            {
                Console.WriteLine(reais[i]);
            }

            double rmaior = reais.Max();
            double rmenor = reais.Min();

            Console.WriteLine("O maior valor é: " + rmaior);
            Console.WriteLine("O menor valor é: " + rmenor);
            */
            string[] nomes = { "Maria", "João", "José", "Pedro", "Ana", "José"};

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1)
                {
                    Console.Write(nomes[i] + ", ");
                }
                else
                {
                    Console.Write(nomes[i] + ", ");
                }
            }
            Console.WriteLine();
            string nome_primeiro = nomes.First();
            string nome_ultimo = nomes.Last();
            Console.WriteLine("O primeiro nome é: " +nome_primeiro);
            Console.WriteLine("O último nome é: " + nome_ultimo);
            Console.WriteLine();
            string nome_maior = nomes.Max();
            string nome_menor = nomes.Min();
            Console.WriteLine("O último nome em ordem alfabética é: " + nome_maior);
            Console.WriteLine("O primeiro nome em ordem alfabética é: " + nome_menor);
            Console.WriteLine();

        }
    }
}
