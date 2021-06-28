using System;

namespace P14___Multiplos_de_3_entre_1_e_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 14 - Multiplos de 3 entre 1 e 100");

            for(int contador = 1; contador <=100; contador++)
            {
                if (contador % 3 == 0)
                    Console.WriteLine("O número "+ contador +" é múltiplo de 3.");
            } 
        }
    }
}
