using System;

namespace _18_Exception_and_errors_treatment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 18 - Tratamento de Erros e Exceções");
            Console.WriteLine();

            Cliente victor = new Cliente();
            victor.Nome = "Victor Pires";
            victor.CPF = "408.193.841-28";
            victor.Profissao = "Programador";

            ContaCorrente contaVictor = new ContaCorrente(4886, 29481-45);

            contaVictor.Titular = victor;

            Console.WriteLine(contaVictor.Titular.Nome);
            Console.WriteLine(contaVictor.Titular.CPF);
            Console.WriteLine(contaVictor.Agencia);
            Console.WriteLine(contaVictor.Numero);


        }
    }
}
