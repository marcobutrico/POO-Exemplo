using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHeranca.Contas
{
    class ContaPoupanca : ContaBancaria    //  ContaPoupanca herda de ContaBancaria
    {
        public double RenderJuros()
        {
            _saldo *= 1.05;
            return _saldo;
        }

    }
}
