namespace Teste_senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123456";
            string senhaDig;

            do
            {
                Console.Write("Digite a senha: ");
                senhaDig = Console.ReadLine();
            } while (senhaDig != senha);
        }
    }
}
