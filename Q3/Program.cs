using System;

namespace Q3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor inicial do intervalor");
            int inicio = Int32.Parse(Console.ReadLine());   

            Console.WriteLine("Digite o valor final do intervalor");
            int fim = Int32.Parse(Console.ReadLine());

            if (fim < inicio)
            {
                Console.WriteLine("Valor final deve ser maior que valor inicial");
            }
            if (!(fim - inicio < 15 || fim - inicio > 0))
            {
                Console.WriteLine("Intervalor deve ser de 1 e 15");
            }
            else
            {
                for (int i = inicio; i <= fim; i++)
                {
                    Console.WriteLine(Math.Pow(i, 3));                    
                }
            }
        }
    }
}
