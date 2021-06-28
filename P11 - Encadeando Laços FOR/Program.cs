using System;

namespace P11___Encadeando_Laços_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 11 - Calculador de Poupança (FOR) com aumento de fator de rendimento por ano.");

            double valorinvestido = 1000.00;
            double fatorrendimento = 1.0036;

            for (int contadorano = 1; contadorano <= 5; contadorano++)
            {
                for (int contador = 1; contador <= 12; contador++)
                {
                    valorinvestido *= fatorrendimento;
                    if (contador == 1)
                    {
                        Console.WriteLine("Após " + contador + " mês você terá: R$ " + valorinvestido);
                    }
                    else
                        Console.WriteLine("Após " + contador + " meses você terá: R$ " + valorinvestido);

                }
                fatorrendimento += 0.0010;
                Console.WriteLine("Valor Final: R$" + valorinvestido);
            }
            Console.ReadLine();
        }
    }
}
