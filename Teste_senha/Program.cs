namespace Teste_senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123456";
            string senhaDig;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhaDig = Console.ReadLine();
                tentativas++;
                if(tentativas >3)
                {
                    break;
                }
            } while (senhaDig != senha);

            if (senha != senhaDig)
            {
                Console.WriteLine("Senha incorreta! Tentativas: " + tentativas);
            }
            else
            {
                Console.WriteLine("Senha correta! Tentativas: " + tentativas);
            }
            
            
        }
    }
}
