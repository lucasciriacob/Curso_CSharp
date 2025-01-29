namespace AreaTerreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Calcular a Área do Terreno");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.Write("Digite a largura do terreno(m): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a comprimento do terreno(m): ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area(l, c);

        }
        static void area(double largura, double comprimento)
        {
            double a = largura * comprimento;
            Console.WriteLine("A área do terreno de {0}m x {1}m é de = {2}m²", largura, comprimento, a);
        }
    }
}
