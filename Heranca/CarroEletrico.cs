using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class CarroEletrico : Carro    //  CarroEletrico herda de Carro
    {
        //Atributos
        public int bateria;
        public int tempoDeCarga;

        public override void MostrarInformacoes()
        {
            base.MostrarInformacoes();
            Console.WriteLine("Bateria: " + bateria);
            Console.WriteLine("Tempo de carga: " + tempoDeCarga);
        }
    }
}
