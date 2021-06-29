using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Victor's Bank - Parte 3 - Criando a classe Cliente.");
            Console.WriteLine();
            ContaCorrente contadoVictor = new ContaCorrente();

            Cliente Victor = new Cliente();

            Victor.nome = "Victor Milhome Pires";
            Victor.cpf = "409.125.978.28";
            Victor.profissao = "Programador";


            contadoVictor.titular = Victor;
            contadoVictor.agencia = 8866;
            contadoVictor.numero = 194287;
            contadoVictor.saldo = 200.00;


            Console.WriteLine("O titular da conta se chama: " + contadoVictor.titular.nome);

            Console.WriteLine("----------------------------");

            Console.WriteLine("CPF: " + contadoVictor.titular.cpf);
            Console.WriteLine("Profissão: " + contadoVictor.titular.profissao);



        }
    }
}
