using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Exception_and_errors_treatment
{
    public class ContaCorrente
    {

        public static int TotaldeContas { get; private set; }
        public static int TaxaOperacao { get; private set; }
        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <=0)
            {
                throw new ArgumentException("A Agência deve ser maior que 0.", nameof(agencia));
            }
            if (numero <= 0)
            {
                throw new ArgumentException("O Número da conta deve ser maior que 0.", nameof(numero));
            }
            
            Agencia = agencia;
            Numero = numero;
            TotaldeContas++;
            TaxaOperacao = 30 / TotaldeContas;

        }

        public Cliente Titular { get; set; }
        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo = 0.00;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            
            set
            {
                if (value < 0)
                {
                    return;
                }
                
                _saldo = value;
            }
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
