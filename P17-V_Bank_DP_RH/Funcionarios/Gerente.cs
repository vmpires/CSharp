using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Bank_DP_RH.Funcionarios
{
    public class Gerente : Funcionario
    {
        public Gerente(string cpf) : base(3000, cpf)
        {

        }
        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public override void RaiseSalary()
        {
            Salario *= 1.10;
        }
    }
}
