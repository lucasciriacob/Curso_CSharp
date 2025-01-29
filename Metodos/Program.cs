namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            soma(3, 4);
            saudacao("Lucas");
        }
        static void soma(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("A soma de "+a+" + "+b+" = "+c);
        }
        static void saudacao(string nome)
        {
            Console.WriteLine(nome + ". Seja bem-vindo!");
        }
    }
}
