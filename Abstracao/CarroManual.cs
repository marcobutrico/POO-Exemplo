﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    class CarroManual : ICarro    //usando interface ICarro
    {
        public void TrocarMarcha() {
            Console.WriteLine("Carro manual trocando a marcha ... ");
        }
    }
}
