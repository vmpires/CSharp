using System;
using V_Bank_DP_RH.Funcionarios;
using V_Bank_DP_RH.Sistemas;

namespace V_Bank_DP_RH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto V Bank - Departamento Pessoal e RH");

            Console.WriteLine();

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario Victor = new Presidente("39817819843");
            Victor.Nome = "Victor Pires";

            //No caso concreto apenas a diretora tem acesso ao sistema interno do V Bank.
            Diretor Jaci = new Diretor("27184014790");
            Jaci.Nome = "Jaciane Moraes";
            Jaci.Senha = "123";

            //No caso concreto também temos um Parceiro Comercial Autenticavel
            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "12345";

            Funcionario Zonan = new Gerente("23084787478");
            Zonan.Nome = "Zonome";


            Console.WriteLine(Victor.Nome);

            Console.WriteLine("Salário Presidente Victor antes do aumento: R$" + Victor.Salario);

            Victor.RaiseSalary();

            Console.WriteLine("Salário Presidente Victor APÓS do aumento(30%): R$" + Victor.Salario);

            gerenciador.Registrar(Victor);

            Console.WriteLine("Bônus de Presidente (30%): R$" + Victor.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine(Jaci.Nome);

            Console.WriteLine("Salário Diretora Jaci antes do aumento: R$" + Jaci.Salario);

            Jaci.RaiseSalary();

            Console.WriteLine("Salário Diretora Jaci APÓS do aumento(20%): R$" + Jaci.Salario);

            gerenciador.Registrar(Jaci);

            Console.WriteLine("Bônus de Diretora (20%): R$" + Jaci.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine(Zonan.Nome);

            Console.WriteLine("Salário Gerente Zonan antes do aumento: R$" + Zonan.Salario);

            Zonan.RaiseSalary();

            Console.WriteLine("Salário Gerente Zonan APÓS do aumento(10%): R$" + Zonan.Salario);

            gerenciador.Registrar(Zonan);

            Console.WriteLine("Bônus de Gerente (10%): R$" + Zonan.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine("Total de bonificações: R$" + gerenciador.GetTotalBonificacao());

            Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

            SistemaInterno sistemainterno = new SistemaInterno();

            // Tentativa de login pela Diretora 
            sistemainterno.Logar(Jaci, "123");

            //Tentativa de Login Parceiro Comercial
            sistemainterno.Logar(parceiro, "12345");


            Console.ReadLine();
        }
    }
}
