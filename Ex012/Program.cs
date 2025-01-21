namespace Ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            double aumento = calcaumento(salario);

            Console.WriteLine("O valor do aumento é: " + aumento);
            Console.WriteLine("O novo salário é: " + (salario + aumento));
            static double calcaumento(double salario)
            {
                if (salario > 2500)
                {
                    return salario * 0.05;
                }
                else if (salario > 1250)
                {
                    return salario * 0.10;
                }
                else if (salario == 1250)
                {
                    return salario * 0.15;
                }
                else
                {
                    return salario * 0.00;
                }
            }
        }
    }
}
