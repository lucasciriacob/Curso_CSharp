namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Calculadora");

            Console.Write("Digite o primeiro número: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Escolha a operação desejada(+,-,*,/): ");
            string op = Console.ReadLine();
            double resultado = 0;
            if (op == "+")
            {
                resultado = soma(n, n2);
            }
            else if (op == "-")
            {
                resultado = subtracao(n, n2);
            }
            else if (op == "*")
            {
                resultado = multiplicacao(n, n2);
            }
            else if (op == "/")
            {
                resultado = divisao(n, n2);
            }
            else
            {
                Console.WriteLine("Operação inválida");
            }


        }
        static void escreva(string texto)
        {
            char caracter = '=';
            int tamanho = texto.Length + 4;
            string linha = new string(caracter, tamanho);
            string txt_centralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho);
            Console.WriteLine(linha);
            Console.WriteLine(txt_centralizado);
            Console.WriteLine(linha);
        }
        static double soma(double n, double n2)
        {
            double resultado = n + n2;
            Console.WriteLine("Resultado: " + resultado);
            return resultado;
        }
        static double subtracao(double n, double n2)
        {
            double resultado = n - n2;
            Console.WriteLine("Resultado: " + resultado);
            return resultado;
        }
        static double multiplicacao(double n, double n2)
        {
            double resultado = n * n2;
            Console.WriteLine("Resultado: " + resultado);
            return resultado;
        }
        static double divisao(double n, double n2)
        {
            double resultado = n / n2;
            Console.WriteLine("Resultado: " + resultado);
            return resultado;
        }

    }
}
