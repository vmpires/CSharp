using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Bank_DP_RH.Funcionarios
{
    public class Presidente : Funcionario
    {
        public Presidente(string cpf) : base(8000, cpf)
        {

        }
        public override double GetBonificacao()
        {
            return Salario * 0.3;
        }

        public override void RaiseSalary()
        {
            Salario *= 1.30;
        }
    }
}
