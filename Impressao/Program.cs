namespace Impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Lucas Ciriaco Borba");
            Console.WriteLine();
            escreva("Palmeiras");
            Console.WriteLine();
            escreva("Oi");
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
    }
}
