namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a velocidade: ");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            if (velocidade > 80)
            {
                Console.WriteLine("Você foi multado! O limite é de 80KM/h");
                //Quanto passou do limite. Multa custa R$ 7,00 por KM acima do limite
                double multa = (velocidade - 80) * 7;
                Console.Write("O valor da multa é de: R${0} ", multa);
            }

            else
            {
                Console.Write("Parabéns, dirigiu igual gente :) .");
            }
        }
    }
}
