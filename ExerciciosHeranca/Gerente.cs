using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    class Gerente : Funcionario  // herda de Funcionario
    {

        public void Bonificar()
        {
            _salario *= 1.1;
        }
    }
}
