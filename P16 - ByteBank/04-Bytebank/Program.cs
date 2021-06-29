using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 4 - Usando construtores e Membros estáticos");

            ContaCorrente contadoVictor = new ContaCorrente(2356, 239487);

            Cliente Victor = new Cliente();

            Victor.Nome = "Victor Pires";
            Victor.CPF = "234807823842487";
            Victor.Profissao = "Desenvolvedor";

            contadoVictor.Titular = Victor;

            Console.WriteLine(contadoVictor.Titular.Nome);
            Console.WriteLine(contadoVictor.Titular.CPF);
            Console.WriteLine(contadoVictor.Agencia);
            Console.WriteLine(contadoVictor.Numero);


            ContaCorrente contadoZonan = new ContaCorrente(2334, 839487);

            Cliente Zonan = new Cliente();

            Zonan.Nome = "Renan Carvalhal";
            Zonan.CPF = "7348078238";
            Zonan.Profissao = "Advogado";

            contadoZonan.Titular = Zonan;
            
            Console.WriteLine(contadoZonan.Titular.Nome);
            Console.WriteLine(contadoZonan.Titular.CPF);
            Console.WriteLine(contadoZonan.Agencia);
            Console.WriteLine(contadoZonan.Numero);

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotaldeContas);

            Console.ReadLine();
        }
    }
}
