using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    class CarroAutomatico : ICarro    //usando interface ICarro
    {
        public void TrocarMarcha() {
            Console.WriteLine("Carro automático trocando a marcha ... ");
        }
    }
}
