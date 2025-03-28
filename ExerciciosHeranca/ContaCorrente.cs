using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    class ContaCorrente : ContaBancaria    //ContaCorrente herda de ContaBancaria
        {
     public double CobrarTaxa()
    {
        _saldo -= 10;
        return _saldo;
    }
    }

}
