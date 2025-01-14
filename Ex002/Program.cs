namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            float num2 = 1.1f;
            char letra = 'a';
            string nome = "Lucas";

            Console.WriteLine("O número é, {0}.", num);
            Console.WriteLine("O valor é, R${0}.", num2);
            Console.WriteLine("A letra é, {0}.", letra);
            Console.WriteLine("O nome é, {0}.",nome);

            Console.WriteLine("O número é, {0}. O valor é, R${1}. A letra é, {2}. O nome é, {3}.", num, num, letra, nome);
            
        }
    }
}