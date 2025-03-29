using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHeranca.Contas
{
    class ContaBancaria
    {
        //Atributos
        protected double _saldo = 0;

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Sacar(double valor)
        {
            _saldo -= valor;
        }

        public void VerSaldo()
        {
            Console.WriteLine($"Saldo: R$ {_saldo}");
        }

    }
}
