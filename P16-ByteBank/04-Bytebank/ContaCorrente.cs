using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    public class ContaCorrente
    {

        public static int TotaldeContas { get; private set; }
        public static int TaxaOperacao { get; private set; }
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TaxaOperacao = 30 / TotaldeContas;
            TotaldeContas++;

        }

        public Cliente Titular { get; set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _agencia = value;
                }
            }
        }
        public int Numero { get; set; }

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
