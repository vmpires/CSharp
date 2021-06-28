using System;

namespace CalculaPoupancaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 10 - Calculador de Poupança com FOR");

            double valorinvestido = 1000.00;

            for (int contador = 1; contador <= 12; contador++)
            {
                valorinvestido *= 1.0036;
                if (contador == 1)
                {
                    Console.WriteLine("Após " + contador + " mês você terá: R$ " + valorinvestido);
                }
                else
                    Console.WriteLine("Após " + contador + " meses você terá: R$ " + valorinvestido);
            }

            Console.ReadLine();
        }
    }
}
