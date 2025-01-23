namespace Ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("Digite o seu gênero: ");
            genero = Console.ReadLine();

            while (genero != "M" && genero != "F")
            {
                Console.Write("Digite a inicial do seu gênero: ");

                genero = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Bem-vindos e bem-vindas ao curso de C#!");
        }
    }
}
