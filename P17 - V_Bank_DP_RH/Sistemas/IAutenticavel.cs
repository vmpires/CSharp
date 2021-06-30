using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Bank_DP_RH.Funcionarios;

namespace V_Bank_DP_RH.Sistemas
{
    public interface IAutenticavel
    {
            bool Autenticar(string senha);
    }
}
