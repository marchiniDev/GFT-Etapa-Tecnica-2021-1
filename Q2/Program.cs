using System;

namespace Q2
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
            if (!(fim - inicio < 215 || fim - inicio > 10))
            {
                Console.WriteLine("Intervalor deve ser de 10 e 215");
            }
            else
            {
                for (int i = inicio; i <= fim; i++)
                {
                    if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
