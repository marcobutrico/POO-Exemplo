using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHeranca.Contas
{
    class ContaCorrente : ContaBancaria    //ContaCorrente herda de ContaBancaria
    {
        public void CobrarTaxa()
        {
            _saldo -= 10;
        }
    }

}
