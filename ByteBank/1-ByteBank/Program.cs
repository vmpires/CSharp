using System;

namespace _1_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com Classes e Objetos");
            Console.WriteLine();
            ContaCorrente contaVictor = new ContaCorrente();

            contaVictor.titular = "Victor Milhome Pires";
            contaVictor.agencia = 4886;
            contaVictor.conta = 12345;
            contaVictor.saldo = 100.50;

            Console.WriteLine(contaVictor.titular);
            Console.WriteLine("Agência: " + contaVictor.agencia);
            Console.WriteLine("Conta nº: "+ contaVictor.conta);
            Console.WriteLine("Saldo: " + contaVictor.saldo);

            Console.ReadLine();


        }
    }
}
