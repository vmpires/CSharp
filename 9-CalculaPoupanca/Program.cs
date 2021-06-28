using System;

namespace _9_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Calcula Poupança");

            double valorinvestido = 1000.00;
            int contador = 1;

            while (contador <= 12)
            {
                valorinvestido = valorinvestido + valorinvestido * 0.0036;
                // 0.36% = 0.0036
                Console.WriteLine("Após " + contador + " mês você terá: R$ " + valorinvestido);
                contador++;
            }


            Console.ReadLine();
        }
    }
}
