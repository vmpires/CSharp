using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto ByteBank 2 - Populando as propriedades e funções da conta");
            ContaCorrente contaVictor = new ContaCorrente();

            contaVictor.titular = "Victor Milhome Pires";
            contaVictor.agencia = 4886;
            contaVictor.numero = 12345;
            contaVictor.saldo = 5000.00;

            ContaCorrente contaJaci = new ContaCorrente();

            contaJaci.titular = "Jaciane Souza de Moraes";
            contaJaci.agencia = 4887;
            contaJaci.numero = 54321;
            contaJaci.saldo = 7000.00;

            Console.WriteLine(contaVictor.titular);
            Console.WriteLine("Agência: " + contaVictor.agencia);
            Console.WriteLine("Conta nº: " + contaVictor.numero);
            Console.WriteLine("Saldo: " + contaVictor.saldo);

            contaVictor.Sacar(500.00);

            Console.WriteLine("Novo Saldo: " + contaVictor.saldo);
            
            
            contaVictor.Depositar(350.00);
            Console.WriteLine("Novo Saldo: " + contaVictor.saldo);


            contaJaci.Transferir(500.00, contaVictor);
            Console.WriteLine("Novo Saldo: " + contaVictor.saldo);
            Console.WriteLine("Novo Saldo: " + contaJaci.saldo);

        }
    }
}
