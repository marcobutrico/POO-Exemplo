using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro
    {
        //Atributos
        public string modelo;
        public string marca;
        public int quilometragem;
    
    //virtual - Esse metodo pode ser sobrescrito
    public virtual void MostrarInformacoes() 
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Quilometragem: " + quilometragem);
        }

        
        //um modelo com mesmo nome pode receber coisas diferentes
        public virtual void MostrarInformacoes(string nome)
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Quilometragem: " + quilometragem);
            Console.WriteLine("Nome: " + nome);
        }


    }
}
