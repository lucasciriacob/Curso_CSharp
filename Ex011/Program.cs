using System;
using System.ComponentModel.Design;

namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Informe o tamanho da primeira reta: "); 
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o tamanho da segunda reta: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o tamanho da terceira reta: ");
            c = Convert.ToInt32(Console.ReadLine());


            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.WriteLine("É possível formar um triângulo com essas retas.");
                if(a == b && b == c)
                {
                    Console.WriteLine("O triângulo formado é equilátero.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("O triângulo formado é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo formado é escaleno.");
                }
            }
            else 
            {
                Console.WriteLine("Não é possível formar um triângulo com essas retas.");
            }
            








        }
    }
}
