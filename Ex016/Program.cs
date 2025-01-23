namespace Ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Descubra a tabuada do número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tabuada do {0}", num);

            for (int i = 1; i <= 10; i++)
            { 
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
        }
    }
}
