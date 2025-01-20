namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a distância em quilômetros: ");
            double distancia = double.Parse(Console.ReadLine());

            double tarifa = CalcularTarifa(distancia);

            Console.WriteLine($"Tarifa: R$ {tarifa:F2}");
            static double CalcularTarifa(double distancia)
            {

                if (distancia <= 200)
                {
                    return distancia * 0.50;

                }
                else
                {
                    return distancia *0.45;
                }

            }
        }
    }
}
