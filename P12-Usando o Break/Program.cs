using System;

namespace _12_Usando_o_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 12 - Trabalhando com BREAK");

            for (int contadorcoluna = 0; contadorcoluna <= 10; contadorcoluna++)
            {
                for (int contadorlinha = 0; contadorlinha <= 10; contadorlinha++)
                {
                    Console.Write("*");
                    if (contadorlinha >= contadorcoluna)
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
