namespace ExVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruta = { "Abacate", "Pitaya", "Carambola", "Goiaba", "Caju", "Acerola","Lichia","Maracujá", "Jabuticaba", "Tamarindo"  };

            for (int i = 0; i < fruta.Length; i++)
            {
                Console.WriteLine(fruta[i]);
            }

            Console.WriteLine();
            string nome_primeiro = fruta.First();
            string nome_ultimo = fruta.Last();
            Console.WriteLine("O primeiro nome é: " + nome_primeiro);
            Console.WriteLine("O último nome é: " + nome_ultimo);
            Console.WriteLine();
            string nome_maior = fruta.Max();
            string nome_menor = fruta.Min();
            Console.WriteLine("O último nome em ordem alfabética é: " + nome_maior);
            Console.WriteLine("O primeiro nome em ordem alfabética é: " + nome_menor);
            Console.WriteLine();

            double[] preco = { 4.5, 3.2, 7.85, 10.64, 5.34, 2.10, 6.23, 9.35, 2.99, 4.95 };

            for (int i = 0; i < preco.Length; i++)
            {
                Console.WriteLine(preco[i]);
            }

            double pmaior = preco.Max();
            double pmenor = preco.Min();

            Console.WriteLine("O maior valor é: " + pmaior);
            Console.WriteLine("O menor valor é: " + pmenor);
        }
    }
}
