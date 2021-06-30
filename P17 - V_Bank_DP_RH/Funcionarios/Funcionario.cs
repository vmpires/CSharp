using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Bank_DP_RH.Sistemas;

namespace V_Bank_DP_RH.Funcionarios
{
    public abstract class Funcionario 
    {
        public static int TotalFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        public abstract double GetBonificacao();

        public abstract void RaiseSalary();

    }
}
