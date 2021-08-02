using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Bank_DP_RH.Funcionarios;

namespace V_Bank_DP_RH.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool autenticado = funcionario.Autenticar(senha);

            if (autenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema Interno do V Bank!");
                return true;
            }
            Console.WriteLine("Senha Incorreta!");
            return false;
        }


    }
}
