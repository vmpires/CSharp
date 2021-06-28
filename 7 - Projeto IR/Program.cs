using System;

namespace _7___Projeto_IR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto IR");

            double salario = 3800.00;

            if (salario >= 1900 && salario <= 2800)
            {
                Console.WriteLine("O IR é de 7,5% e pode deduzir na declaração o valor de R$ 142,00");
            }

            else if (salario >= 2800.01 && salario <= 3751.00)
            {
                Console.WriteLine("O IR é de 15% e pode deduzir na declaração o valor de R$ 350,00");
            }

            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("O IR é de 22,5% e pode deduzir na declaração o valor de R$ 636,00");
            }


            Console.ReadLine();
        }
    }
}
