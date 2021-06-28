using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Bem vindo ao exercício de variáveis flutuantes!");
                
            // Conversão de salário flutuante para salário inteiro
            double salario;
            salario = 1500.50;

            int salariointeiro;
            salariointeiro = (int)salario;
            Console.WriteLine(salariointeiro);
            // Uso de variável que suporta números maiores
            long numerao;
            numerao = 13000000000;
            Console.WriteLine(numerao);

            Console.WriteLine("Fim do programa, digite ENTER para sair...");
            Console.ReadLine();
        }
    }
}
