using System;

namespace _6_Condicionais_e_booleanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int idadeVictor = 29;
            int pessoas = 1;

            if (idadeVictor >= 18 || pessoas >= 2)
            {
                Console.WriteLine("Victor, pode entrar.");
            }
            else
            {
                Console.WriteLine("Victor não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
