using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Bank_DP_RH.Sistemas;

namespace V_Bank_DP_RH.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }

        public override void RaiseSalary()
        {
            Salario *= 1.20;
        }
    }
}
