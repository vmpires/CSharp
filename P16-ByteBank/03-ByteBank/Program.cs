using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Victor's Bank - Parte 3 - Criando a classe Cliente e usando getters e setters.");
            Console.WriteLine();
            
            ContaCorrente contadoVictor = new ContaCorrente();

            Cliente Victor = new Cliente();

            Victor.Nome = "Victor Milhome Pires";
            Victor.CPF = "409.125.978.28";
            Victor.Profissao = "Programador";

            
            
            ContaCorrente contadaJaci = new ContaCorrente();

            Cliente Jaci = new Cliente();

            Jaci.Nome = "Jaciane Souza de Moraes";
            Jaci.CPF = "234.567.231.34";
            Jaci.Profissao = "Assit. Adm";

            contadaJaci.Titular = Jaci;
            


            Console.WriteLine("Saldo anterior: " + contadoVictor.Saldo);
            contadoVictor.Saldo = 254.00;
            Console.WriteLine("Saldo Final: " + contadoVictor.Saldo);


            Console.WriteLine("Saldo anterior: " + contadaJaci.Saldo);
            contadaJaci.Saldo = 500.00;
            Console.WriteLine("Saldo Final: " + contadaJaci.Saldo);



        }
    }
}
