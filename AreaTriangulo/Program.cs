namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Calcular a Área do Triângulo");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.Write("Digite o tamanho da base: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a altura: ");
            int r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            

            area(r, r2);

        }
        static void area(int reta, int reta2)
        {
            int a = reta * reta2 / 2;
            Console.WriteLine("A área do triângulo é de = {0}m2", a);
        }
    }
}
