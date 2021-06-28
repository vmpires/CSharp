using System;

namespace _5_Trabalhando_com_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5 - Trabalhando com IF");

            int idadeVictor = 29;

            if (idadeVictor >= 18)
            {
                Console.WriteLine("Victor é maior de idade.");
            }
            else
            {
                Console.WriteLine("Victor é menor de idade.");
            }
            Console.ReadLine();
        }
    }
}
